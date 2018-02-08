using System;
using System.Collections.Generic;
using System.Text;

namespace MartinCl2.OpenCl
{
    public class CommandQueue
    {
        public readonly IntPtr Pointer;

        public CommandQueue(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public void EnqueueNDRangeKernel(Kernel kernel, ulong[] globalWorkOffset, ulong[] globalWorkSize, ulong[] localWorkSize)
        {
            if (globalWorkSize == null)
            {
                throw new ArgumentNullException("globalWorkSize");
            }
            if (globalWorkOffset != null && globalWorkOffset.Length != globalWorkSize.Length)
            {
                throw new ArgumentException("Work sizes and offset must have the same length.");
            }
            if (localWorkSize != null && localWorkSize.Length != globalWorkSize.Length)
            {
                throw new ArgumentException("Work sizes and offset must have the same length.");
            }
            ErrorCode error = ClNative.clEnqueueNDRangeKernel(Pointer, kernel.Pointer, (uint)globalWorkSize.Length, globalWorkOffset, globalWorkSize, localWorkSize, 0, null, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueWriteBuffer(Buffer buffer, ArraySegment<byte> data)
        {
            ErrorCode error = ClNative.clEnqueueWriteBuffer(Pointer, buffer.Pointer, true, (ulong)data.Offset * sizeof(byte), (ulong)data.Count * sizeof(byte), data.Array, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueWriteBuffer(Buffer buffer, byte[] data)
        {
            ErrorCode error = ClNative.clEnqueueWriteBuffer(Pointer, buffer.Pointer, true, 0, (ulong)data.LongLength * sizeof(byte), data, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueWriteBuffer(Buffer buffer, ArraySegment<int> data)
        {
            ErrorCode error = ClNative.clEnqueueWriteBuffer(Pointer, buffer.Pointer, true, (ulong)data.Offset * sizeof(int), (ulong)data.Count * sizeof(int), data.Array, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueWriteBuffer(Buffer buffer, int[] data)
        {
            ErrorCode error = ClNative.clEnqueueWriteBuffer(Pointer, buffer.Pointer, true, 0, (ulong)data.LongLength * sizeof(int), data, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueWriteBuffer(Buffer buffer, ArraySegment<long> data)
        {
            ErrorCode error = ClNative.clEnqueueWriteBuffer(Pointer, buffer.Pointer, true, (ulong)data.Offset * sizeof(long), (ulong)data.Count * sizeof(long), data.Array, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueWriteBuffer(Buffer buffer, long[] data)
        {
            ErrorCode error = ClNative.clEnqueueWriteBuffer(Pointer, buffer.Pointer, true, 0, (ulong)data.LongLength * sizeof(long), data, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueWriteBuffer(Buffer buffer, ArraySegment<float> data)
        {
            ErrorCode error = ClNative.clEnqueueWriteBuffer(Pointer, buffer.Pointer, true, (ulong)data.Offset * sizeof(float), (ulong)data.Count * sizeof(float), data.Array, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueWriteBuffer(Buffer buffer, float[] data)
        {
            ErrorCode error = ClNative.clEnqueueWriteBuffer(Pointer, buffer.Pointer, true, 0, (ulong)data.LongLength * sizeof(float), data, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueWriteBuffer(Buffer buffer, ArraySegment<double> data)
        {
            ErrorCode error = ClNative.clEnqueueWriteBuffer(Pointer, buffer.Pointer, true, (ulong)data.Offset * sizeof(double), (ulong)data.Count * sizeof(double), data.Array, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueWriteBuffer(Buffer buffer, double[] data)
        {
            ErrorCode error = ClNative.clEnqueueWriteBuffer(Pointer, buffer.Pointer, true, 0, (ulong)data.LongLength * sizeof(double), data, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueReadBuffer(Buffer buffer, ArraySegment<byte> data)
        {
            ErrorCode error = ClNative.clEnqueueReadBuffer(Pointer, buffer.Pointer, true, (ulong)data.Offset * sizeof(byte), (ulong)data.Count * sizeof(byte), data.Array, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueReadBuffer(Buffer buffer, byte[] data)
        {
            ErrorCode error = ClNative.clEnqueueReadBuffer(Pointer, buffer.Pointer, true, 0, (ulong)data.LongLength * sizeof(byte), data, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueReadBuffer(Buffer buffer, ArraySegment<int> data)
        {
            ErrorCode error = ClNative.clEnqueueReadBuffer(Pointer, buffer.Pointer, true, (ulong)data.Offset * sizeof(int), (ulong)data.Count * sizeof(int), data.Array, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueReadBuffer(Buffer buffer, int[] data)
        {
            ErrorCode error = ClNative.clEnqueueReadBuffer(Pointer, buffer.Pointer, true, 0, (ulong)data.LongLength * sizeof(int), data, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueReadBuffer(Buffer buffer, ArraySegment<long> data)
        {
            ErrorCode error = ClNative.clEnqueueReadBuffer(Pointer, buffer.Pointer, true, (ulong)data.Offset * sizeof(long), (ulong)data.Count * sizeof(long), data.Array, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueReadBuffer(Buffer buffer, long[] data)
        {
            ErrorCode error = ClNative.clEnqueueReadBuffer(Pointer, buffer.Pointer, true, 0, (ulong)data.LongLength * sizeof(long), data, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueReadBuffer(Buffer buffer, ArraySegment<float> data)
        {
            ErrorCode error = ClNative.clEnqueueReadBuffer(Pointer, buffer.Pointer, true, (ulong)data.Offset * sizeof(float), (ulong)data.Count * sizeof(float), data.Array, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueReadBuffer(Buffer buffer, float[] data)
        {
            ErrorCode error = ClNative.clEnqueueReadBuffer(Pointer, buffer.Pointer, true, 0, (ulong)data.LongLength * sizeof(float), data, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueReadBuffer(Buffer buffer, ArraySegment<double> data)
        {
            ErrorCode error = ClNative.clEnqueueReadBuffer(Pointer, buffer.Pointer, true, (ulong)data.Offset * sizeof(double), (ulong)data.Count * sizeof(double), data.Array, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void EnqueueReadBuffer(Buffer buffer, double[] data)
        {
            ErrorCode error = ClNative.clEnqueueReadBuffer(Pointer, buffer.Pointer, true, 0, (ulong)data.LongLength * sizeof(double), data, 0, IntPtr.Zero, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public void Flush()
        {
            ClNative.clFlush(Pointer);
        }

        public void Finish()
        {
            ClNative.clFinish(Pointer);
        }

        ~CommandQueue()
        {
            Flush();
            Finish();
            ClNative.clReleaseCommandQueue(Pointer);
        }
    }
}
