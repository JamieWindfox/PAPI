using PAPI.DataTypes;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Character.General
{
    public class Value
    {
        public uint _value { get; private set; }
        public Modification _modification { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits of a Value
        /// _modification: if null, there is no modification on this Value
        /// </summary>
        /// <param name="_value"></param>
        /// <param name="_modification"></param>
        [JsonConstructor]
        public Value(uint _value, Modification _modification)
        {
            this._value = _value;
            this._modification = (_modification == null) ? new Modification(0, GameTimeInterval.NOT_VALID) : _modification;
            WfLogger.Log(this, LogLevel.DETAILED, "Created Soak (Value = " + this._value + ", Modification: " + this._modification._value + ")");
        }
    }
}
