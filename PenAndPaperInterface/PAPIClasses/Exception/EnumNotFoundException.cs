using System;

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