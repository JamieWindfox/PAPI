using System.Collections.Generic;
using System.Text.Json.Serialization;
using PAPI.Character.Appearance;
using PAPI.Logging;
using PAPI.Settings;

namespace PAPI.Character
{
    public class Species
    {
        /// <summary>
        /// The name of the species or race
        /// </summary>
        public string _nameKey { get; private set; }

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
        /// <param name="_nameKey">must start with "Species_, otherwise it can't be translated"</param>
        /// <param name="_availableGenres"></param>
        [JsonConstructor]
        public Species(string _nameKey, List<GenreEnum> _availableGenres)
        {
            this._nameKey = (_nameKey == null || _nameKey == "") ? "INVALID_SPECIES" : _nameKey;
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ? new List<GenreEnum>(GameSettings.GetAllGenres()) : _availableGenres;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Species " + this._nameKey);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public Species() : this(null, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new invalid Species from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public Species(Species other)
        {
            if (other == null) return;

            _nameKey = other._nameKey;
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
