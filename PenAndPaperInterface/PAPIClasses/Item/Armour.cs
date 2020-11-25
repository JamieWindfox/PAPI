using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Item
{
    public class Armour : EquipmentItem
    {
        private uint m_soak;
        private uint m_defense;


        // ################################################# CTORS #################################################
        public Armour(string name, uint basePrice, uint encumbrance, uint rarity, List<GenreEnum> genres, uint soak, uint defense) 
            : base(name, basePrice, encumbrance, rarity, genres)
        {
            m_soak = soak;
            m_defense = defense;
        }

        public Armour(Armour other) 
            : this(other.GetName(), other.GetBasePrice(), other.GetEncumbrance(), other.GetRarity(), other.GetGenres(), other.GetSoak(), other.GetDefense())
        { }


        // ################################################# GETTER #################################################

        public uint GetSoak() { return m_soak; }
        public uint GetDefense() { return m_defense; }


        // ################################################# SETTER #################################################
    }
}
