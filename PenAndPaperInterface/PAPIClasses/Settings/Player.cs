using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PAPI.Settings
{
    public class Player
    {
        public string _name { get; private set; }
        public string ip { get; private set; }

        // Attribute needed to send Players through the NET API
        [JsonConstructor]
        public Player(string name, string ip)
        {
            this._name = name;
            this.ip = ip;
        }


        public Player() 
            : this("NOT A VALID PLAYER NAME", "0.0.0.0:0") { }

        public void SetName(string name)
        {
            this._name = name;
        }
        public void SetIp(string ip)
        {
            this.ip = ip;
        }
    }
}