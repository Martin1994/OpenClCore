using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MartinCl2.OpenCl
{
    public class Platform
    {
        public readonly IntPtr Pointer;

        private readonly Lazy<String> name;
        public String Name { get { return name.Value; } }

        public Platform(IntPtr pointer)
        {
            Pointer = pointer;
            name = new Lazy<string>(GetName);
        }

        private String GetName()
        {
            ErrorCode error;
            error = ClNative.clGetPlatformInfo(Pointer, PlatformInfo.PLATFORM_NAME, 0, null, out ulong infoLength);
            Cl.CheckError(error);
            char[] infoChar = new char[infoLength];
            error = ClNative.clGetPlatformInfo(Pointer, PlatformInfo.PLATFORM_NAME, infoLength, infoChar, out infoLength);
            Cl.CheckError(error);
            return new String(infoChar, 0, (int)infoLength - 1);
        }
    }
}
