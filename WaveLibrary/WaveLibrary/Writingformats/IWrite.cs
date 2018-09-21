using System;
using System.Collections.Generic;
using System.Text;

namespace WaveLibrary.Writingformats
{
    interface IWrite
    {
        /// <summary>
        /// Returns bytes as if it were written
        /// </summary>
        /// <returns>Bytes as if it were written</returns>
        byte[] asWritten();

        /// <summary>
        /// Writes data and returns new position
        /// </summary>
        /// <param name="array">Array to write to</param>
        /// <param name="position">Position to write to</param>
        /// <returns>Position after writing</returns>
        int WriteInto(byte[] array, int position);
    }
}
