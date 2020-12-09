using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Network
{
    public abstract class PAPIResponse
    {
        public string responseType { get; set; }
        public HttpStatusCode statusCode { get; set; }

        
    }
}
