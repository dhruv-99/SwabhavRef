﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcLib
{
    class OddNumberException : Exception
    {
        public OddNumberException(string message) : base(message)
        {

        }
    }
}
