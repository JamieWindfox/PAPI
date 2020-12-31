using PAPI.DataTypes;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.DataTypes
{
    public class ThresholdValue : Value
    {
        public uint _threshold { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits of a threshold value
        /// </summary>
        /// <param name="_threshold">if 0, it is automatically set to 1 instead</param>
        /// <param name="_value">can be any value between 0 and the theshold, if an invalid value is given, it is set to 0</param>
        /// <param name="_modification">if null, there is no modification on this health</param>
        [JsonConstructor]
        public ThresholdValue(uint _threshold, uint _value, Modification _modification) : base((_value <= _threshold) ? _value : 0, _modification)
        {
            this._threshold = (_threshold == 0) ? 1 : _threshold;
                        
            WfLogger.Log(this, LogLevel.DETAILED, "Created new ThresholdValue (Threshold = " + _threshold + ", Value = " + _value + ")");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
