using System;
using System.Collections.Generic;
using System.Text;

namespace MartinCl2.OpenCl
{
    public enum CommandQueueProperty : ulong
    {
        QUEUE_NONE                                = 0,
        QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE       = (1 << 0),
        QUEUE_PROFILING_ENABLE                    = (1 << 1),
        QUEUE_ON_DEVICE                           = (1 << 2),
        QUEUE_ON_DEVICE_DEFAULT                   = (1 << 3)
    }
}
