using System;
using System.Collections.Generic;
using System.Text;

namespace MartinCl2.OpenCl
{
    public enum DeviceType : ulong
    {
        DEVICE_TYPE_DEFAULT                       = (1 << 0),
        DEVICE_TYPE_CPU                           = (1 << 1),
        DEVICE_TYPE_GPU                           = (1 << 2),
        DEVICE_TYPE_ACCELERATOR                   = (1 << 3),
        DEVICE_TYPE_CUSTOM                        = (1 << 4),
        DEVICE_TYPE_ALL                           = 0xFFFFFFFF
    }
}
