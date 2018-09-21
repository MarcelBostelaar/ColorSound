using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WaveLibrary.Writingformats
{
    class LittleEndianInt16 : IWrite
    {
        short value;
        public LittleEndianInt16(short value)
        {
            this.value = value;
        }

        public byte[] asWritten()
        {
            var converted = BitConverter.GetBytes(value);
            if (!BitConverter.IsLittleEndian)
            {
                converted = converted.Reverse().ToArray();
            }
            return converted;
        }

        public int WriteInto(byte[] array, int position)
        {
            var value = asWritten();
            Array.Copy(value, 0, array, position, 4);
            return position + 4;
        }
    }
}
