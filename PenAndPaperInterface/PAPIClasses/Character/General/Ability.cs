using PAPI.DataTypes;
using PAPI.Logging;
using PAPI.Settings;
using PAPI.Settings.Game;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PAPI.Character.General
{
    /// <summary>
    /// A character can gain different abilities; Those abilities can be very unique; therefore only
    /// some vital traits of them are saved - the rest must be read in their description
    /// </summary>
    public class Ability
    {
        public string _nameKey { get; private set; }

        /// <summary>
        /// Flags if the ability needs something to get activated or if its passive
        /// </summary>
        public bool _isActive { get; private set; }

        /// <summary>
        /// the key with which the resources strings of the ability description can be assigned
        /// </summary>
        public string _descriptionKey { get; private set; }

        /// <summary>
        /// A list of all genres for which this ability is available
        /// </summary>
        public List<GenreEnum> _availableGenres { get; private set; }

        /// <summary>
        /// The interval of how often the ability can be used
        /// </summary>
        public GameTimeIntervalEnum _gameTimeInterval { get; private set; }

        /// <summary>
        /// The rule book and page, where a more detailed description can be found
        /// </summary>
        public BookResource _bookResource { get; private set; }
        
        /// <summary>
        /// Did the character already use the ability in the set time interval or can it be used now?
        /// </summary>
        public bool _isUsable { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all traits for the ability
        /// </summary>
        /// <param name="_nameKey">must start with "Ability_"</param>
        /// <param name="_isActive"></param>
        /// <param name="_descriptionKey">if null, there is no description</param>
        /// <param name="_availableGenres">if null or empty, the ability is available for all settings</param>
        /// <param name="_gameTimeInterval">determines how often the ability can be used</param>
        /// <param name="_bookResource">if null, the asset is custom</param>
        /// <param name="_isUsable">Should always be true in a newly created/learnt ability, set to false if used, set to true again after time interval</param>
        [JsonConstructor]
        public Ability(string _nameKey, bool _isActive, string _descriptionKey, List<GenreEnum> _availableGenres,
            GameTimeIntervalEnum _gameTimeInterval, BookResource _bookResource, bool _isUsable)
        {
            this._nameKey =  (_nameKey == null) ? "INVALID_ABILITY" : _nameKey;
            this._isActive = _isActive;
            this._descriptionKey = (_descriptionKey == null) ? "INVALID_DESCRIPTION" : _descriptionKey;
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ?
                this._availableGenres = new List<GenreEnum>(PAPIApplication.GetAllGenres()) : _availableGenres;
            this._gameTimeInterval = _gameTimeInterval;
            this._bookResource = _bookResource;
            this._isUsable = _isUsable;

            WfLogger.Log(this, LogLevel.DETAILED, "Ability '" + this._nameKey + "' was created");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates an invalid ability
        /// </summary>
        public Ability() : this(null, false, null, null, GameTimeIntervalEnum.NOT_VALID, null, true)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Ability from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// creates a copy of the given ability
        /// </summary>
        /// <param name="other">if null, an invalid ability is created</param>
        public Ability(Ability other) : this()
        {
            if (other == null) return;

            _nameKey = other._nameKey;
            _isActive = other._isActive;
            _descriptionKey = other._descriptionKey;
            _availableGenres = new List<GenreEnum>(other._availableGenres);
            _gameTimeInterval = other._gameTimeInterval;
            _bookResource = new BookResource(other._bookResource);
            _isUsable = other._isUsable;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Ability from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------

    }
}