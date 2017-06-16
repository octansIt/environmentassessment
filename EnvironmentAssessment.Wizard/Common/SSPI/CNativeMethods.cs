using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace EnvironmentAssessment.Common.SSPI
{
    internal static class CNativeMethods
    {
        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success)]
        [DllImport( "Secur32.dll", EntryPoint = "FreeContextBuffer", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus FreeContextBuffer( IntPtr buffer );


        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success )]
        [DllImport( "Secur32.dll", EntryPoint = "QuerySecurityPackageInfo", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus QuerySecurityPackageInfo( string packageName, ref IntPtr pkgInfo );

        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success )]
        [DllImport( "Secur32.dll", EntryPoint = "EnumerateSecurityPackages", CharSet = CharSet.Unicode )]
        internal static extern CSecurityStatus EnumerateSecurityPackages( ref int numPackages, ref IntPtr pkgInfoArry );

    }
}
