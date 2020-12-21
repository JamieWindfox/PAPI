using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Item
{
    public class Weapon : EquipmentItem
    {
        // TODO: Add weapon specific traits

        // --------------------------------------------------------------------------------------------------------------------------------
        public Weapon(string _name, uint _basePrice, uint _encumbrance, uint _rarity, ItemConditionEnum _condition,
            Dictionary<ItemQuality, uint> _qualities, List<GenreEnum> _availableGenres, Dictionary<Language, string> _description)
            : base(_name, _basePrice, _encumbrance, _rarity, _condition, _qualities, _availableGenres, _description)
        { }

        public Weapon(Weapon other) : base(other._name, other._basePrice, other._encumbrance, other._rarity, other._condition,
           other._qualities, other._availableGenres, other._descriptionKey)
        {
            
        }

        // --------------------------------------------------------------------------------------------------------------------------------


    }
}
