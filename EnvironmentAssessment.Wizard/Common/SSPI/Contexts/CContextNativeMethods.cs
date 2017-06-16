using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using EnvironmentAssessment.Common.SSPI.Buffers;

namespace EnvironmentAssessment.Common.SSPI.Contexts
{
    /// <summary>
    /// Declares native methods calls for security context-related win32 functions.
    /// </summary>
    internal static class CContextNativeMethods
    {
        /*
        SECURITY_STATUS SEC_Entry AcceptSecurityContext(
          _In_opt_     PCredHandle phCredential,
          _Inout_      PCtxtHandle phContext,
          _In_opt_     PSecBufferDesc pInput,
          _In_         ULONG fContextReq,
          _In_         ULONG TargetDataRep,
          _Inout_opt_  PCtxtHandle phNewContext,
          _Inout_opt_  PSecBufferDesc pOutput,
          _Out_        PULONG pfContextAttr,
          _Out_opt_    PTimeStamp ptsTimeStamp
        );
         
        SECURITY_STATUS SEC_Entry InitializeSecurityContext(
          _In_opt_     PCredHandle phCredential,                // [in] handle to the credentials
          _In_opt_     PCtxtHandle phContext,                   // [in/out] handle of partially formed context. Always NULL the first time through
          _In_opt_     SEC_CHAR *pszTargetName,                 // [in] name of the target of the context. Not needed by NTLM
          _In_         ULONG fContextReq,                       // [in] required context attributes
          _In_         ULONG Reserved1,                         // [reserved] reserved; must be zero
          _In_         ULONG TargetDataRep,                     // [in] data representation on the target
          _In_opt_     PSecBufferDesc pInput,                   // [in/out] pointer to the input buffers.  Always NULL the first time through
          _In_         ULONG Reserved2,                         // [reserved] reserved; must be zero
          _Inout_opt_  PCtxtHandle phNewContext,                // [in/out] receives the new context handle (must be pre-allocated)
          _Inout_opt_  PSecBufferDesc pOutput,                  // [out] pointer to the output buffers
          _Out_        PULONG pfContextAttr,                    // [out] receives the context attributes
          _Out_opt_    PTimeStamp ptsExpiry                     // [out] receives the life span of the security context
        );
        */

