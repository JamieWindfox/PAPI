using PAPI.Character.General;
using PAPI.DataTypes;
using PAPI.Logging;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Item
{
    /// <summary>
    /// A Wearable is an equippable Item that can be worn on the body; It usually has a soak and/or a defense value,
    /// or is even just looks or has a special ability
    /// </summary>
    public class WearableItem : EquipmentItem
    {
        public Value _soak { get; private set; }
        public Defense _defense { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The Son CTOR must contain all traits of a wearable item
        /// </summary>
        /// <param name="_nameKey">if null or empty, the item is not valid</param>
        /// <param name="_basePrice">the price before any modifiers are adjusted</param>
        /// <param name="_encumbrance">the weight of the item</param>
        /// <param name="_rarity"> a value from 0 to 5</param>
        /// <param name="_condition">if null, the item is in perfect condition</param>
        /// <param name="_qualities">if null or empty, the item has no special qualities</param>
        /// <param name="_availableGenres">if null or empty, the item is available in all settings</param>
        /// <param name="_descriptionKey">if null or empty, the item does not have, or doesn't even need a description</param>
        /// <param name="_isEquipped">true, if item is currently equipped to someone</param>
        /// <param name="_soak">the value that gets subtracted from any incoming damage (except falling damage)</param>
        /// <param name="_defense">the number of setback dice any attacker gets if they target this items bearer</param>
        [JsonConstructor]
        public WearableItem(string _nameKey, uint _basePrice, uint _encumbrance, uint _rarity, ItemConditionEnum _condition,
            Dictionary<ItemQuality, uint> _qualities, List<GenreEnum> _availableGenres,string _descriptionKey, bool _isEquipped,
            Value _soak, Defense _defense)
            : base(_nameKey, _basePrice, _encumbrance, _rarity, _condition, _qualities, _availableGenres, _descriptionKey, _isEquipped)
        {
            this._soak = _soak;
            this._defense = _defense;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Wearable Item " + this._nameKey);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a new invalid wearable Item
        /// </summary>
        public WearableItem() : base()
        {
            _soak = new Value();
            _defense = new Defense();

            WfLogger.Log(this, LogLevel.DETAILED, "Created new invalid WearableItem from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given wearable Item
        /// </summary>
        /// <param name="other">if null, an invalid default wearable item is created</param>
        public WearableItem(WearableItem other) : base(other)
        {
            if (other == null) return;

            _soak = new Value(other._soak);
            _defense = new Defense(other._defense);

            WfLogger.Log(this, LogLevel.DETAILED, "Created new wearable item from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
