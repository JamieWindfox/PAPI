using PAPI.DataTypes;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Character.General
{
    public class ThresholdValue
    {
        public uint _threshold { get; private set; }
        public uint _value { get; private set; }
        public Modification _modification { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits of health
        /// _woundthreshold: if 0, it is automatically set to 1 instead
        /// _modififcation: if null, there is no modification on this health
        /// </summary>
        /// <param name="_threshold"></param>
        /// <param name="_value"></param>
        /// <param name="_modification"></param>
        [JsonConstructor]
        public ThresholdValue(uint _threshold, uint _value, Modification _modification)
        {
            this._threshold = (_threshold == 0) ? 1 : _threshold;
            this._value = _value;
            this._modification = (_modification == null) ? new Modification(0, GameTimeInterval.NOT_VALID) : _modification;
            WfLogger.Log(this, LogLevel.DETAILED, "Created new ThresholdValue (Threashold = " + _threshold + ", Value = " + _value + ")");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
