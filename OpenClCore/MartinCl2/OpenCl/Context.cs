using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MartinCl2.OpenCl
{
    public class Context
    {
        public readonly IntPtr Pointer;

        public Context(IntPtr pointer)
        {
            Pointer = pointer;
        }

        ~Context()
        {
            ClNative.clReleaseContext(Pointer);
        }
    }
}
