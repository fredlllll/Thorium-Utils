using System;
using System.Collections.Generic;
using System.Text;

namespace Thorium.Utils
{
    public class RollingOverUInt
    {
        readonly object nextLock = new object();

        uint current = 0;
        public uint Next
        {
            get
            {
                uint retval;
                lock(nextLock)
                {
                    retval = current;
                    if(current == uint.MaxValue)
                    {
                        current = uint.MinValue;
                    }
                    else
                    {
                        current++;
                    }
                }
                return retval;
            }
        }
    }
}
