using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EnvironmentAssessment.Common.Sspi.Buffers;
using EnvironmentAssessment.Common.Sspi.Credentials;

namespace EnvironmentAssessment.Common.Sspi.Contexts
{
    /// <summary>
    /// Represents a security context and provides common functionality required for all security 
    /// contexts.
    /// </summary>
    /// <remarks>
    /// This class is abstract and has a protected constructor and Initialize method. The exact 
    /// initialization implementation is provided by a subclasses, which may perform initialization 
    /// in a variety of manners.
    /// </remarks>
    public abstract class CContext : IDisposable
    {
        /// <summary>
        /// Performs basic initialization of a new instance of the Context class.
        /// Initialization is not complete until the ContextHandle property has been set
        /// and the Initialize method has been called.
        /// </summary>
        /// <param name="cred"></param>
        protected CContext( CCredential cred )
        {
            this.Credential = cred;

            this.ContextHandle = new CSafeContextHandle();

            this.Disposed = false;
            this.Initialized = false;
        }

        /// <summary>
        /// Whether or not the context is fully formed.
        /// </summary>
        public bool Initialized { get; private set; }

        /// <summary>
        /// The credential being used by the context to authenticate itself to other actors.
        /// </summary>
        protected CCredential Credential { get; private set; }

        /// <summary>
        /// A reference to the security context's handle.
        /// </summary>
        public CSafeContextHandle ContextHandle { get; private set; }

        /// <summary>
        /// The name of the authenticating authority for the context.
        /// </summary>
        public string AuthorityName
        {
            get
            {
                CheckLifecycle();
                return QueryContextString( CContextQueryAttrib.Authority );
            }
        }

        /// <summary>
        /// The logon username that the context represents.
        /// </summary>
        public string ContextUserName
        {
            get
            {
                CheckLifecycle();
                return QueryContextString( CContextQueryAttrib.Names );
            }
        }

        /// <summary>
        /// The UTC time when the context expires.
        /// </summary>
        public DateTime Expiry { get; private set; }

        /// <summary>
        /// Whether the context has been disposed.
        /// </summary>
        public bool Disposed { get; private set; }

        /// <summary>
        /// Marks the context as having completed the initialization process, ie, exchanging of authentication tokens.
        /// </summary>
        /// <param name="expiry">The date and time that the context will expire.</param>
        protected void Initialize( DateTime expiry )
        {
            this.Expiry = expiry;
            this.Initialized = true;
        }

        /// <summary>
        /// Releases all resources associated with the context.
        /// </summary>
        public void Dispose()
        {
            Dispose( true );
            GC.SuppressFinalize( this );
        }

        /// <summary>
        /// Releases resources associated with the context.
        /// </summary>
        /// <param name="disposing">If true, release managed resources, else release only unmanaged resources.</param>
        protected virtual void Dispose( bool disposing )
        {
            if( this.Disposed ) { return; }

            if( disposing )
            {
                if (this.ContextHandle != null) { this.ContextHandle.Dispose(); }
            }

            this.Disposed = true;
        }

