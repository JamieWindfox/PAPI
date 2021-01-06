using PAPI.DataTypes;
using PAPI.Logging;
using PAPI.Settings;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using PAPI.Character.Characteristics;
using PAPI.Settings.Game;

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
        public Value _value { get; private set; }

        /// <summary>
        /// This is the characteristic which the skill is associated with
        /// </summary>
        public CharacteristicEnum _characteristicEnum { get; private set; }

        /// <summary>
        /// A List of all genres in which this skill applies
        /// </summary>
        public List<GenreEnum> _availableGenres { get; private set; }

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
        /// </summary>
        /// <param name="_name">automatically gets the name of the skillEnum, except this is CUSTOM, then this name is set (if so, start with "Skill_"</param>
        /// <param name="_skillEnum">the skill as enum, if it does not exist yet: take CUSTOM</param>
        /// <param name="_skillTypeEnum">the category the skill belongs to</param>
        /// <param name="_value">if 0, the skill doesn't count as learned, if a invalid value is given, the skill is set to 0</param>
        /// <param name="_characteristicEnum">the characteristic the skill belongs to</param>
        /// <param name="_availableGenres">if null or empty, the skill is available in all genres</param>
        /// <param name="_isCareer"></param>
        [JsonConstructor]
        public PAPISkill(string _name, SkillEnum _skillEnum, SkillTypeEnum _skillTypeEnum, Value _value, CharacteristicEnum _characteristicEnum, 
            List<GenreEnum> _availableGenres, bool _isCareer)
        {
            this._skillEnum = _skillEnum;
            this._name = (_name == null || _name == "" || _skillEnum != SkillEnum.CUSTOM) ? ("Skill_" + _skillEnum.ToString()) : _name;
            this._skillTypeEnum = _skillTypeEnum;
            this._value = (_value._value < MIN_VALUE || _value._value > MAX_VALUE)? this._value = new Value(0, null) : this._value = _value;
            this._characteristicEnum = this._characteristicEnum;
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ?
                new List<GenreEnum>(PAPIApplication.GetAllGenres()) : _availableGenres;
            this._isCareer = _isCareer;
            WfLogger.Log(this, LogLevel.DETAILED, "Skill '" + this._name + "' was created");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates new invalid skill
        /// </summary>
        public PAPISkill() : this(null, SkillEnum.CUSTOM, SkillTypeEnum.CUSTOM, null, CharacteristicEnum.AGILITY, null, false)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Skill from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a skill as copy of the given one
        /// </summary>
        /// <param name="other">if null, a default skill is created</param>
        public PAPISkill(PAPISkill other) : this()
        {
            if (other == null) return;

            _skillEnum = other._skillEnum;
            _skillTypeEnum = other._skillTypeEnum;
            _name = other._name;
            _value = other._value;
            _characteristicEnum = other._characteristicEnum;
            _availableGenres = new List<GenreEnum>(other._availableGenres);
            _isCareer = other._isCareer;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Skill from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
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