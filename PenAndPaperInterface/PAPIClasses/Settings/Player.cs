using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PAPI.Settings
{
    public class Player
    {
        public string name { get; private set; }


        [JsonConstructor]
        public Player(string name)
        {
            this.name = name;
        }

        public Player() 
            : this("NOT A VALID PLAYER NAME") { }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}