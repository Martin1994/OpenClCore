﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MartinCl2.OpenCl
{
    public enum ErrorCode : int
    {
        SUCCESS                                   =  0,
        DEVICE_NOT_FOUND                          = -1,
        DEVICE_NOT_AVAILABLE                      = -2,
        COMPILER_NOT_AVAILABLE                    = -3,
        MEM_OBJECT_ALLOCATION_FAILURE             = -4,
        OUT_OF_RESOURCES                          = -5,
        OUT_OF_HOST_MEMORY                        = -6,
        PROFILING_INFO_NOT_AVAILABLE              = -7,
        MEM_COPY_OVERLAP                          = -8,
        IMAGE_FORMAT_MISMATCH                     = -9,
        IMAGE_FORMAT_NOT_SUPPORTED                = -10,
        BUILD_PROGRAM_FAILURE                     = -11,
        MAP_FAILURE                               = -12,
        MISALIGNED_SUB_BUFFER_OFFSET              = -13,
        EXEC_STATUS_ERROR_FOR_EVENTS_IN_WAIT_LIST = -14,
        COMPILE_PROGRAM_FAILURE                   = -15,
        LINKER_NOT_AVAILABLE                      = -16,
        LINK_PROGRAM_FAILURE                      = -17,
        DEVICE_PARTITION_FAILED                   = -18,
        KERNEL_ARG_INFO_NOT_AVAILABLE             = -19,
        
        INVALID_VALUE                             = -30,
        INVALID_DEVICE_TYPE                       = -31,
        INVALID_PLATFORM                          = -32,
        INVALID_DEVICE                            = -33,
        INVALID_CONTEXT                           = -34,
        INVALID_QUEUE_PROPERTIES                  = -35,
        INVALID_COMMAND_QUEUE                     = -36,
        INVALID_HOST_PTR                          = -37,
        INVALID_MEM_OBJECT                        = -38,
        INVALID_IMAGE_FORMAT_DESCRIPTOR           = -39,
        INVALID_IMAGE_SIZE                        = -40,
        INVALID_SAMPLER                           = -41,
        INVALID_BINARY                            = -42,
        INVALID_BUILD_OPTIONS                     = -43,
        INVALID_PROGRAM                           = -44,
        INVALID_PROGRAM_EXECUTABLE                = -45,
        INVALID_KERNEL_NAME                       = -46,
        INVALID_KERNEL_DEFINITION                 = -47,
        INVALID_KERNEL                            = -48,
        INVALID_ARG_INDEX                         = -49,
        INVALID_ARG_VALUE                         = -50,
        INVALID_ARG_SIZE                          = -51,
        INVALID_KERNEL_ARGS                       = -52,
        INVALID_WORK_DIMENSION                    = -53,
        INVALID_WORK_GROUP_SIZE                   = -54,
        INVALID_WORK_ITEM_SIZE                    = -55,
        INVALID_GLOBAL_OFFSET                     = -56,
        INVALID_EVENT_WAIT_LIST                   = -57,
        INVALID_EVENT                             = -58,
        INVALID_OPERATION                         = -59,
        INVALID_GL_OBJECT                         = -60,
        INVALID_BUFFER_SIZE                       = -61,
        INVALID_MIP_LEVEL                         = -62,
        INVALID_GLOBAL_WORK_SIZE                  = -63,
        INVALID_PROPERTY                          = -64,
        INVALID_IMAGE_DESCRIPTOR                  = -65,
        INVALID_COMPILER_OPTIONS                  = -66,
        INVALID_LINKER_OPTIONS                    = -67,
        INVALID_DEVICE_PARTITION_COUNT            = -68,
        INVALID_PIPE_SIZE                         = -69,
        INVALID_DEVICE_QUEUE                      = -70
    }
}
