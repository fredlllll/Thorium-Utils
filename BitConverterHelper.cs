using System;
using System.Collections.Generic;
using System.Text;

namespace Thorium.Utils
{
    public static class BitConverterHelper
    {
        public static byte[] GetBytesBigEndian(uint value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            if(BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            return bytes;
        }
    }
}
