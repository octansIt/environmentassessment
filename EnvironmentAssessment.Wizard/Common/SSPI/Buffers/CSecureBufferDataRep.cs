﻿namespace EnvironmentAssessment.Common.SSPI.Buffers
{
    /// <summary>
    /// Describes how a buffer's opaque internals should be stored, with regards to byte ordering.
    /// </summary>
    internal enum CSecureBufferDataRep : int
    {
        /// <summary>
        /// Buffers internals are to be stored in the machine native byte order, which will change depending on
        /// what machine generated the buffer.
        /// </summary>
        Native = 0x10,

        /// <summary>
        /// Buffers are stored in network byte ordering, that is, big endian format.
        /// </summary>
        Network = 0x00
    }
}