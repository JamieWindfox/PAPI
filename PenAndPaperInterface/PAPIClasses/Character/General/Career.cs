using PAPI.Character.Skill;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Character
{
    public class Career
    {
        public string _name { get; private set; }

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
        /// _name: Must not be null or empty, otherwise the career is not valid
        /// _availableGenres: if null or empty, the career is avaílable for all genres
        /// _careerSkills: if less than 8 are given, the career is not valid
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_availableGenres"></param>
        /// <param name="_careerSkills"></param>
        [JsonConstructor]
        public Career(string _name, List<GenreEnum> _availableGenres, List<PAPISkill> _careerSkills)
        {
            if(_name == null || _name == "" || _careerSkills.Count < 8)
            {
                _name = "INVALID CAREER";
                _availableGenres = new List<GenreEnum>();
                _careerSkills = new List<PAPISkill>();
                return;
            }
            this._name = _name;
            this._careerSkills = new List<PAPISkill>(_careerSkills);
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ?
                new List<GenreEnum>(GameSettings.GetAllGenres()) : new List<GenreEnum>(_availableGenres);
        }
    }
}