        /// <summary>
        /// Encrypts the byte array using the context's session key.
        /// </summary>
        /// <remarks>
        /// The structure of the returned data is as follows:
        ///  - 2 bytes, an unsigned big-endian integer indicating the length of the trailer buffer size
        ///  - 4 bytes, an unsigned big-endian integer indicating the length of the message buffer size.
        ///  - 2 bytes, an unsigned big-endian integer indicating the length of the encryption padding buffer size.
        ///  - The trailer buffer
        ///  - The message buffer
        ///  - The padding buffer.
        /// </remarks>
        /// <param name="input">The raw message to encrypt.</param>
        /// <returns>The packed and encrypted message.</returns>
        public byte[] Encrypt( byte[] input )
        {
            // The message is encrypted in place in the buffer we provide to Win32 EncryptMessage
            CSecPkgContext_Sizes sizes;

            CSecureBuffer trailerBuffer;
            CSecureBuffer dataBuffer;
            CSecureBuffer paddingBuffer;
            CSecureBufferAdapter adapter;

            CSecurityStatus status = CSecurityStatus.InvalidHandle;
            byte[] result;

            CheckLifecycle();

            sizes = QueryBufferSizes();

            trailerBuffer = new CSecureBuffer( new byte[sizes.SecurityTrailer], CBufferType.Token );
            dataBuffer = new CSecureBuffer( new byte[input.Length], CBufferType.Data );
            paddingBuffer = new CSecureBuffer( new byte[sizes.BlockSize], CBufferType.Padding );

            Array.Copy( input, dataBuffer.Buffer, input.Length );

            using( adapter = new CSecureBufferAdapter( new[] { trailerBuffer, dataBuffer, paddingBuffer } ) )
            {
                status = CContextNativeMethods.SafeEncryptMessage(
                    this.ContextHandle,
                    0,
                    adapter,
                    0
                );
            }

            if( status != CSecurityStatus.OK )
            {
                throw new CSSPIException( "Failed to encrypt message", status );
            }

            int position = 0;

            // Enough room to fit:
            //  -- 2 bytes for the trailer buffer size
            //  -- 4 bytes for the message size
            //  -- 2 bytes for the padding size.
            //  -- The encrypted message
            result = new byte[2 + 4 + 2 + trailerBuffer.Length + dataBuffer.Length + paddingBuffer.Length];

            CByteWriter.WriteInt16_BE( (short)trailerBuffer.Length, result, position );
            position += 2;

            CByteWriter.WriteInt32_BE( dataBuffer.Length, result, position );
            position += 4;

            CByteWriter.WriteInt16_BE( (short)paddingBuffer.Length, result, position );
            position += 2;

            Array.Copy( trailerBuffer.Buffer, 0, result, position, trailerBuffer.Length );
            position += trailerBuffer.Length;

            Array.Copy( dataBuffer.Buffer, 0, result, position, dataBuffer.Length );
            position += dataBuffer.Length;

            Array.Copy( paddingBuffer.Buffer, 0, result, position, paddingBuffer.Length );
            position += paddingBuffer.Length;
                        
            return result;
        }

        /// <summary>
        /// Decrypts a previously encrypted message.
        /// </summary>
        /// <remarks>
        /// The expected format of the buffer is as follows:
        ///  - 2 bytes, an unsigned big-endian integer indicating the length of the trailer buffer size
        ///  - 4 bytes, an unsigned big-endian integer indicating the length of the message buffer size.
        ///  - 2 bytes, an unsigned big-endian integer indicating the length of the encryption padding buffer size.
        ///  - The trailer buffer
        ///  - The message buffer
        ///  - The padding buffer.
        /// </remarks>
        /// <param name="input">The packed and encrypted data.</param>
        /// <returns>The original plaintext message.</returns>
        public byte[] Decrypt( byte[] input )
        {
            CSecPkgContext_Sizes sizes;

            CSecureBuffer trailerBuffer;
            CSecureBuffer dataBuffer;
            CSecureBuffer paddingBuffer;
            CSecureBufferAdapter adapter;

            CSecurityStatus status;
            byte[] result = null;
            int remaining;
            int position;

            int trailerLength;
            int dataLength;
            int paddingLength;

            CheckLifecycle();

            sizes = QueryBufferSizes();

            // This check is required, but not sufficient. We could be stricter.
            if( input.Length < 2 + 4 + 2 + sizes.SecurityTrailer )
            {
                throw new ArgumentException( "Buffer is too small to possibly contain an encrypted message" );
            }

            position = 0;

            trailerLength = CByteWriter.ReadInt16_BE( input, position );
            position += 2;

            dataLength = CByteWriter.ReadInt32_BE( input, position );
            position += 4;

            paddingLength = CByteWriter.ReadInt16_BE( input, position );
            position += 2;

            if ( trailerLength + dataLength + paddingLength + 2 + 4 + 2 > input.Length )
            {
                throw new ArgumentException( "The buffer contains invalid data - the embedded length data does not add up." );
            }

            trailerBuffer = new CSecureBuffer( new byte[trailerLength], CBufferType.Token );
            dataBuffer = new CSecureBuffer( new byte[dataLength], CBufferType.Data );
            paddingBuffer = new CSecureBuffer( new byte[paddingLength], CBufferType.Padding );

            remaining = input.Length - position;

            if( trailerBuffer.Length <= remaining )
            {
                Array.Copy( input, position, trailerBuffer.Buffer, 0, trailerBuffer.Length );
                position += trailerBuffer.Length;
                remaining -= trailerBuffer.Length;
            }
            else
            {
                throw new ArgumentException( "Input is missing data - it is not long enough to contain a fully encrypted message" );
            }
            
            if( dataBuffer.Length <= remaining )
            {
                Array.Copy( input, position, dataBuffer.Buffer, 0, dataBuffer.Length );
                position += dataBuffer.Length;
                remaining -= dataBuffer.Length;
            }
            else
            {
                throw new ArgumentException( "Input is missing data - it is not long enough to contain a fully encrypted message" );
            }

            if( paddingBuffer.Length <= remaining )
            {
                Array.Copy( input, position, paddingBuffer.Buffer, 0, paddingBuffer.Length );
            }
            // else there was no padding.
            

            using( adapter = new CSecureBufferAdapter( new [] { trailerBuffer, dataBuffer, paddingBuffer } ) )
            {
                status = CContextNativeMethods.SafeDecryptMessage(
                    this.ContextHandle,
                    0,
                    adapter,
                    0
                );
            }

            if( status != CSecurityStatus.OK )
            {
                throw new CSSPIException( "Failed to encrypt message", status );
            }

            result = new byte[dataBuffer.Length];
            Array.Copy( dataBuffer.Buffer, 0, result, 0, dataBuffer.Length );

            return result;
        }

