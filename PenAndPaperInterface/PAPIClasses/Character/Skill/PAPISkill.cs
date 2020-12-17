using PAPI.DataTypes;
using PAPI.Logging;
using PAPI.Settings;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using PAPI.Character.Characteristic;

namespace PAPI.Character.Skill
{
    /// <summary>
    /// A skill is a specific trait of a character; Characters can learn and train many of them; their values ranges from 0 to 5
    /// </summary>
    public class PAPISkill
    {
        /// <summary>
        /// The name of the skill; Usually is set by the skill enum, but if it is a custom skill, it gets a different (custom) name
        /// </summary>
        public string _name { get; private set; }

        /// <summary>
        /// The enum associated with the skill
        /// </summary>
        public SkillEnum _skillEnum { get; private set; }

        /// <summary>
        /// The type of the skill; Can be General, Knowledge, Social, Magic, Combat or Custom
        /// </summary>
        public SkillTypeEnum _skillTypeEnum { get; private set; }

        /// <summary>
        /// The value of a Skill can range from 0 to 5
        /// </summary>
        public uint _value { get; private set; }

        /// <summary>
        /// This is the characteristic which the skill is associated with
        /// </summary>
        public CharacteristicEnum _characteristicEnum { get; private set; }

        /// <summary>
        /// A List of all genres in which this skill applies
        /// </summary>
        public List<GenreEnum> _availableGenres { get; private set; }

        /// <summary>
        /// The Modification of the skill at the current time
        /// </summary>
        public Modification _modification { get; private set; }

        /// <summary>
        /// Flag, if the skill is a career skill, and therefore cheaper to train for the character
        /// </summary>
        public bool _isCareer { get; private set; }

        /// <summary>
        /// Min and Max value of a skill
        /// </summary>
        private const uint MIN_VALUE = 0;
        private const uint MAX_VALUE = 5;

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits of the Skill
        /// _name: automatically gets the name of the skillEnum, except this is CUSTOM, then this name is set
        /// _value: if 0, the skill doesn't count as learned, if a invalid value is given, the skill is set to 0
        /// _availableGenres: if null or empty, the skill is available in all genres
        /// _modification: if null, there is no modification on the skill currently (default for newly trained or learned skills)
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_skillEnum"></param>
        /// <param name="_skillTypeEnum"></param>
        /// <param name="_value"></param>
        /// <param name="_characteristicEnum"></param>
        /// <param name="_availableGenres"></param>
        /// <param name="_modification"></param>
        /// <param name="_isCareer"></param>
        [JsonConstructor]
        public PAPISkill(string _name, SkillEnum _skillEnum, SkillTypeEnum _skillTypeEnum, uint _value, CharacteristicEnum _characteristicEnum, 
            List<GenreEnum> _availableGenres, Modification _modification, bool _isCareer)
        {
            if(_skillEnum == SkillEnum.NOT_VALID)
            {
                // set _skillEnum and _name to invalid valued, so that the the next if recognizes the object as invalid
                _skillEnum = SkillEnum.CUSTOM;
                _name = "";
            }
            if(_skillEnum == SkillEnum.CUSTOM && (_name == null || _name == ""))
            {
                this._name = "INVALID SKILL";
                this._skillEnum = SkillEnum.NOT_VALID;
                this._skillTypeEnum = SkillTypeEnum.CUSTOM;
                this._value = 0;
                this._characteristicEnum = CharacteristicEnum.BRAWN;
                this._availableGenres = new List<GenreEnum>();
                this._modification = new Modification(0, GameTimeInterval.NOT_VALID);
                WfLogger.Log(this, LogLevel.WARNING, 
                    "An invalid skill was created (either because the skillEnum, or the name wasn't valid)");
                return;
            }
            this._skillEnum = _skillEnum;
            this._name = (_skillEnum != SkillEnum.CUSTOM) ? EnumToString(_skillEnum) : _name;
            this._skillTypeEnum = _skillTypeEnum;
            this._value = (_value < MIN_VALUE || _value > MAX_VALUE)? this._value = 0 : this._value = _value;
            this._characteristicEnum = this._characteristicEnum;
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ?
                new List<GenreEnum>(GameSettings.GetAllGenres()) : _availableGenres;
            this._modification = (_modification == null) ? new Modification(0, GameTimeInterval.NOT_VALID) : _modification;
            this._isCareer = _isCareer;
            WfLogger.Log(this, LogLevel.DETAILED,
                    "Skill '" + this._name + "' was created");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The name of the enum with an uppercase first letter, and all folloging letters lowercase
        /// Example: ARCANE_MAGIC -> "Arcane Magic"
        /// </summary>
        /// <param name="skill"></param>
        /// <returns></returns>
        private static string EnumToString(SkillEnum skill)
        {
            string enumString = skill.ToString().ToLower();
            string concatenatedString = enumString[0].ToString().ToUpper();
            for(int i = 1; i < enumString.Length; ++i)
            {
                if (enumString[i] == '_')
                {
                    concatenatedString += ' ';
                }
                else
                {
                    concatenatedString += (i > 1 && enumString[i - 1] == '_') ?
                        enumString[i].ToString().ToUpper() : concatenatedString += enumString[i].ToString().ToLower();
                }
            }
            WfLogger.Log("PAPISkill.EnumToString(string)", LogLevel.DETAILED, "Parsed SkillEnum '" + skill + "' to string '" + concatenatedString + "'");
            return concatenatedString;
        }
    }

}