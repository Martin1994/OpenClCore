using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MartinCl2.OpenCl
{
    public class Kernel
    {
        public readonly IntPtr Pointer;

        public Kernel(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public void SetArgument(uint index, Buffer buffer)
        {
            IntPtr bufferPtr = buffer.Pointer;
            ErrorCode error = ClNative.clSetKernelArg(Pointer, index, (ulong)Marshal.SizeOf<IntPtr>(), ref bufferPtr);
            Cl.CheckError(error);
        }

        ~Kernel()
        {
            ClNative.clReleaseKernel(Pointer);
        }
    }
}
