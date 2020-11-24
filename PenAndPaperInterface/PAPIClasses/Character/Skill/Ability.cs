using PAPI.DataTypes;
using PAPI.Settings;
using System.Collections.Generic;

namespace PAPI.Character.Skill
{
    public class Ability
    {
        // All genres for which this ability is available
        private List<GenreEnum> m_genres;

        // The timestamp hoe often the ability can be used
        private GameTimeInterval m_interval;

        // The name of the ability
        private string m_name;

        // Does the ability have to be activated?
        private bool m_isActive;

        // Descriptions in the available languages
        private Dictionary<Language, string> m_descriptions;

        // Where to find the reference?
        private uint m_page;
        private RuleBook m_ruleBook;

        // Did the character already use the ability in the set time interval?
        private bool m_used;


        // ################################################# CTORS #################################################
        public Ability(string name, GameTimeInterval interval, bool active, Dictionary<Language, string> descriptions, RuleBook book, uint page, List<GenreEnum> genres)
        {
            m_genres = genres;
            m_interval = interval;
            m_name = name;
            m_isActive = active;
            m_descriptions = descriptions;
            m_page = page;
            m_ruleBook = book;
            m_used = false;
        }

        public Ability(string name, GameTimeInterval interval, bool active, Dictionary<Language, string> descriptions, RuleBook book, uint page)
            : this(name, interval, active, descriptions, book, page, new List<GenreEnum>(GameSettings.GetAllGenres()))
        { }

        // ################################################# GETTER #################################################


        // ################################################# SETTER #################################################
    }
}