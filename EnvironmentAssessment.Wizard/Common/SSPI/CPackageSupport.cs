using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EnvironmentAssessment.Common.SSPI
{
    /// <summary>
    /// Queries information about security packages.
    /// </summary>
    public static class CPackageSupport
    {
        /// <summary>
        /// Returns the properties of the named package.
        /// </summary>
        /// <param name="packageName">The name of the package.</param>
        /// <returns></returns>
        public static CSecPkgInfo GetPackageCapabilities( string packageName )
        {
            CSecPkgInfo info;
            CSecurityStatus status = CSecurityStatus.InternalError;

            IntPtr rawInfoPtr;
            
            rawInfoPtr = new IntPtr();
            info = new CSecPkgInfo();

            RuntimeHelpers.PrepareConstrainedRegions();
            try
            { }
            finally
            {
                status = CNativeMethods.QuerySecurityPackageInfo( packageName, ref rawInfoPtr );

                if ( rawInfoPtr != IntPtr.Zero )
                {
                    try
                    {
                        if ( status == CSecurityStatus.OK )
                        {
                            // This performs allocations as it makes room for the strings contained in the SecPkgInfo class.
                            Marshal.PtrToStructure( rawInfoPtr, info );
                        }
                    }
                    finally
                    {
                        CNativeMethods.FreeContextBuffer( rawInfoPtr );
                    }
                }
            }

            if( status != CSecurityStatus.OK )
            {
                throw new CSSPIException( "Failed to query security package provider details", status );
            }

            return info;
        }

        /// <summary>
        /// Returns a list of all known security package providers and their properties.
        /// </summary>
        /// <returns></returns>
        public static CSecPkgInfo[] EnumeratePackages()
        {
            CSecurityStatus status = CSecurityStatus.InternalError;
            CSecPkgInfo[] packages = null;
            IntPtr pkgArrayPtr;
            IntPtr pkgPtr;
            int numPackages = 0;
            int pkgSize = Marshal.SizeOf( typeof(CSecPkgInfo) );

            pkgArrayPtr = new IntPtr();

            RuntimeHelpers.PrepareConstrainedRegions();
            try { }
            finally
            {
                status = CNativeMethods.EnumerateSecurityPackages( ref numPackages, ref pkgArrayPtr );

                if( pkgArrayPtr != IntPtr.Zero )
                {
                    try
                    {
                        if( status == CSecurityStatus.OK )
                        {
                            // Bwooop Bwooop Alocation Alert
                            // 1) We allocate the array
                            // 2) We allocate the individual elements in the array (they're class objects).
                            // 3) We allocate the strings in the individual elements in the array when we 
                            //    call Marshal.PtrToStructure()

                            packages = new CSecPkgInfo[numPackages];

                            for( int i = 0; i < numPackages; i++ )
                            {
                                packages[i] = new CSecPkgInfo();
                            }
                            
                            for( int i = 0; i < numPackages; i++ )
                            {
                                pkgPtr = IntPtr.Add( pkgArrayPtr, i * pkgSize );

                                Marshal.PtrToStructure( pkgPtr, packages[i] );
                            }
                        }
                    }
                    finally
                    {
                        CNativeMethods.FreeContextBuffer( pkgArrayPtr );
                    }
                }
            }

            if( status != CSecurityStatus.OK )
            {
                throw new CSSPIException( "Failed to enumerate security package providers", status );
            }

            return packages;
        }
    }
}
