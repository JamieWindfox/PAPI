using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Exception
{
    public class GameNotFoundException : PAPIException
    {
        public GameNotFoundException(string msg) : base(msg)
        { }
    }
}
