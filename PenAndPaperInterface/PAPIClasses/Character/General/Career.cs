using PAPI.Character.Skill;
using PAPI.Logging;
using PAPI.Settings;
using PAPI.Settings.Game;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Character
{
    public class Career
    {
        public string _nameKey { get; private set; }

        /// <summary>
        /// A list of a genres in which the career is available
        /// </summary>
        public List<GenreEnum> _availableGenres { get; private set; }

        /// <summary>
        /// Every career must have exactly 8 career skills, which are cheaper to train for the character of the career;
        /// If there are more than 8 in the list, the player gets the 8 first available for the set genre
        /// </summary>
        public List<PAPISkill> _careerSkills { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// A JSON Constructor must contain all possible traits f a career;
        /// </summary>
        /// <param name="_nameKey">Must not be null or empty, otherwise the career is not valid</param>
        /// <param name="_availableGenres">if null or empty, the career is avaílable for all genres</param>
        /// <param name="_careerSkills">if less than 8 are given, the career is not valid</param>
        [JsonConstructor]
        public Career(string _nameKey, List<GenreEnum> _availableGenres, List<PAPISkill> _careerSkills)
        {
            if(_nameKey == null || _nameKey == "" || _careerSkills.Count < 8)
            {
                _nameKey = "Career_INVALID_CAREER";
                _availableGenres = new List<GenreEnum>();
                _careerSkills = new List<PAPISkill>();
                return;
            }
            this._nameKey = _nameKey;
            this._careerSkills = new List<PAPISkill>(_careerSkills);
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ?
                new List<GenreEnum>(PAPIApplication.GetAllGenres()) : new List<GenreEnum>(_availableGenres);

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Career " + _nameKey);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates an invalid default career
        /// </summary>
        public Career() : this("Career_INVALID_CAREER", null, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Career from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given Career
        /// </summary>
        /// <param name="other">if null, a default one is created</param>
        public Career(Career other) : this()
        {
            if (other == null) return;

            _nameKey = other._nameKey;
            _careerSkills = new List<PAPISkill>(other._careerSkills);
            _availableGenres = new List<GenreEnum>(other._availableGenres);

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Career from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
