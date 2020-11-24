using System;

namespace PAPI.Exception
{
    [Serializable]
    public class OutOfRangeException : PAPIException
    {
        public OutOfRangeException(string message) : base(message)
        {
        }

    }
}