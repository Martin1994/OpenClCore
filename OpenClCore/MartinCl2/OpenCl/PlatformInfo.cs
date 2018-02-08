using System;
using System.Collections.Generic;
using System.Text;

namespace MartinCl2.OpenCl
{
    public enum PlatformInfo : uint
    {
        PLATFORM_PROFILE                       = 0x0900,
        PLATFORM_VERSION                       = 0x0901,
        PLATFORM_NAME                          = 0x0902,
        PLATFORM_VENDOR                        = 0x0903,
        PLATFORM_EXTENSIONS                    = 0x0904,
        PLATFORM_HOST_TIMER_RESOLUTION         = 0x0905
    }
}
