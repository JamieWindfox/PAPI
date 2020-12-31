using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.DataTypes
{
    public class Modification
    {
        /// <summary>
        /// The value of the modification; A positive value adds to the value, a negative takes from it
        /// </summary>
        public int _value { get; private set; }

        /// <summary>
        /// The Time intervall when the modification wears off
        /// </summary>
        public GameTimeIntervalEnum _wearoff { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits of a modification
        /// </summary>
        /// <param name="_value">if 0, there is no modification, if positive it increases the value, if negiative, it decreases the initial value</param>
        /// <param name="_wearoff"></param>
        [JsonConstructor]
        public Modification(int _value, GameTimeIntervalEnum _wearoff)
        {
            this._value = _value;
            this._wearoff = _wearoff;
            WfLogger.Log(this, LogLevel.DEBUG, "Constructed Modification (Value = " + this._value + ", Wearoff = " + this._wearoff);
        }


    }
}