        /// <summary>
        /// Signs the message using the context's session key.
        /// </summary>
        /// <remarks>
        /// The structure of the returned buffer is as follows:
        ///  - 4 bytes, unsigned big-endian integer indicating the length of the plaintext message
        ///  - 2 bytes, unsigned big-endian integer indicating the length of the signture
        ///  - The plaintext message
        ///  - The message's signature.
        /// </remarks>
        /// <param name="message"></param>
        /// <returns></returns>
        public byte[] MakeSignature( byte[] message )
        {
            CSecurityStatus status = CSecurityStatus.InternalError;

            CSecPkgContext_Sizes sizes;
            CSecureBuffer dataBuffer;
            CSecureBuffer signatureBuffer;
            CSecureBufferAdapter adapter;

            CheckLifecycle();

            sizes = QueryBufferSizes();

            dataBuffer = new CSecureBuffer( new byte[message.Length], CBufferType.Data );
            signatureBuffer = new CSecureBuffer( new byte[sizes.MaxSignature], CBufferType.Token );

            Array.Copy( message, dataBuffer.Buffer, message.Length );

            using ( adapter = new CSecureBufferAdapter( new[] { dataBuffer, signatureBuffer } ) )
            {
                status = CContextNativeMethods.SafeMakeSignature(
                    this.ContextHandle,
                    0,
                    adapter,
                    0
                );
            }

            if ( status != CSecurityStatus.OK )
            {
                throw new CSSPIException( "Failed to create message signature.", status );
            }

            byte[] outMessage;
            int position = 0;

            // Enough room for 
            //  - original message length (4 bytes)
            //  - signature length        (2 bytes)
            //  - original message
            //  - signature

            outMessage = new byte[4 + 2 + dataBuffer.Length + signatureBuffer.Length];

            CByteWriter.WriteInt32_BE( dataBuffer.Length, outMessage, position );
            position += 4;

            CByteWriter.WriteInt16_BE( (Int16)signatureBuffer.Length, outMessage, position );
            position += 2;

            Array.Copy( dataBuffer.Buffer, 0, outMessage, position, dataBuffer.Length );
            position += dataBuffer.Length;

            Array.Copy( signatureBuffer.Buffer, 0, outMessage, position, signatureBuffer.Length );
            position += signatureBuffer.Length;

            return outMessage;
        }

        /// <summary>
        /// Verifies the signature of a signed message
        /// </summary>
        /// <remarks>
        /// The expected structure of the signed message buffer is as follows:
        ///  - 4 bytes, unsigned integer in big endian format indicating the length of the plaintext message
        ///  - 2 bytes, unsigned integer in big endian format indicating the length of the signture
        ///  - The plaintext message
        ///  - The message's signature.
        /// </remarks>
        /// <param name="signedMessage">The packed signed message.</param>
        /// <param name="origMessage">The extracted original message.</param>
        /// <returns>True if the message has a valid signature, false otherwise.</returns>
        public bool VerifySignature( byte[] signedMessage, out byte[] origMessage )
        {
            CSecurityStatus status = CSecurityStatus.InternalError;

            CSecPkgContext_Sizes sizes;
            CSecureBuffer dataBuffer;
            CSecureBuffer signatureBuffer;
            CSecureBufferAdapter adapter;

            CheckLifecycle();

            sizes = QueryBufferSizes();
            
            if ( signedMessage.Length < 2 + 4 + sizes.MaxSignature )
            {
                throw new ArgumentException( "Input message is too small to possibly fit a valid message" );
            }

            int position = 0;
            int messageLen;
            int sigLen;

            messageLen = CByteWriter.ReadInt32_BE( signedMessage, 0 );
            position += 4;

            sigLen = CByteWriter.ReadInt16_BE( signedMessage, position );
            position += 2;

            if ( messageLen + sigLen + 2 + 4 > signedMessage.Length )
            {
                throw new ArgumentException( "The buffer contains invalid data - the embedded length data does not add up." );
            }

            dataBuffer = new CSecureBuffer( new byte[messageLen], CBufferType.Data );
            Array.Copy( signedMessage, position, dataBuffer.Buffer, 0, messageLen );
            position += messageLen;

            signatureBuffer = new CSecureBuffer( new byte[sigLen], CBufferType.Token );
            Array.Copy( signedMessage, position, signatureBuffer.Buffer, 0, sigLen );
            position += sigLen;

            using ( adapter = new CSecureBufferAdapter( new[] { dataBuffer, signatureBuffer } ) )
            {
                status = CContextNativeMethods.SafeVerifySignature(
                    this.ContextHandle,
                    0,
                    adapter,
                    0
                );
            }

            if ( status == CSecurityStatus.OK )
            {
                origMessage = dataBuffer.Buffer;
                return true;
            }
            else if ( status == CSecurityStatus.MessageAltered ||
                      status == CSecurityStatus.OutOfSequence )
            {
                origMessage = null;
                return false;
            }
            else
            {
                throw new CSSPIException( "Failed to determine the veracity of a signed message.", status );
            }
        }

