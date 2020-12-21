using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Item
{
    /// <summary>
    /// A Wearable is an equippable Item that can be worn on the body; It usually has a soak and/or a defense value,
    /// or is even just looks or has a special ability
    /// </summary>
    public class Wearable : EquipmentItem
    {
        public uint _soak { get; private set; }
        public uint _defense { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------
        public Wearable(string _name, uint _basePrice, uint _encumbrance, uint _rarity, ItemConditionEnum _condition,
            Dictionary<ItemQuality, uint> _qualities, List<GenreEnum> _availableGenres,string _descriptionKey,
            uint _soak, uint _defense)
            : base(_name, _basePrice, _encumbrance, _rarity, _condition, _qualities, _availableGenres, _descriptionKey)
        {
            this._soak = _soak;
            this._defense = _defense;
        }

        public Wearable(Wearable other) : base(other._name, other._basePrice, other._encumbrance, other._rarity, other._condition, 
            other._qualities, other._availableGenres, other._descriptionKey)
        {
            this._soak = other._soak;
            this._defense = other._defense;
        }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
