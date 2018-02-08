using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace MartinCl2.OpenCl
{
    public static class Cl
    {
        public static Platform[] GetPlatformIDs()
        {
            ErrorCode error;
            error = ClNative.clGetPlatformIDs(0, null, out uint length);
            CheckError(error);
            IntPtr[] platforms = new IntPtr[length];
            error = ClNative.clGetPlatformIDs(length, platforms, out length);
            CheckError(error);
            return platforms.Select(p => new Platform(p)).ToArray();
        }

        public static Device[] GetDeviceIDs(Platform platform, DeviceType deviceType)
        {
            ErrorCode error;
            error = ClNative.clGetDeviceIDs(platform.Pointer, deviceType, 0, null, out uint length);
            IntPtr[] devices = new IntPtr[length];
            error = ClNative.clGetDeviceIDs(platform.Pointer, deviceType, length, devices, out length);
            Cl.CheckError(error);
            return devices.Select(p => new Device(p)).ToArray();
        }

        public delegate void ContextCallback(String message, byte[] privateData, Context context);
        public static Context CreateContext(Platform platform, IList<Device> devices, ContextCallback notify = null)
        {
            if (platform != null)
            {
                throw new NotImplementedException();
            }
            
            if (devices == null)
            {
                throw new ArgumentNullException("devices");
            }

            Context context = null;
            ClNative.ContextNotify pfnNotify = null;
            if (notify != null)
            {
                pfnNotify = (String errInfo, IntPtr privateInfo, int cb, IntPtr userData) =>
                {
                    byte[] privateBytes = new byte[cb];
                    Marshal.Copy(privateInfo, privateBytes, 0, cb);
                    notify(errInfo, privateBytes, context);
                };
            }
            IntPtr contextID = ClNative.clCreateContext(
                null,
                (uint)devices.Count,
                devices.Select(d => d.Pointer).ToArray(),
                pfnNotify,
                IntPtr.Zero,
                out ErrorCode error);
            CheckError(error);

            context = new Context(contextID);
            return context;
        }

        public static Buffer CreateBuffer(Context context, MemFlags flags, byte[] hostData)
        {
            if (hostData == null)
            {
                throw new ArgumentNullException("hostData");
            }
            IntPtr buffer = ClNative.clCreateBuffer(context.Pointer, flags, sizeof(byte) * (ulong)hostData.Length, hostData, out ErrorCode error);
            CheckError(error);
            return new Buffer(buffer);
        }

        public static Buffer CreateBuffer(Context context, MemFlags flags, int[] hostData)
        {
            if (hostData == null)
            {
                throw new ArgumentNullException("hostData");
            }
            IntPtr buffer = ClNative.clCreateBuffer(context.Pointer, flags, sizeof(int) * (ulong)hostData.Length, hostData, out ErrorCode error);
            CheckError(error);
            return new Buffer(buffer);
        }

        public static Buffer CreateBuffer(Context context, MemFlags flags, long[] hostData)
        {
            if (hostData == null)
            {
                throw new ArgumentNullException("hostData");
            }
            IntPtr buffer = ClNative.clCreateBuffer(context.Pointer, flags, sizeof(long) * (ulong)hostData.Length, hostData, out ErrorCode error);
            CheckError(error);
            return new Buffer(buffer);
        }

        public static Buffer CreateBuffer(Context context, MemFlags flags, float[] hostData)
        {
            if (hostData == null)
            {
                throw new ArgumentNullException("hostData");
            }
            IntPtr buffer = ClNative.clCreateBuffer(context.Pointer, flags, sizeof(float) * (ulong)hostData.Length, hostData, out ErrorCode error);
            CheckError(error);
            return new Buffer(buffer);
        }

        public static Buffer CreateBuffer(Context context, MemFlags flags, double[] hostData)
        {
            if (hostData == null)
            {
                throw new ArgumentNullException("hostData");
            }
            IntPtr buffer = ClNative.clCreateBuffer(context.Pointer, flags, sizeof(double) * (ulong)hostData.Length, hostData, out ErrorCode error);
            CheckError(error);
            return new Buffer(buffer);
        }

        public static Buffer CreateBuffer(Context context, MemFlags flags, ulong size)
        {
            IntPtr buffer = ClNative.clCreateBuffer(context.Pointer, flags, size, IntPtr.Zero, out ErrorCode error);
            CheckError(error);
            return new Buffer(buffer);
        }

        public static Program CreateProgramWithSource(Context context, String[] sources)
        {
            IntPtr program = ClNative.clCreateProgramWithSource(context.Pointer, (uint)sources.Length, sources, sources.Select(s => (ulong)s.Length + 1).ToArray(), out ErrorCode error);
            CheckError(error);
            return new Program(program);
        }

        public static Kernel CreateKernel(Program program, String entry)
        {
            IntPtr kernel = ClNative.clCreateKernel(program.Pointer, entry, out ErrorCode error);
            CheckError(error);
            return new Kernel(kernel);
        }

        public static CommandQueue CreateCommandQueue(Context context, Device device, CommandQueueProperty properties)
        {
            IntPtr queue = ClNative.clCreateCommandQueue(context.Pointer, device.Pointer, properties, out ErrorCode error);
            CheckError(error);
            return new CommandQueue(queue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CheckError(ErrorCode error)
        {
            if (error == ErrorCode.SUCCESS)
            {
                return;
            }
            
            throw new OpenClException(error);
        }
    }
}
