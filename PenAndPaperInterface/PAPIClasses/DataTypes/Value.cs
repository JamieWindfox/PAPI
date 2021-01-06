using PAPI.DataTypes;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.DataTypes
{
    public class Value
    {
        public uint _value { get; private set; }
        public Modification _modification { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits of a Value
        /// </summary>
        /// <param name="_value">the current value as uint</param>
        /// <param name="_modification">if null, there is no modification on this Value</param>
        [JsonConstructor]
        public Value(uint _value, Modification _modification)
        {
            this._value = _value;
            this._modification = (_modification == null) ? new Modification(0, GameTimeIntervalEnum.NOT_VALID) : _modification;
            WfLogger.Log(this, LogLevel.DETAILED, "Created Soak (Value = " + this._value + ", Modification: " + this._modification._value + ")");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Default CTOR with value = 0 and no modification
        /// </summary>
        public Value() : this(0, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Value from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given Value
        /// </summary>
        /// <param name="other">if null, a default value is created</param>
        public Value(Value other) : this()
        {
            if (other == null) return;

            _value = other._value;
            _modification = new Modification(other._modification);

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Value from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
