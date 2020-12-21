using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Item
{
    public class Armour : Wearable
    {



        // --------------------------------------------------------------------------------------------------------------------------------
        public Armour(string _name, uint _basePrice, uint _encumbrance, uint _rarity, ItemConditionEnum _condition,
            Dictionary<ItemQuality, uint> _qualities, List<GenreEnum> _availableGenres, string _descriptionKey,
            uint _soak, uint _defense)
            : base(_name, _basePrice, _encumbrance, _rarity, _condition, _qualities, _availableGenres, _descriptionKey, _soak, _defense)
        { }

        public Armour(Armour other) : base(other)
        { }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
