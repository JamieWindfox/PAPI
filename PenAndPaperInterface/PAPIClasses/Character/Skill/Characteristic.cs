using PAPI.DataTypes;
using PAPI.Logging;
using System.Text.Json.Serialization;

namespace PAPI.Character.Skill
{
    /// <summary>
    /// Each character has the following Characteristics: Brawn, Agility, Intellect, Cunning, Willpower and Presence
    /// in different levels. A Characteristic value starts at and cannot fall below 1, and cannot exceed 5
    /// </summary>
    public class Characteristic
    {
        /// <summary>
        /// The associated characteristic enum (BRAWN, AGILITY, INTELLECT, CUNNING, WILLPOWER, PRESENCE)
        /// </summary>
        public CharacteristicEnum _associatedEnum { get; private set; }

        /// <summary>
        /// The value of the characteristic, an Integer from 1 to 5
        /// </summary>
        public uint _value { get; private set; }

        /// <summary>
        /// The current modification, which strengthes or weakens the characteristic
        /// </summary>
        public Modification _modification { get; private set; }

        /// <summary>
        /// Constants for defining the min- and max values of a characteristic
        /// </summary>
        private const uint MIN_VALUE = 1;
        private const uint MAX_VALUE = 5;

        // --------------------------------------------------------------------------------------------------------------------------------
        
        /// <summary>
        /// The JSON Constructor must contain all possible traits of the characterisitc
        /// _value: Must be at least 1, and at most 5; If an invalid value is given, it is set to 1
        /// _modification: if null, there is no modification on the characterisitc, no new characteristic should have a modification
        /// </summary>
        /// <param name="_associatedEnum"></param>
        /// <param name="_value"></param>
        /// <param name="_modification"></param>
        [JsonConstructor]
        public Characteristic(CharacteristicEnum _associatedEnum, uint _value, Modification _modification)
        {
            this._associatedEnum = _associatedEnum;
            this._value = (_value < MIN_VALUE || _value > MAX_VALUE) ? 1 : _value;
            this._modification = (_modification == null) ? new Modification(0, GameTimeInterval.NOT_VALID) : _modification;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

    }
}