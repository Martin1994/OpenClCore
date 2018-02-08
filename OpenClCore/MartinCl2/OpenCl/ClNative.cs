using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MartinCl2.OpenCl
{
    public class ClNative
    {
        public const String OPEN_CL_LIB = "OpenCl";

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clGetPlatformIDs(uint num_entries, [Out] IntPtr[] platforms, out uint num_platforms);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clGetPlatformInfo(IntPtr platform, PlatformInfo param_name, ulong param_value_size, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1), Out] char[] param_value, out ulong param_value_size_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clGetDeviceIDs(IntPtr platform, DeviceType device_type, uint num_entries, [Out] IntPtr[] devices, out uint num_devices);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clGetDeviceInfo(IntPtr device, DeviceInfo param_name, ulong param_value_size, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1), Out] char[] param_value, out ulong param_value_size_ret);

        public delegate void ContextNotify([MarshalAs(UnmanagedType.LPStr)]String errinfo, IntPtr private_info, int cb, IntPtr user_data);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr clCreateContext([In] int[] properties, uint num_devices, [In] IntPtr[] devices, ContextNotify pfn_notify, IntPtr user_data, out ErrorCode errcode_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clReleaseContext(IntPtr context);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr clCreateBuffer(IntPtr context, MemFlags flags, ulong size, IntPtr host_ptr, out ErrorCode errcode_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr clCreateBuffer(IntPtr context, MemFlags flags, ulong size, long[] host_ptr, out ErrorCode errcode_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr clCreateBuffer(IntPtr context, MemFlags flags, ulong size, int[] host_ptr, out ErrorCode errcode_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr clCreateBuffer(IntPtr context, MemFlags flags, ulong size, byte[] host_ptr, out ErrorCode errcode_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr clCreateBuffer(IntPtr context, MemFlags flags, ulong size, float[] host_ptr, out ErrorCode errcode_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr clCreateBuffer(IntPtr context, MemFlags flags, ulong size, double[] host_ptr, out ErrorCode errcode_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clReleaseMemObject(IntPtr memobj);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr clCreateProgramWithSource(IntPtr context, uint count, [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] String[] strings, [In] ulong[] lengths, out ErrorCode errcode_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clCreateProgramWithSource(IntPtr context, uint count, [In, MarshalAs(UnmanagedType.LPArray)] byte[][] strings, [In] ulong[] lengths, out ErrorCode errcode_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clReleaseProgram(IntPtr program);

        public delegate void ProgramNotify(IntPtr program, IntPtr user_data);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clBuildProgram(IntPtr program, uint num_devices, [In] IntPtr[] device_list, [In, MarshalAs(UnmanagedType.LPStr)] String options, ProgramNotify pfn_notify, IntPtr user_data);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clGetProgramBuildInfo(IntPtr program, IntPtr device, ProgramBuildInfo param_name, ulong param_value_size, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1), Out] char[] param_value, out ulong param_value_size_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr clCreateCommandQueue(IntPtr context, IntPtr device, CommandQueueProperty properties, out ErrorCode errcode_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clReleaseCommandQueue(IntPtr command_queue);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr clCreateKernel(IntPtr program, [In, MarshalAs(UnmanagedType.LPStr)] String kernel_name, out ErrorCode errcode_ret);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clReleaseKernel(IntPtr kernel);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clSetKernelArg(IntPtr kernel, uint arg_index, ulong arg_size, ref IntPtr arg_value);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clEnqueueTask(IntPtr command_queue, IntPtr kernel, uint num_events_in_wait_list, IntPtr event_wait_list, IntPtr _event);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clEnqueueNDRangeKernel(IntPtr command_queue, IntPtr kernel, uint work_dim, ulong[] global_work_offset, ulong[] global_work_size, ulong[] local_work_size, uint num_events_in_wait_list, IntPtr[] event_wait_list, IntPtr _event);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clEnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_read, ulong offset, ulong size, [Out] long[] ptr, uint num_events_in_wait_list, IntPtr event_wait_list, IntPtr _event);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clEnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_read, ulong offset, ulong size, [Out] int[] ptr, uint num_events_in_wait_list, IntPtr event_wait_list, IntPtr _event);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clEnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_read, ulong offset, ulong size, [Out] byte[] ptr, uint num_events_in_wait_list, IntPtr event_wait_list, IntPtr _event);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clEnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_read, ulong offset, ulong size, [Out] float[] ptr, uint num_events_in_wait_list, IntPtr event_wait_list, IntPtr _event);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clEnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_read, ulong offset, ulong size, [Out] double[] ptr, uint num_events_in_wait_list, IntPtr event_wait_list, IntPtr _event);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clEnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_write, ulong offset, ulong size, [In] long[] ptr, uint num_events_in_wait_list, IntPtr event_wait_list, IntPtr _event);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clEnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_write, ulong offset, ulong size, [In] int[] ptr, uint num_events_in_wait_list, IntPtr event_wait_list, IntPtr _event);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clEnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_write, ulong offset, ulong size, [In] byte[] ptr, uint num_events_in_wait_list, IntPtr event_wait_list, IntPtr _event);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clEnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_write, ulong offset, ulong size, [In] float[] ptr, uint num_events_in_wait_list, IntPtr event_wait_list, IntPtr _event);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clEnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_write, ulong offset, ulong size, [In] double[] ptr, uint num_events_in_wait_list, IntPtr event_wait_list, IntPtr _event);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clFlush(IntPtr command_queue);

        [DllImport(OPEN_CL_LIB, CallingConvention = CallingConvention.Cdecl)]
        public extern static ErrorCode clFinish(IntPtr command_queue);
    }
}
