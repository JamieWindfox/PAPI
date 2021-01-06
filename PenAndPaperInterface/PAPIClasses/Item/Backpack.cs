using PAPI.Logging;
using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Item
{
    public class Backpack : PAPIItem
    {
        /// <summary>
        /// The capacity of encumbrance, that get increased if the backpack is worn
        /// </summary>
        public uint _capacity { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible trait sof a backpack
        /// _name: if null or empty, the item is not valid, 
        /// _rarity: a value from 0 to 5, otherwise the item is not valid
        /// _condition: if null, the item is in perfect condition
        /// _qualities: if null or empty, the item has no special qualities
        /// _availableGenres: if null or empty, the item is available in all settings
        /// _description: if null or empty, the item does not have, or doesn't even need a description
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_basePrice"></param>
        /// <param name="_encumbrance"></param>
        /// <param name="_rarity"></param>
        /// <param name="_condition"></param>
        /// <param name="_qualities"></param>
        /// <param name="_availableGenres"></param>
        /// <param name="_descriptionKey"></param>
        /// <param name="_capacity"></param>
        [JsonConstructor]
        public Backpack(string _name, uint _basePrice, uint _encumbrance, uint _rarity, ItemConditionEnum _condition, Dictionary<ItemQuality, uint> _qualities, 
            List<GenreEnum> _availableGenres, string _descriptionKey, uint _capacity) :
            base(_name, _basePrice, _encumbrance, _rarity, _condition, _qualities, _availableGenres, _descriptionKey)
        {
            this._capacity = _capacity;

            WfLogger.Log(this, LogLevel.DETAILED, "A new backpack with capacity " + this._capacity + " was created");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a new invalid backpack wth capacity = encumbrance
        /// </summary>
        public Backpack() : base()
        {
            _capacity = _encumbrance;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new invalid backpack from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given backpack
        /// </summary>
        /// <param name="other">if null, an invalid default backpack is created</param>
        public Backpack(Backpack other) : base(other)
        {
            if (other == null) return;

            _capacity = other._capacity;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new backpack from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
