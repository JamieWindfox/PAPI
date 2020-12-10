using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using PAPI.Settings;
using System.Text.Json.Serialization;

namespace PAPI.Network
{
    public class PlayerJoinRequest : PAPIRequest
    {
        public Player playerToJoin { get; set; }

        [JsonConstructor]
        public PlayerJoinRequest(string requestType, Player playerToJoin)
        {
            this.requestType = requestType;
            this.playerToJoin = playerToJoin;
        }
    }
}
