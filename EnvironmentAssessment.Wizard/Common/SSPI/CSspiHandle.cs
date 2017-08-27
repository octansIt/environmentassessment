﻿using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace EnvironmentAssessment.Common.Sspi
{
    /// <summary>
    /// Represents the raw structure for any handle created for the SSPI API, for example, credential 
    /// handles, context handles, and security package handles. Any SSPI handle is always the size 
    /// of two native pointers. 
    /// </summary>
    /// <remarks>
    /// The documentation for SSPI handles can be found here:
    /// http://msdn.microsoft.com/en-us/library/windows/desktop/aa380495(v=vs.85).aspx
    /// 
    /// This class is not reference safe - if used directly, or referenced directly, it may be leaked,
    /// or subject to finalizer races, or any of the hundred of things SafeHandles were designed to fix.
    /// Do not directly use this class - use only though SafeHandle wrapper objects. Any reference needed
    /// to this handle for performing work (InitializeSecurityContext, eg) should be performed a CER
    /// that employs handle reference counting across the native API invocation.
    /// </remarks>
    [StructLayout( LayoutKind.Sequential, Pack = 1 ) ]
    internal struct CRawSspiHandle
    {
        private IntPtr lowPart;
        private IntPtr highPart;

        /// <summary>
        /// Returns whether or not the handle is set to the default, empty value.
        /// </summary>
        /// <returns></returns>
        public bool IsZero()
        {
            return this.lowPart == IntPtr.Zero && this.highPart == IntPtr.Zero;
        }

        /// <summary>
        /// Sets the handle to an invalid value.
        /// </summary>
        /// <remarks>
        /// This method is executed in a CER during handle release.
        /// </remarks>
        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success)]
        public void SetInvalid()
        {
            this.lowPart = IntPtr.Zero;
            this.highPart = IntPtr.Zero;
        }
    }

    /// <summary>
    /// Safely encapsulates a raw handle used in the SSPI api.
    /// </summary>
    public abstract class CSafeSspiHandle : SafeHandle
    {
        internal CRawSspiHandle rawHandle;

        protected CSafeSspiHandle()
            : base( IntPtr.Zero, true )
        {
            this.rawHandle = new CRawSspiHandle();
        }

        public override bool IsInvalid
        {
            get { return IsClosed || this.rawHandle.IsZero();  }
        }

        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success )]
        protected override bool ReleaseHandle()
        {
            this.rawHandle.SetInvalid();
            return true;
        }
    }
}
