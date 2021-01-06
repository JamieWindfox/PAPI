using PAPI.Logging;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Item
{
    public class PAPIItem
    {
        public string _nameKey { get; private set; }
        public uint _basePrice { get; private set; }

        /// <summary>
        /// The weight of the item in a custom measure (Examples: 0 = One pack of medicine, 1 = a dagger, 2 = a short sword, ...)
        /// </summary>
        public uint _encumbrance { get; private set; }

        /// <summary>
        /// The rarity of the item (scale 0 = very common, 5 = only on specific blackmarkets)
        /// </summary>
        public uint _rarity { get; private set; }

        /// <summary>
        /// In what condition is the item? Broken? not damaged at all?
        /// </summary>
        public ItemConditionEnum _condition { get; private set; }

        /// <summary>
        /// A Dictionay of all (special) qualities of the item with their rank (if any)
        /// </summary>
        public Dictionary<ItemQuality, uint> _qualities { get; private set; }

        /// <summary>
        /// A List of the genres in which this item is available
        /// </summary>
        public List<GenreEnum> _availableGenres { get; private set; }

        /// <summary>
        /// A dictionary with the description of the item in different languages
        /// </summary>
        public string _descriptionKey { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all traits of an item
        /// </summary>
        /// <param name="_nameKey">if null or empty, the item is not valid</param>
        /// <param name="_basePrice">the price before any modifiers are adjusted</param>
        /// <param name="_encumbrance">the weight of the item</param>
        /// <param name="_rarity"> a value from 0 to 5, if higher it gets set to 5</param>
        /// <param name="_condition">if null, the item is in perfect condition</param>
        /// <param name="_qualities">if null or empty, the item has no special qualities</param>
        /// <param name="_availableGenres">if null or empty, the item is available in all settings</param>
        /// <param name="_descriptionKey">if null or empty, the item does not have, or doesn't even need a description</param>
        [JsonConstructor]
        public PAPIItem(string _nameKey, uint _basePrice, uint _encumbrance, uint _rarity, ItemConditionEnum _condition, Dictionary<ItemQuality, uint> _qualities, 
            List<GenreEnum> _availableGenres, string _descriptionKey)
        {
            this._nameKey = (_nameKey == null || _nameKey == "") ? "INVALID_ITEM" : _nameKey;
            this._basePrice = _basePrice;
            this._encumbrance = _encumbrance;
            this._rarity = (_rarity > 5) ? 5 : _rarity;
            this._condition = _condition;
            this._qualities = (_qualities == null) ? new Dictionary<ItemQuality, uint>() : _qualities;
            this._availableGenres = (_availableGenres == null || _availableGenres.Count == 0) ?
                new List<GenreEnum>(GameSettings.GetAllGenres()) : _availableGenres;
            this._descriptionKey = (_descriptionKey == null) ? "INVALIID_DESCRIPTION" : _descriptionKey;

            WfLogger.Log(this, LogLevel.DETAILED, "PAPIItem '" + this._nameKey + "' was created");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates an invlaid default item with no value
        /// </summary>
        public PAPIItem() : this(null, 0, 0, 0, ItemConditionEnum.BROKEN_BEYOND_REPAIR, null, null, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new invalid default PAPIItem");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of given PAPIItem
        /// </summary>
        /// <param name="other">if null, an invalid default PAPIItem is created</param>
        public PAPIItem(PAPIItem other) : this()
        {
            if (other == null) return;

            _nameKey = other._nameKey;
            _basePrice = other._basePrice;
            _encumbrance = other._encumbrance;
            _rarity = other._rarity;
            _condition = other._condition;
            _qualities = new Dictionary<ItemQuality, uint>(other._qualities);
            _availableGenres = new List<GenreEnum>(other._availableGenres);
            _descriptionKey = other._descriptionKey;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new PAPIItem from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
