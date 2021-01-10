using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace PAPI.Settings
{
    public class AppSettings
    {
        /// <summary>
        /// The currently set Design
        /// </summary>
        public DesignEnum _activeDesign { get; private set; }

        /// <summary>
        /// The currently set language for all printed strings
        /// </summary>
        public LanguageEnum _activeLanguage { get; private set; }

        /// <summary>
        /// Is a sessions running at the moment?
        /// </summary>
        public bool _isSessionRunning { get; private set; } = false;

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The Json CTOR must contain all traits of athe AppSettings
        /// </summary>
        /// <param name="_activeDesign"></param>
        /// <param name="_activeLanguage"></param>
        /// <param name="_isSessionRunning"></param>
        [JsonConstructor]
        public AppSettings(DesignEnum _activeDesign, LanguageEnum _activeLanguage, bool _isSessionRunning)
        {
            this._activeDesign = _activeDesign;
            this._activeLanguage = _activeLanguage;
            this._isSessionRunning = _isSessionRunning;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new AppSettings (" + this._activeDesign + ", " + this._activeLanguage + ")");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates AppSettings with the default values: ENGLISH, MODERN and not running
        /// </summary>
        public AppSettings() : this(DesignEnum.GREEN_ON_BLACK, LanguageEnum.ENGLISH, false)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new default AppSettings)");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------

        /// <returns>A list of all constants of the Design enum</returns>
        public List<DesignEnum> GetAllDesigns()
        {
            return Enum.GetValues(typeof(DesignEnum)).Cast<DesignEnum>().ToList();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <returns>A list of all constants of the Lanaguage enum</returns>
        public List<LanguageEnum> GetAllLanguages()
        {
            return Enum.GetValues(typeof(LanguageEnum)).Cast<LanguageEnum>().ToList();
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Sets the currenty active design to the given one, but does not change the actual appearance
        /// </summary>
        /// <param name="design">the design enum to which the game is set</param>
        public void SetActiveDesign(DesignEnum design)
        {
            _activeDesign = design;
            WfLogger.Log("GameSettings.SetActiveDesign(DesignEnum)", LogLevel.DEBUG, "Set active design to " + design);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Sets the currently active language to the given one, but does not actually change the texts
        /// </summary>
        /// <param name="language">the language enum to which the game is set</param>
        public void SetActiveLanguage(LanguageEnum language)
        {
            _activeLanguage = language;
            WfLogger.Log("GameSettings.SetActiveLanguage(Language)", LogLevel.DEBUG, "Set active language to " + language);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

    }
}