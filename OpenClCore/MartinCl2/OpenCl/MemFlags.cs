using System;
using System.Collections.Generic;
using System.Text;

namespace MartinCl2.OpenCl
{
    public enum MemFlags : ulong
    {
        MEM_READ_WRITE                            = (1 << 0),
        MEM_WRITE_ONLY                            = (1 << 1),
        MEM_READ_ONLY                             = (1 << 2),
        MEM_USE_HOST_PTR                          = (1 << 3),
        MEM_ALLOC_HOST_PTR                        = (1 << 4),
        MEM_COPY_HOST_PTR                         = (1 << 5),
        // reserved                                 (1 << 6),
        MEM_HOST_WRITE_ONLY                       = (1 << 7),
        MEM_HOST_READ_ONLY                        = (1 << 8),
        MEM_HOST_NO_ACCESS                        = (1 << 9),
        MEM_SVM_FINE_GRAIN_BUFFER                 = (1 << 10),   /* used by cl_svm_mem_flags only */
        MEM_SVM_ATOMICS                           = (1 << 11),   /* used by cl_svm_mem_flags only */
        MEM_KERNEL_READ_AND_WRITE                 = (1 << 12)
    }
}
