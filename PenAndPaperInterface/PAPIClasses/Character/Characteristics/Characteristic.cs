using PAPI.DataTypes;
using PAPI.Exception;
using PAPI.Logging;
using System.Text.Json.Serialization;

namespace PAPI.Character.Characteristics
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
        public static readonly uint MIN_VALUE = 1;
        public static readonly uint MAX_VALUE = 5;

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all traits of a characteristic
        /// </summary>
        /// <param name="_associatedEnum">Possible values: Strength, Agility, Intellect, Cunning, Willpower, Presence</param>
        /// <param name="_value">Must be at least 1, and at most 5; If an invalid value is given, it is set to 1</param>
        /// <param name="_modification">If null, there is no modification on the characterisitc</param>
        [JsonConstructor]
        public Characteristic(CharacteristicEnum _associatedEnum, uint _value, Modification _modification)
        {
            this._associatedEnum = _associatedEnum;
            this._value = (_value < MIN_VALUE || _value > MAX_VALUE) ? 1 : _value;
            this._modification = (_modification == null) ? new Modification(0, GameTimeIntervalEnum.NOT_VALID) : _modification;
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Characteristic (" + _associatedEnum.ToString() + ", Value: " + _value + ")");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Increases the value once and returns true, unless it has already reached the max-value,
        /// (if so, nothing happens and the method returns false)
        /// </summary>
        public bool Training()
        {
            if(_value > MAX_VALUE)
            {
                string exMsg = "The Value can never be greater than MAX_VALUE (Value = " + this._value + ", MAX_VALUE = " + MAX_VALUE + ")";
                WfLogger.Log(this, LogLevel.FATAL, exMsg);
                throw new InvalidValueException(exMsg);
            }
            if(_value < MAX_VALUE)
            {
                _value++;
                WfLogger.Log(this, LogLevel.DEBUG, "Trained " + _associatedEnum.ToString() + " to value: " + _value);
                return true;
            }
            else
            {
                WfLogger.Log(this, LogLevel.WARNING, "Tried to train " + _associatedEnum.ToString() + ", but it is already maximized (Value = " + _value + ")");
                return false;
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Fomula = NextRank * 10
        /// </summary>
        /// <returns>Exp cost to train the characteristic once</returns>
        public uint GetTrainingCost()
        {
            if (_value < MAX_VALUE)
            {
                uint cost = (this._value + 1) * 10;
                WfLogger.Log(this, LogLevel.DETAILED, "Trainings Cost of " + this._associatedEnum.ToString() + ": " + cost);
                return cost;
            }
            WfLogger.Log(this, LogLevel.DETAILED, "Trainings Cost of " + this._associatedEnum.ToString() + ": 0, beacuse it is already maxed");
            return 0;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Returns true, if the value is already maximized and therefore not applicable for training anymore
        /// </summary>
        /// <returns>True, if value is same as MAX Value</returns>
        public bool IsMaximized()
        {
            bool isMax = (_value >= MAX_VALUE);
            WfLogger.Log(this, LogLevel.DETAILED, this._associatedEnum.ToString() + " maximized: " + isMax);
            return isMax;
        }
    }
}