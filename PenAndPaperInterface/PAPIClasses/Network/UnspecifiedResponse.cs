using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Net;

namespace PAPI.Network
{
    public class UnspecifiedResponse : PAPIResponse
    {

        [JsonConstructor]
        public UnspecifiedResponse()
        {
            responseType = this.GetType().ToString();
            statusCode = HttpStatusCode.BadRequest;
        }
    }
}
