using System.Collections.Generic;

using PAPI.Logging;
using PAPI.Settings;

namespace PAPI.Character
{
    public class Species
    {
        // The name of the species or race
        public string name { get; private set; }

        // A List of all settings, in which this species is available
        private List<GenreEnum> m_possibleGenres;

        // ################################################# CTORS #################################################
        // CTOR with just a name; Available for all Settings
        public Species(string name) : this(name, GameSettings.GetAllGenres())
        { }

        public Species(string name, List<GenreEnum> genres)
        {
            this.name = name;
            m_possibleGenres = genres;
            WfLogger.Log(this.GetType() + ".CTOR", LogLevel.INFO, "Constructed Species '" + this.name + "'");
        }

        // ################################################# GETTER #################################################

        public string GetName() { return name; }
        public List<GenreEnum> GetGenres() { return m_possibleGenres; }

        public bool AvailableForGenre(GenreEnum genre)
        {
            return m_possibleGenres.Contains(genre);
        }
    }
}
