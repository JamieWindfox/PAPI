using System.Collections.Generic;
using System.Text.Json.Serialization;
using PAPI.Logging;
using PAPI.Settings;

namespace PAPI.Character
{
    public class Species
    {
        // The name of the species or race
        public string _nameKey { get; private set; }

        // A List of all settings, in which this species is available
        public List<GenreEnum> _availableGenres { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits for a species
        /// _name: if null, species is invalid
        /// _availableGenres: if null, species is available for all genres
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_availableGenres"></param>
        [JsonConstructor]
        public Species(string _name, List<GenreEnum> _availableGenres)
        {
            if(_name == null || _name == "")
            {
                this._nameKey = "INVALID_SPECIES";
                this._availableGenres = new List<GenreEnum>();
                return;
            }
            this._nameKey = _name;
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ? new List<GenreEnum>(GameSettings.GetAllGenres()) : _availableGenres;
        }


        // --------------------------------------------------------------------------------------------------------------------------------

        public string GetName() { return _nameKey; }
        public List<GenreEnum> GetGenres() { return _availableGenres; }

        public bool AvailableForGenre(GenreEnum genre)
        {
            return _availableGenres.Contains(genre);
        }
    }
}
