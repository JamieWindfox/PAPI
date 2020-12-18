﻿using PAPI.DataTypes;
using PAPI.Logging;
using PAPI.Settings;
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
        public string _name { get; private set; }

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
        public GameTimeInterval _gameTimeInterval { get; private set; }

        /// <summary>
        /// The rule book and page, where a more detailed description can be found
        /// </summary>
        public BookResource _bookResource { get; private set; }
        
        /// <summary>
        /// Did the character already use the ability in the set time interval?
        /// </summary>
        public bool _isUsed { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible parameters for the ability
        /// _name: must not be null or an empty string
        /// _descriptions: if null, an empty Dictionary is created
        /// _availableGenres: if null or empty, the ability is available for all settings
        /// _isUsed: Should always be false in a newly created/learnt ability
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_isActive"></param>
        /// <param name="_descriptionKey"></param>
        /// <param name="_availableGenres"></param>
        /// <param name="_gameTimeInterval"></param>
        /// <param name="_ruleBookOfDescription"></param>
        /// <param name="_pageOfDescription"></param>
        /// <param name="_isUsed"></param>
        [JsonConstructor]
        public Ability(string _name, bool _isActive, string _descriptionKey, List<GenreEnum> _availableGenres,
            GameTimeInterval _gameTimeInterval, BookResource _bookResource, bool _isUsed)
        {
            if(_name == null || _name == "")
            {
                this._name = "INVALID_ABILITY";
                this._descriptionKey = "INVALID_DESCRIPTION";
                this._availableGenres = new List<GenreEnum>();
                this._gameTimeInterval = GameTimeInterval.NOT_VALID;
                this._bookResource = new BookResource(RuleBook.NO_RULE_BOOK, 0);
                WfLogger.Log(this, LogLevel.WARNING, "An invalid Ability was created (_name was null or empty)");
                return;
            }
            this._name =  _name;
            this._isActive = _isActive;
            this._descriptionKey = (_descriptionKey == null) ? "INVALID_DESCRIPTION" : _descriptionKey;
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ?
                this._availableGenres = new List<GenreEnum>(GameSettings.GetAllGenres()) : _availableGenres;
            this._gameTimeInterval = _gameTimeInterval;
            this._bookResource = _bookResource;
            this._isUsed = _isUsed;
            WfLogger.Log(this, LogLevel.DETAILED, "Ability '" + this._name + "' was created");
        }
        // --------------------------------------------------------------------------------------------------------------------------------



    }
}