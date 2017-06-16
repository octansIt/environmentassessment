using System;
using System.Runtime.CompilerServices;

namespace EnvironmentAssessment.Common.SSPI.Credentials
{
    /// <summary>
    /// Acquires a handle to the credentials of the user associated with the current process.
    /// </summary>
    public class CCurrentCredential : CCredential
    {
        /// <summary>
        /// Initializes a new instance of the CurrentCredential class.
        /// </summary>
        /// <param name="securityPackage">The security package to acquire the credential handle
        /// from.</param>
        /// <param name="use">The manner in which the credentials will be used - Inbound typically
        /// represents servers, outbound typically represent clients.</param>
        public CCurrentCredential( string securityPackage, CCredentialUse use ) :
            base( securityPackage )
        {
            Init( use );
        }

        private void Init( CCredentialUse use )
        {
            string packageName;
            CTimeStamp rawExpiry = new CTimeStamp();
            CSecurityStatus status = CSecurityStatus.InternalError;

            // -- Package --
            // Copy off for the call, since this.SecurityPackage is a property.
            packageName = this.SecurityPackage;

            this.Handle = new CSafeCredentialHandle();

            // The finally clause is the actual constrained region. The VM pre-allocates any stack space,
            // performs any allocations it needs to prepare methods for execution, and postpones any 
            // instances of the 'uncatchable' exceptions (ThreadAbort, StackOverflow, OutOfMemory).
            RuntimeHelpers.PrepareConstrainedRegions();
            try { }
            finally
            {
                status = CCredentialNativeMethods.AcquireCredentialsHandle(
                   null,
                   packageName,
                   use,
                   IntPtr.Zero,
                   IntPtr.Zero,
                   IntPtr.Zero,
                   IntPtr.Zero,
                   ref this.Handle.rawHandle,
                   ref rawExpiry
               );
            }

            if ( status != CSecurityStatus.OK )
            {
                throw new CSSPIException( "Failed to call AcquireCredentialHandle", status );
            }

            this.Expiry = rawExpiry.ToDateTime();
        }

    }
}
