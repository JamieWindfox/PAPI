using PAPI.DataTypes;
using PAPI.Logging;
using PAPI.Settings;
using PAPI.Settings.Game;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PAPI.Character.General
{
    public class CriticalInjury
    {
        
        public string _nameKey { get; private set; }

        /// <summary>
        /// The range of values, which indicate the critical injury from the throw of a D100
        /// </summary>
        public uint _lowerBoundD100 { get; private set; }
        public uint _upperBoundD100 { get; private set; }

        public DifficultyEnum _severity { get; private set; }

        public string _descriptionKey { get; private set; }

        public bool _hasPermanentEffect { get; private set; }

        public BookResource _bookResource { get; private set; }

        public List<GenreEnum> _availableGenres { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The Json Consturctor must contain all traits of a critical injury
        /// </summary>
        /// <param name="_nameKey">the key of the name of the critical injury to get the right string from the resources</param>
        /// <param name="_lowerBoundD100">the lowest dice result for this critical injury</param>
        /// <param name="_upperBoundD100">the highest dice result for this critical injury</param>
        /// <param name="_severity">the difficulty for healing attempts of the critical injury</param>
        /// <param name="_descriptionKey">the key of the description, found in the resources, if null, there is no description</param>
        /// <param name="_hasPermanentEffect">true, if even after healing a permanent effect stays (e.g. losing a limb)</param>
        /// <param name="_bookResource">where the description can be found, if null, it is custom</param>
        /// <param name="_availableGenres">if null, the critical injury is available for all genres</param>
        [JsonConstructor]
        public CriticalInjury(string _nameKey, uint _lowerBoundD100, uint _upperBoundD100, DifficultyEnum _severity, string _descriptionKey, bool _hasPermanentEffect,
            BookResource _bookResource, List<GenreEnum> _availableGenres)
        {
            this._nameKey = (_nameKey == null || _nameKey == "") ? "INVALID_CRITICAL_INJURY" : _nameKey;
            this._lowerBoundD100 = _lowerBoundD100;
            this._upperBoundD100 = (_upperBoundD100 < this._lowerBoundD100) ? this._lowerBoundD100 : _upperBoundD100;
            this._severity = _severity;
            this._descriptionKey = (_descriptionKey == null || _descriptionKey == "") ? "INVALID_DESCRIPTION" : _descriptionKey;
            this._hasPermanentEffect = _hasPermanentEffect;
            this._bookResource = (_bookResource == null) ? new BookResource(RuleBookEnum.NO_RULE_BOOK, 0) : _bookResource;
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ? new List<GenreEnum>(PAPIApplication.GetAllGenres()) : _availableGenres;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Critical Injury " + this._nameKey);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates an invlalid default critical injury
        /// </summary>
        public CriticalInjury() : this(null, 0, 0, DifficultyEnum.NONE, null, false, null, new List<GenreEnum>())
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Critical Injury from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given Critical Injurie
        /// </summary>
        /// <param name="other">if null, the a default one is created</param>
        public CriticalInjury(CriticalInjury other) : this()
        {
            if (other == null) return;

            _nameKey = other._nameKey;
            _lowerBoundD100 = other._lowerBoundD100;
            _upperBoundD100 = other._upperBoundD100;
            _severity = other._severity;
            _descriptionKey = other._descriptionKey;
            _hasPermanentEffect = other._hasPermanentEffect;
            _bookResource = new BookResource(other._bookResource);
            _availableGenres = new List<GenreEnum>(other._availableGenres);

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Critical Injury from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
