using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Item
{
    public class PAPIItem
    {
        // The name of the item
        private string m_name;

        // Base price in the worlds currency
        private uint m_basePrice;

        // The encumbrance/weight of the item
        private uint m_encumbrance;

        // The rarity of the item (scale 0 = very common, 5 = only on specific blackmarkets)
        private uint m_rarity;

        // In what condition is the item? Broken? not damaged at all?
        private ItemConditionEnum m_condition;

        // A List of all (special) qualities of the item
        private Dictionary<ItemQuality, uint> m_qualities;

        // A List of the genres in which this item is available
        private List<GenreEnum> m_genres;

        // ################################################# CTORS #################################################
        public PAPIItem(string name, uint basePrice, uint encumbrance, uint rarity, ItemConditionEnum condition, Dictionary<ItemQuality, uint> qualities, List<GenreEnum> genres)
        {
            m_name = name;
            m_basePrice = basePrice;
            m_encumbrance = encumbrance;
            m_rarity = rarity;
            m_condition = condition;
            m_qualities = qualities;
            m_genres = genres;
        }

        public PAPIItem(string name, uint basePrice, uint encumbrance, uint rarity, ItemConditionEnum condition, List<GenreEnum> genres) :
            this(name, basePrice, encumbrance, rarity, condition, new Dictionary<ItemQuality, uint>(), genres)
        { }

        public PAPIItem(string name, uint basePrice, uint encumbrance, uint rarity, Dictionary<ItemQuality, uint> qualities, List<GenreEnum> genres) :
            this(name, basePrice, encumbrance, rarity, ItemConditionEnum.NOT_DAMAGED, qualities, genres)
        { }

        public PAPIItem(string name, uint basePrice, uint encumbrance, uint rarity, List<GenreEnum> genres) :
            this(name, basePrice, encumbrance, rarity, ItemConditionEnum.NOT_DAMAGED, new Dictionary<ItemQuality, uint>(), genres)
        { }


        // ################################################# GETTER #################################################
        public string GetName() { return m_name; }
        public uint GetBasePrice() { return m_basePrice; }
        public uint GetEncumbrance() { return m_encumbrance; }
        public uint GetRarity() { return m_rarity; }
        public List<GenreEnum> GetGenres() { return m_genres; }
        public ItemConditionEnum GetCondition() { return m_condition; }
        public Dictionary<ItemQuality, uint> GetQualities() { return m_qualities; }


        // ################################################# SETTER #################################################
    }
}
