using System;
using System.Collections.Generic;
using System.Text;

namespace MartinCl2.OpenCl
{
    public class Buffer
    {
        public readonly IntPtr Pointer;

        public Buffer(IntPtr pointer)
        {
            Pointer = pointer;
        }

        ~Buffer()
        {
            ClNative.clReleaseMemObject(Pointer);
        }
    }
}
