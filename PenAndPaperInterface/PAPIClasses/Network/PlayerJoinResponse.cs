using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Network
{
    public class PlayerJoinResponse : PAPIResponse
    {
        public string addedPlayerName { get; set; }

        [JsonConstructor]
        public PlayerJoinResponse(string responseType, HttpStatusCode statusCode, string addedPlayerName)
        {
            this.responseType = this.GetType().ToString();
            base.statusCode = statusCode;
            this.addedPlayerName = addedPlayerName;
        }

    }
}
