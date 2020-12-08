using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Exception
{
    public class NetworkException : PAPIException
    {
        public NetworkException(string msg) : base(msg) { }
    }
}
