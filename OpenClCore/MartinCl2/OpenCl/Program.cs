using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MartinCl2.OpenCl
{
    public class Program
    {
        public delegate void ProgramNotify(Program program);

        public readonly IntPtr Pointer;

        public Program(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public void Build(Device[] devices, String options = null, ProgramNotify notify = null)
        {
            ClNative.ProgramNotify nativeNotify = null;
            if (notify != null)
            {
                nativeNotify = (IntPtr program, IntPtr userData) => notify(this);
            }
            ErrorCode error = ClNative.clBuildProgram(Pointer, (uint)devices.Length, devices.Select(d => d.Pointer).ToArray(), options, nativeNotify, IntPtr.Zero);
            Cl.CheckError(error);
        }

        public String GetBuildLog(Device device)
        {
            ErrorCode error;
            error = ClNative.clGetProgramBuildInfo(Pointer, device.Pointer, ProgramBuildInfo.PROGRAM_BUILD_LOG, 0, null, out ulong infoLength);
            Cl.CheckError(error);
            if (infoLength == 0)
            {
                return "";
            }
            char[] infoChar = new char[infoLength];
            error = ClNative.clGetProgramBuildInfo(Pointer, device.Pointer, ProgramBuildInfo.PROGRAM_BUILD_LOG, infoLength, infoChar, out infoLength);
            Cl.CheckError(error);
            return new String(infoChar, 0, (int)infoLength - 1);
        }

        ~Program()
        {
            ClNative.clReleaseProgram(Pointer);
        }
    }
}
