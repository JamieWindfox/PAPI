using PAPI.Logging;
using PAPI.Settings;
using System.Collections.Generic;

namespace PAPI.Character
{
    public class Motivation
    {
        private readonly MotivationTypeEnum m_type;
        private readonly string m_name;
        private readonly Dictionary<Language, string> m_descriptions;
        private readonly List<GenreEnum> m_availableGenres;

        // ################################################# CTOR #################################################
        public Motivation(MotivationTypeEnum type, string name, Dictionary<Language, string> descriptions, List<GenreEnum> genres)
        {
            m_type = type;
            m_name = name;
            m_descriptions = descriptions;
            m_availableGenres = genres;
        }

        public Motivation(MotivationTypeEnum type, string name, Dictionary<Language, string> descriptions)
        {
            m_type = type;
            m_name = name;
            m_descriptions = descriptions;
            m_availableGenres = GameSettings.GetAllGenres();
        }

        // ################################################# GETTER #################################################
        public MotivationTypeEnum GetMotivationType() { return m_type; }
        public string GetName() { return m_name; }
        public Dictionary<Language, string> GetDescriptions() { return m_descriptions; }
        public string GetDescription(Language language) { return m_descriptions[language]; }
        public bool AvailableForGenre(GenreEnum genre) { return m_availableGenres.Contains(genre); }

        // ################################################# SETTER #################################################
        public void AddDescription(Language language, string description)
        {
            if (!m_descriptions.ContainsKey(language))
            {
                m_descriptions.Add(language, description);
            }
            else
            {
                string msg = "Can't add description (" + description + "); There already is a description for " + m_name + " in " + language;
                WfLogger.Log(this.GetType() + ".AddDescription(Language, string)", LogLevel.WARNING, msg);
            }
        }
    }
}