        /// <summary>
        /// Queries the security package's expections regarding message/token/signature/padding buffer sizes.
        /// </summary>
        /// <returns></returns>
        private CSecPkgContext_Sizes QueryBufferSizes()
        {
            CSecPkgContext_Sizes sizes = new CSecPkgContext_Sizes();
            CSecurityStatus status = CSecurityStatus.InternalError;
            bool gotRef = false;

            RuntimeHelpers.PrepareConstrainedRegions();
            try
            {
                this.ContextHandle.DangerousAddRef( ref gotRef );
            }
            catch ( Exception )
            {
                if ( gotRef )
                {
                    this.ContextHandle.DangerousRelease();
                    gotRef = false;
                }

                throw;
            }
            finally
            {
                if ( gotRef )
                {
                    status = CContextNativeMethods.QueryContextAttributes_Sizes(
                        ref this.ContextHandle.rawHandle,
                        CContextQueryAttrib.Sizes,
                        ref sizes
                    );
                    this.ContextHandle.DangerousRelease();
                }
            }

            if( status != CSecurityStatus.OK )
            {
                throw new CSSPIException( "Failed to query context buffer size attributes", status );
            }

            return sizes;
        }

        /// <summary>
        /// Queries a string-valued context attribute by the named attribute.
        /// </summary>
        /// <param name="attrib">The string-valued attribute to query.</param>
        /// <returns></returns>
        private string QueryContextString(CContextQueryAttrib attrib)
        {
            CSecPkgContext_String stringAttrib;
            CSecurityStatus status = CSecurityStatus.InternalError;
            string result = null;
            bool gotRef = false;

            if( attrib != CContextQueryAttrib.Names && attrib != CContextQueryAttrib.Authority )
            {
                throw new InvalidOperationException( "QueryContextString can only be used to query context Name and Authority attributes" );
            }

            stringAttrib = new CSecPkgContext_String();

            RuntimeHelpers.PrepareConstrainedRegions();
            try
            {
                this.ContextHandle.DangerousAddRef( ref gotRef );
            }
            catch ( Exception )
            {
                if ( gotRef )
                {
                    this.ContextHandle.DangerousRelease();
                    gotRef = false;
                }
                throw;
            }
            finally
            {
                if ( gotRef )
                {
                    status = CContextNativeMethods.QueryContextAttributes_String(
                        ref this.ContextHandle.rawHandle,
                        attrib,
                        ref stringAttrib
                    );

                    this.ContextHandle.DangerousRelease();

                    if ( status == CSecurityStatus.OK )
                    {
                        result = Marshal.PtrToStringUni( stringAttrib.StringResult );
                        CContextNativeMethods.FreeContextBuffer( stringAttrib.StringResult );
                    }
                }
            }
            
            if( status == CSecurityStatus.Unsupported )
            {
                return null;
            }
            else if( status != CSecurityStatus.OK )
            {
                throw new CSSPIException( "Failed to query the context's associated user name", status );
            }

            return result;
        }

        /// <summary>
        /// Verifies that the object's lifecycle (initialization / disposition) state is suitable for using the 
        /// object.
        /// </summary>
        private void CheckLifecycle()
        {
            if( this.Initialized == false )
            {
                throw new InvalidOperationException( "The context is not yet fully formed." );
            }
            else if( this.Disposed )
            {
                throw new ObjectDisposedException( "Context" );
            }
        }
    }
}