        [DllImport( "Secur32.dll", EntryPoint = "AcceptSecurityContext",CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus AcceptSecurityContext_1(
            ref CRawSspiHandle credHandle,
            IntPtr oldContextHandle,
            IntPtr inputBuffer,
            CContextAttrib requestedAttribs,
            CSecureBufferDataRep dataRep,
            ref CRawSspiHandle newContextHandle,
            IntPtr outputBuffer,
            ref CContextAttrib outputAttribs,
            ref CTimeStamp expiry
        );


        [DllImport( "Secur32.dll", EntryPoint = "AcceptSecurityContext", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus AcceptSecurityContext_2(
            ref CRawSspiHandle credHandle,
            ref CRawSspiHandle oldContextHandle,
            IntPtr inputBuffer,
            CContextAttrib requestedAttribs,
            CSecureBufferDataRep dataRep,
            ref CRawSspiHandle newContextHandle,
            IntPtr outputBuffer,
            ref CContextAttrib outputAttribs,
            ref CTimeStamp expiry
        );


        [DllImport( "Secur32.dll", EntryPoint = "InitializeSecurityContext", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus InitializeSecurityContext_1(
            ref CRawSspiHandle credentialHandle,
            IntPtr zero,
            string serverPrincipleName,
            CContextAttrib requiredAttribs,
            int reserved1,
            CSecureBufferDataRep dataRep,
            IntPtr inputBuffer,
            int reserved2,
            ref CRawSspiHandle newContextHandle,
            IntPtr outputBuffer,
            ref CContextAttrib contextAttribs,
            ref CTimeStamp expiry
        );


        [DllImport( "Secur32.dll", EntryPoint = "InitializeSecurityContext", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus InitializeSecurityContext_2(
            ref CRawSspiHandle credentialHandle,
            ref CRawSspiHandle previousHandle,
            string serverPrincipleName,
            CContextAttrib requiredAttribs,
            int reserved1,
            CSecureBufferDataRep dataRep,
            IntPtr inputBuffer,
            int reserved2,
            ref CRawSspiHandle newContextHandle,
            IntPtr outputBuffer,
            ref CContextAttrib contextAttribs,
            ref CTimeStamp expiry
        );

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success )]
        [DllImport( "Secur32.dll", EntryPoint = "DeleteSecurityContext", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus DeleteSecurityContext( ref CRawSspiHandle contextHandle );


        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail )]
        [DllImport( "Secur32.dll", EntryPoint = "EncryptMessage", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus EncryptMessage(
            ref CRawSspiHandle contextHandle,
            int qualityOfProtection,
            IntPtr bufferDescriptor,
            int sequenceNumber
        );

        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.MayFail )]
        [DllImport( "Secur32.dll", EntryPoint = "DecryptMessage", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus DecryptMessage(
            ref CRawSspiHandle contextHandle,
            IntPtr bufferDescriptor,
            int sequenceNumber,
            int qualityOfProtection
        );

        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.MayFail )]
        [DllImport( "Secur32.dll", EntryPoint = "MakeSignature", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus MakeSignature(
            ref CRawSspiHandle contextHandle,
            int qualityOfProtection,
            IntPtr bufferDescriptor,
            int sequenceNumber
        );

        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.MayFail )]
        [DllImport( "Secur32.dll", EntryPoint = "VerifySignature", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus VerifySignature(
            ref CRawSspiHandle contextHandle,
            IntPtr bufferDescriptor,
            int sequenceNumber,
            int qualityOfProtection
        );

        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success )]
        [DllImport( "Secur32.dll", EntryPoint = "QueryContextAttributes", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus QueryContextAttributes_Sizes(
            ref CRawSspiHandle contextHandle,
            CContextQueryAttrib attrib,
            ref CSecPkgContext_Sizes sizes
        );

        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success)]
        [DllImport( "Secur32.dll", EntryPoint = "QueryContextAttributes", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus QueryContextAttributes_String(
            ref CRawSspiHandle contextHandle,
            CContextQueryAttrib attrib,
            ref CSecPkgContext_String names
        );

        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success )]
        [DllImport( "Secur32.dll", EntryPoint = "FreeContextBuffer", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus FreeContextBuffer( IntPtr handle );


        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success )]
        [DllImport( "Secur32.dll", EntryPoint = "ImpersonateSecurityContext", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus ImpersonateSecurityContext( ref CRawSspiHandle contextHandle );

        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success )]
        [DllImport( "Secur32.dll", EntryPoint = "RevertSecurityContext", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus RevertSecurityContext( ref CRawSspiHandle contextHandle );

        /// <summary>
        /// Safely invokes the native EncryptMessage function, making sure that handle ref counting is 
        /// performed in a proper CER.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="qualityOfProtection"></param>
        /// <param name="bufferAdapter"></param>
        /// <param name="sequenceNumber"></param>
        /// <returns></returns>
        internal static CSecurityStatus SafeEncryptMessage(
            CSafeContextHandle handle,
            int qualityOfProtection,
            CSecureBufferAdapter bufferAdapter,
            int sequenceNumber )
        {
            CSecurityStatus status = CSecurityStatus.InternalError;
            bool gotRef = false;

            RuntimeHelpers.PrepareConstrainedRegions();
            try
            {
                handle.DangerousAddRef( ref gotRef );
            }
            catch ( Exception )
            {
                if ( gotRef )
                {
                    handle.DangerousRelease();
                    gotRef = false;
                }

                throw;
            }
            finally
            {
                if ( gotRef )
                {
                    status = CContextNativeMethods.EncryptMessage(
                        ref handle.rawHandle,
                        qualityOfProtection,
                        bufferAdapter.Handle,
                        sequenceNumber
                    );

                    handle.DangerousRelease();
                }
            }

            return status;
        }

        /// <summary>
        /// Safely invokes the native DecryptMessage function, making sure that handle ref counting is 
        /// performed in a proper CER.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="qualityOfProtection"></param>
        /// <param name="bufferAdapter"></param>
        /// <param name="sequenceNumber"></param>
        /// <returns></returns>
        internal static CSecurityStatus SafeDecryptMessage( 
            CSafeContextHandle handle, 
            int qualityOfProtection, 
            CSecureBufferAdapter bufferAdapter, 
            int sequenceNumber )
        {
            CSecurityStatus status = CSecurityStatus.InvalidHandle;
            bool gotRef = false;

            RuntimeHelpers.PrepareConstrainedRegions();
            try
            {
                handle.DangerousAddRef( ref gotRef );
            }
            catch( Exception )
            {
                if( gotRef )
                {
                    handle.DangerousRelease();
                    gotRef = false;
                }

                throw;
            }
            finally
            {
                if( gotRef )
                {
                    status = CContextNativeMethods.DecryptMessage(
                        ref handle.rawHandle,
                        bufferAdapter.Handle,
                        sequenceNumber,
                        qualityOfProtection
                    );

                    handle.DangerousRelease();
                }
            }

            return status;
        }

        /// <summary>
        /// Safely invokes the native MakeSignature function, making sure that handle ref counting is 
        /// performed in a proper CER.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="qualityOfProtection"></param>
        /// <param name="adapter"></param>
        /// <param name="sequenceNumber"></param>
        /// <returns></returns>
        internal static CSecurityStatus SafeMakeSignature(
            CSafeContextHandle handle,
            int qualityOfProtection,
            CSecureBufferAdapter adapter,
            int sequenceNumber )
        {
            bool gotRef = false;
            CSecurityStatus status = CSecurityStatus.InternalError;

            RuntimeHelpers.PrepareConstrainedRegions();
            try
            {
                handle.DangerousAddRef( ref gotRef );
            }
            catch ( Exception )
            {
                if ( gotRef )
                {
                    handle.DangerousRelease();
                    gotRef = false;
                }

                throw;
            }
            finally
            {
                if ( gotRef )
                {
                    status = CContextNativeMethods.MakeSignature(
                        ref handle.rawHandle,
                        qualityOfProtection,
                        adapter.Handle,
                        sequenceNumber
                    );

                    handle.DangerousRelease();
                }
            }

            return status;
        }

        /// <summary>
        /// Safely invokes the native VerifySignature function, making sure that handle ref counting is 
        /// performed in a proper CER.
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="qualityOfProtection"></param>
        /// <param name="adapter"></param>
        /// <param name="sequenceNumber"></param>
        /// <returns></returns>
        internal static CSecurityStatus SafeVerifySignature(
            CSafeContextHandle handle,
            int qualityOfProtection,
            CSecureBufferAdapter adapter,
            int sequenceNumber )
        {
            bool gotRef = false;
            CSecurityStatus status = CSecurityStatus.InternalError;

            RuntimeHelpers.PrepareConstrainedRegions();
            try
            {
                handle.DangerousAddRef( ref gotRef );
            }
            catch ( Exception )
            {
                if ( gotRef )
                {
                    handle.DangerousRelease();
                    gotRef = false;
                }

                throw;
            }
            finally
            {
                if ( gotRef )
                {
                    status = CContextNativeMethods.VerifySignature(
                        ref handle.rawHandle,
                        adapter.Handle,
                        sequenceNumber,
                        qualityOfProtection
                    );

                    handle.DangerousRelease();
                }
            }

            return status;
        }
    }
}
