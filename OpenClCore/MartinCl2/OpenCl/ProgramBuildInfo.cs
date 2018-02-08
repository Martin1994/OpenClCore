using System;
using System.Collections.Generic;
using System.Text;

namespace MartinCl2.OpenCl
{
    public enum ProgramBuildInfo : uint
    {
        PROGRAM_BUILD_STATUS                      = 0x1181,
        PROGRAM_BUILD_OPTIONS                     = 0x1182,
        PROGRAM_BUILD_LOG                         = 0x1183,
        PROGRAM_BINARY_TYPE                       = 0x1184,
        PROGRAM_BUILD_GLOBAL_VARIABLE_TOTAL_SIZE  = 0x1185
    }
}
