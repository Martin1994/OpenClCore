using System;
using System.Collections.Generic;
using System.Text;

namespace MartinCl2.OpenCl
{
    public class OpenClException : Exception
    {
        public readonly ErrorCode ErrorCode;

        public OpenClException(ErrorCode error)
        {
            ErrorCode = error;
        }
    }
}
