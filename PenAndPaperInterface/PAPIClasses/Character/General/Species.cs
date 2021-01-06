using System.Collections.Generic;
using System.Text.Json.Serialization;
using PAPI.Character.Appearance;
using PAPI.Character.General;
using PAPI.Logging;
using PAPI.Settings;
using PAPI.Settings.Game;

namespace PAPI.Character
{
    public class Species
    {
        /// <summary>
        /// The type/name of the species or race
        /// </summary>
        public SpeciesEnum _enum { get; private set; }

        /// <summary>
        /// The name of the species, if the enum is CUSTOM
        /// </summary>
        public string _name { get; private set; }

        /// <summary>
        /// A List of all settings, in which this species is available
        /// </summary>
        public List<GenreEnum> _availableGenres { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits for a species
        /// _name: if null, species is invalid
        /// _availableGenres: if null, species is available for all genres
        /// </summary>
        /// <param name="_enum"></param>
        /// <param name="_name">if enum is custom the name is set here, other wise the name is set automatically</param>
        /// <param name="_availableGenres"></param>
        [JsonConstructor]
        public Species(SpeciesEnum _enum, string _name, List<GenreEnum> _availableGenres)
        {
            this._enum = _enum;
            this._name = (_name == null || _name == "" || _enum != SpeciesEnum.CUSTOM) ? EnumConverter.Convert(_enum) : _name;
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ? new List<GenreEnum>(PAPIApplication.GetAllGenres()) : _availableGenres;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Species " + this._enum);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public Species() : this(SpeciesEnum.CUSTOM, null, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new invalid Species from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public Species(Species other)
        {
            if (other == null) return;

            _enum = other._enum;
            _name = other._name;
            _availableGenres = new List<GenreEnum>(other._availableGenres);
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------

        /// <param name="genre"></param>
        /// <returns>returns true, if the species is available for the given setting</returns>
        public bool AvailableForGenre(GenreEnum genre)
        {
            return _availableGenres.Contains(genre);
        }
    }
}
