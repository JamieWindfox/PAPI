using PAPIClasses;
using System;
using System.Runtime.Serialization;

namespace PAPI.Exception
{
    [Serializable]
    public class EnumNotFoundException : PAPIException
    {
        public EnumNotFoundException(string message) : base(message)
        {
        }

    }
}