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
        /// BRAWN for strength, toughness, indicator for wound threshold
        /// AGILITY for dexterity, hand-eye coordination and body control
        /// INTELLECT for intelligence, education and mental acuity
        /// CUNNING for crafting, cleverness, creativity and how devious someone is
        /// WILLPOWER for discipline, self-control, mental fortitude and faith
        /// PRESENCE for charisma, confidence and force of personality
        /// </summary>
        public List<Characteristic> _characteristicList { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits of a characterisitc; each value must be an integer from 1 to 5
        /// _characteristics: if null, every characteristic is set to 1
        /// </summary>
        /// <param name="_characteristicList"></param>
        [JsonConstructor]
        public CharacteristicSet(List<Characteristic> _characteristicList)
        {
            this._characteristicList = (_characteristicList == null || _characteristicList.Count != 6) ?
                new List<Characteristic>(CharacteristicFactory.BaseCharacteristicList()) :
                new List<Characteristic>(_characteristicList);

            WfLogger.Log(this, LogLevel.DETAILED, "CharacteristicSet was created");
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
            string excMsg = "The Characteristic Enum value " + characteristicEnum.ToString() 
                + " wasn't found in the list of characteristics";
            WfLogger.Log(this, LogLevel.ERROR, excMsg);
            throw new EnumNotFoundException(excMsg);
        }

        // --------------------------------------------------------------------------------------------------------------------------------


    }
}