using System.Runtime.ConstrainedExecution;

namespace EnvironmentAssessment.Common.Sspi.Credentials
{
    /// <summary>
    /// Provides a managed handle to an SSPI credential.
    /// </summary>
    public class CSafeCredentialHandle : CSafeSspiHandle
    {
        public CSafeCredentialHandle()
            : base()
        { }

        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success )]
        protected override bool ReleaseHandle()
        {
            CSecurityStatus status = CCredentialNativeMethods.FreeCredentialsHandle(
                ref base.rawHandle
            );

            base.ReleaseHandle();

            return status == CSecurityStatus.OK;
        }
    }

}
