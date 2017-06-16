using System.Runtime.ConstrainedExecution;

namespace EnvironmentAssessment.Common.SSPI.Contexts
{
    /// <summary>
    /// Captures an unmanaged security context handle.
    /// </summary>
    public class CSafeContextHandle : CSafeSspiHandle
    {
        public CSafeContextHandle()
            : base()
        { }

        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success )]
        protected override bool ReleaseHandle()
        {
            CSecurityStatus status = CContextNativeMethods.DeleteSecurityContext(
                ref base.rawHandle
            );

            base.ReleaseHandle();

            return status == CSecurityStatus.OK;
        }
    }
}
