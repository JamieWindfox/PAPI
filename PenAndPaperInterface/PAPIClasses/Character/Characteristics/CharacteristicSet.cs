using PAPI.Logging;
using PAPI.Character.Skill;
using PAPI.Exception;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace PAPI.Character.Characteristics
{
    public class CharacteristicSet
    {
        /// <summary>
        /// This should contain one of each Characteristic
        /// </summary>
        public List<Characteristic> _characteristicList { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all traits of a characterisitc
        /// </summary>
        /// <param name="_characteristicList">if empty, or if a characterisitc is missing, those get generated and get the value 1</param>
        [JsonConstructor]
        public CharacteristicSet(List<Characteristic> _characteristicList)
        {
            if(_characteristicList == null)
            {
                _characteristicList = new List<Characteristic>();
            }
            this._characteristicList = new List<Characteristic>();

            List<CharacteristicEnum> missing = new List<CharacteristicEnum>() { CharacteristicEnum.BRAWN, CharacteristicEnum.AGILITY, CharacteristicEnum.INTELLECT,
                CharacteristicEnum.CUNNING, CharacteristicEnum.WILLPOWER, CharacteristicEnum.PRESENCE};
            
            foreach(Characteristic characteristic in _characteristicList)
            {
                if(missing.Contains(characteristic._associatedEnum) && characteristic._value >= Characteristic.MIN_VALUE && characteristic._value <= Characteristic.MAX_VALUE)
                {
                    this._characteristicList.Add(characteristic);
                    missing.Remove(characteristic._associatedEnum);
                }
            }

            foreach(CharacteristicEnum charaEnum in missing)
            {
                this._characteristicList.Add(new Characteristic(charaEnum, 1, null));
            }

            WfLogger.Log(this, LogLevel.DETAILED, "CharacteristicSet was created");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Default CTOR, creates a CharacteristicSet with all values 1
        /// </summary>
        public CharacteristicSet() : this(new List<Characteristic>())
        {
            WfLogger.Log(this, LogLevel.DETAILED, "CharacteristicSet was created from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Copy CTOR, creates a copy of the given CharacteristicSet
        /// </summary>
        public CharacteristicSet(CharacteristicSet other) : this(other._characteristicList)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "CharacteristicSet was created from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Makes the whole CharacteristicSet completely random
        /// </summary>
        public void MakeRandom(int sumOfValues)
        {
            _characteristicList = (new CharacteristicSet(CharacteristicFactory.RandomCharacteristicSet(sumOfValues)))._characteristicList;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Returns the characteristic with the given characteristic enum
        /// </summary>
        /// <param name="characteristicEnum"></param>
        /// <returns></returns>
        public Characteristic Get(CharacteristicEnum characteristicEnum)
        {
            foreach(Characteristic characteristic in _characteristicList)
            {
                if(characteristic._associatedEnum == characteristicEnum)
                {
                    WfLogger.Log(this, LogLevel.DEBUG, "Found " + characteristicEnum);
                    return characteristic;
                }
            }
            string excMsg = "The Characteristic Enum value " + characteristicEnum.ToString() + " doesn't exist.";
            WfLogger.Log(this, LogLevel.FATAL, excMsg);
            throw new EnumNotFoundException(excMsg);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Calls the Training function of the given CharacteristicEnum
        /// </summary>
        /// <param name="characteristicEnum"></param>
        public bool TrainCharacteristic(CharacteristicEnum characteristicEnum)
        {
            if(Get(characteristicEnum)._value < Characteristic.MAX_VALUE)
            {
                return Get(characteristicEnum).Training();
            }
            else
            {
                string excMsg = $"The Characteristic Enum value {characteristicEnum.ToString()} wasn't found in the list of characteristics";
                WfLogger.Log(this, LogLevel.ERROR, excMsg);
                throw new EnumNotFoundException(excMsg);
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------


    }
}