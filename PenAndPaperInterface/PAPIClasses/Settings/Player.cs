
using PAPI.Logging;
using PAPI.Settings.Game;
using System;
using System.Text.Json.Serialization;

namespace PAPI.Settings
{
    public class Player
    {
        public string _name { get; private set; }
        public string _id { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON CTOR must contain all traits of the player
        /// </summary>
        /// <param name="_name">if null or empty, the name ist set to "NOT_VALID"</param>
        /// <param name="_id">if null or empty, is is set to a new uniqie id</param>
        [JsonConstructor]
        public Player(string _name, string _id)
        {
            this._name = (_name == null || _name == "") ? "NOT_VALID_FROM_CTOR" : _name;
            this._id = (_id == null || _id == "") ? PAPIApplication.GetUniqueId() : _id;

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
            _id = other._id;

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
    }
}