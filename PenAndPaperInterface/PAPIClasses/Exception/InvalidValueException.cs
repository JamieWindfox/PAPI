using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Exception
{
    public class InvalidValueException : PAPIException
    {
        public InvalidValueException(string msg) : base(msg)
        { }
    }

    

}
