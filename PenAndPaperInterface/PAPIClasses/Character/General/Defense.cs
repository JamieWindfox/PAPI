using PAPI.DataTypes;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Character.General
{
    public class Defense
    {
        public uint _valueMelee { get; private set; }
        public Modification _modificationMelee { get; private set; }

        public uint _valueRanged { get; private set; }
        public Modification _modificationRanged { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The SON Constructr must contain all possible defense traits
        /// _modificationMelee/Ranged: if null, there is no modification on the values
        /// </summary>
        /// <param name="_valueMelee"></param>
        /// <param name="_modificationMelee"></param>
        /// <param name="_valueRanged"></param>
        /// <param name="_modificationRanged"></param>
        [JsonConstructor]
        public Defense(uint _valueMelee, Modification _modificationMelee, uint _valueRanged, Modification _modificationRanged)
        {
            this._valueMelee = _valueMelee;
            this._valueRanged = _valueRanged;
            this._modificationMelee = (_modificationMelee == null) ? new Modification(0, GameTimeIntervalEnum.NOT_VALID) : _modificationMelee;
            this._modificationRanged = (_modificationRanged == null) ? new Modification(0, GameTimeIntervalEnum.NOT_VALID) : _modificationRanged;
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Defense: melee = " + _valueMelee + ", ranged = " + _valueRanged);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates default defensem wehere all values are 0 and there are no modifications
        /// </summary>
        public Defense() : this(0, null, 0, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Defense from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given Defense
        /// </summary>
        /// <param name="other">if null, a default Defense is created</param>
        public Defense(Defense other) : this()
        {
            if(other == null) return;
            _valueMelee = other._valueMelee;
            _valueRanged = other._valueRanged;
            _modificationMelee = new Modification(other._modificationMelee);
            _modificationRanged = new Modification(other._modificationRanged);

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Defense from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
