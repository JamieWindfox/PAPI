
using PAPI.Logging;
using System.Text.Json.Serialization;

namespace PAPI.Settings
{
    public class Player
    {
        public string _name { get; private set; }
        public string _ip { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON CTOR must contain all traits of the player
        /// </summary>
        /// <param name="name">if null or empty, the name ist set to "NOT_VALID"</param>
        /// <param name="ip">if null or empty, is is set to the local ip</param>
        [JsonConstructor]
        public Player(string _name, string _ip)
        {
            this._name = (_name == null || _name == "") ? "NOT_VALID" : _name;
            this._ip = (_ip == null || _ip == "") ? Settings.Game.PAPIApplication.GetLocalIP() : _ip;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Player " + _name);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a new default player
        /// </summary>
        public Player() : this(null, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new default Player");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given player
        /// </summary>
        /// <param name="other">if null, a default player is created</param>
        public Player(Player other) : this()
        {
            if (other == null) return;

            _name = other._name;
            _ip = other._ip;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Player as copy");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Set the name of the player to the given value
        /// </summary>
        /// <param name="name">if null, the name is set to an invalid value</param>
        public void SetName(string name)
        {
            _name = (name == null || name == "") ? "INVALID_NAME" : name;
            WfLogger.Log(this, LogLevel.DEBUG, "Set Player name to " + _name);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Sets the ip to the given value
        /// </summary>
        /// <param name="ip">if null or empty, the ip is net to an invalid one</param>
        public void SetIp(string ip)
        {
            _ip = (ip == null || ip == "") ? "INVALID_IP" : ip;
            WfLogger.Log(this, LogLevel.DEBUG, "Set Player IP to " + _ip);
        }
    }
}