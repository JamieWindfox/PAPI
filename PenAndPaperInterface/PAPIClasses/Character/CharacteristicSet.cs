using PAPI.Logging;
using PAPI.Character.Skill;
using PAPI.Exception;
using System.Text.Json.Serialization;

namespace PAPI.Character
{
    public class CharacteristicSet
    {
        /// <summary>
        /// Characteristic BRAWN for strength, toughness, indicator for wound threshold
        /// </summary>
        public Characteristic _brawn { get; private set; }

        /// <summary>
        /// Characteristic AGILITY for dexterity, hand-eye coordination and body control
        /// </summary>
        public Characteristic _agility { get; private set; }

        /// <summary>
        /// Characteristic INTELLECT for intelligence, education and mental acuity
        /// </summary>
        public Characteristic _intellect { get; private set; }

        /// <summary>
        /// Characteristic CUNNING for crafting, cleverness, creativity and how devious someone is
        /// </summary>
        public Characteristic _cunning { get; private set; }

        /// <summary>
        /// Characteristic WILLPOWER for discipline, self-control, mental fortitude and faith
        /// </summary>
        public Characteristic _willpower { get; private set; }

        /// <summary>
        /// Characteristic PRESENCE for charisma, confidence and force of personality
        /// </summary>
        public Characteristic _presence { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits of a characterisitc; each value must be an integer from 1 to 5
        /// if an invalid value is given, it is set to 1
        /// </summary>
        /// <param name="_brawn"></param>
        /// <param name="_agility"></param>
        /// <param name="_intellect"></param>
        /// <param name="_cunning"></param>
        /// <param name="_willpower"></param>
        /// <param name="_presence"></param>
        [JsonConstructor]
        public CharacteristicSet(uint _brawn, uint _agility, uint _intellect, uint _cunning, uint _willpower, uint _presence)
        {
            this._brawn = new Characteristic(CharacteristicEnum.BRAWN, _brawn, null);
            this._agility = new Characteristic(CharacteristicEnum.AGILITY, _agility, null);
            this._intellect = new Characteristic(CharacteristicEnum.INTELLECT, _intellect, null);
            this._cunning = new Characteristic(CharacteristicEnum.CUNNING, _cunning, null);
            this._willpower = new Characteristic(CharacteristicEnum.WILLPOWER, _willpower, null);
            this._presence = new Characteristic(CharacteristicEnum.PRESENCE, _presence, null);

            WfLogger.Log(this, LogLevel.DETAILED, "CharacterisitcSet (" +
                "BR = " + this._brawn._value +
                "AG = " + this._agility._value +
                "IN = " + this._intellect._value +
                "CU = " + this._cunning._value +
                "WI = " + this._willpower._value +
                "PR = " + this._presence._value + ") was created");
        }

        // A blank characteristic Set results in one point per characteristic as an absolute minimum
        public CharacteristicSet():this(1, 1, 1, 1, 1, 1)
        { }

        // --------------------------------------------------------------------------------------------------------------------------------
        public Characteristic Get(CharacteristicEnum characteristic)
        {
            switch (characteristic)
            {
                case CharacteristicEnum.BRAWN: return _brawn;
                case CharacteristicEnum.AGILITY: return _agility;
                case CharacteristicEnum.INTELLECT: return _intellect;
                case CharacteristicEnum.CUNNING: return _cunning;
                case CharacteristicEnum.WILLPOWER: return _willpower;
                case CharacteristicEnum.PRESENCE: return _presence;
                default:
                    string excMsg = "The Characteristic Enum value " + characteristic.ToString() + " doesn't exist.";
                    WfLogger.Log(this.GetType() + " Get(" + characteristic + ")", LogLevel.FATAL, excMsg);
                    throw new EnumNotFoundException(excMsg);
            }
        }


        // --------------------------------------------------------------------------------------------------------------------------------

    }
}