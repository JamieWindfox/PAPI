using PAPI.Settings;
using System.Collections.Generic;

namespace PAPI.Item
{
    public class ItemQuality
    {
        // The name of the item quality
        private string m_name;

        // Does the quality has to be activated somehow?
        private bool m_isActive;

        // description in available languages
        private Dictionary<Language, string> m_descriptions;


        public ItemQuality(string name, bool active, Dictionary<Language, string> descriptions)
        {
            m_name = name;
            m_isActive = active;
            m_descriptions = descriptions;
        }
    }
}