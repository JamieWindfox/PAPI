using PAPI.Logging;
using PAPI.Settings;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PAPI.Character.Motivations
{
    public class Motivation
    {
        public MotivationTypeEnum _type { get; private set; }
        public string _name { get; private set; }
        public string _descriptionKey { get; private set; }
        public List<GenreEnum> _availableGenres { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all triats of a motivation, 
        /// </summary>
        /// <param name="_type">The type of the motivation</param>
        /// <param name="_name">if null or empty, the motivation is invalid</param>
        /// <param name="_descriptionKey">if null or empty, the motivation does not have a description</param>
        /// <param name="_availableGenres">if null or empty, the motivation is available for all genres</param>
        [JsonConstructor]
        public Motivation(MotivationTypeEnum _type, string _name, string _descriptionKey, List<GenreEnum> _availableGenres)
        {
            this._type = _type;
            if(_name == null || _name == "")
            {
                this._name = "INVALID_MOTIVATION";
                this._descriptionKey = "INVALID_DESCRIPTION";
                this._availableGenres = new List<GenreEnum>();
                return;
            }

            this._name = _name;
            this._descriptionKey = _descriptionKey;
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ?
                new List<GenreEnum>(GameSettings.GetAllGenres()) : _availableGenres;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

    }
}