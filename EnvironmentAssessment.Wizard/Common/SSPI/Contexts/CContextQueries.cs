using System;
using System.Runtime.InteropServices;

namespace EnvironmentAssessment.Common.Sspi.Contexts
{
    /// <summary>
    /// Stores the result of a context query for the context's buffer sizes.
    /// </summary>
    [StructLayout( LayoutKind.Sequential )]
    internal struct CSecPkgContext_Sizes
    {
        public int MaxToken;
        public int MaxSignature;
        public int BlockSize;
        public int SecurityTrailer;
    }

    /// <summary>
    /// Stores the result of a context query for a string-valued context attribute.
    /// </summary>
    [StructLayout( LayoutKind.Sequential )]
    internal struct CSecPkgContext_String
    {
        public IntPtr StringResult;
    }
}
