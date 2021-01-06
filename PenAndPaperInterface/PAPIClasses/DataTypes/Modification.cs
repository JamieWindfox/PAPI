using PAPI.Logging;
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

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates new default Modification with value = 0 and a invalid wearoff
        /// </summary>
        public Modification() : this(0, GameTimeIntervalEnum.NOT_VALID)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created a new Modification from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// creates a copy of the given Modification
        /// </summary>
        /// <param name="other">if null, a default Modification ist created</param>
        public Modification(Modification other) : this(other._value, other._wearoff)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created a new Modification from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------

    }
}
