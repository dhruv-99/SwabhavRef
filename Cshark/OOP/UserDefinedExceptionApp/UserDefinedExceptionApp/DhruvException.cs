using System;
using System.Collections.Generic;
using System.Text;

namespace UserDefinedExceptionApp
{
    class DhruvException : Exception
    {
        public DhruvException(string message) : base(message)
        {

        }
    }
}
