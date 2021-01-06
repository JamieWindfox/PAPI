using PAPI.Logging;
using PAPI.Settings;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PAPI.Character.Motivations
{
    public class Motivation
    {
        public MotivationTypeEnum _type { get; private set; }
        public string _nameKey { get; private set; }
        public string _descriptionKey { get; private set; }
        public List<GenreEnum> _availableGenres { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all triats of a motivation, 
        /// </summary>
        /// <param name="_type">The type of the motivation</param>
        /// <param name="_nameKey">if null or empty, the motivation is invalid</param>
        /// <param name="_descriptionKey">if null or empty, the motivation does not have a description</param>
        /// <param name="_availableGenres">if null or empty, the motivation is available for all genres</param>
        [JsonConstructor]
        public Motivation(MotivationTypeEnum _type, string _nameKey, string _descriptionKey, List<GenreEnum> _availableGenres)
        {
            this._type = _type;
            this._nameKey = (_nameKey == null || _nameKey == "") ? "INVALID_MOTIVATION" : _nameKey;
            this._descriptionKey = (_descriptionKey == null || _descriptionKey == "") ? "INVALID_DESCRIPTION" : _descriptionKey; ;
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ? new List<GenreEnum>(GameSettings.GetAllGenres()) : _availableGenres;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Motivation " + this._type + ": " + _nameKey);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// creates an invalid motivation
        /// </summary>
        public Motivation() : this(MotivationTypeEnum.STRENGTH, null, null, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Motivation from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a motivation as a copy of the given one
        /// </summary>
        /// <param name="other">if null, an invalid motivation is created</param>
        public Motivation(Motivation other) : this()
        {
            if (other == null) return;

            _nameKey = other._nameKey;
            _type = other._type;
            _descriptionKey = other._descriptionKey;
            _availableGenres = new List<GenreEnum>(other._availableGenres);

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Motivation from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}