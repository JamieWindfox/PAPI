using PAPI.Character.Skill;
using PAPI.Logging;
using PAPI.Settings;
using PAPIClasses.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Item
{
    public class Weapon : EquipmentItem
    {
        public WeaponHandTypeEnum _handType { get; private set; }
        public SkillEnum _requiredSkill { get; private set; }
        public uint _damage { get; private set; }
        public uint _criticalRating { get; private set; }
        public RangeEnum _range { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits of an EquipmentItem
        /// </summary>
        /// <param name="_name">if null or empty, the item is not valid</param>
        /// <param name="_basePrice">the price before any modifiers are adjusted</param>
        /// <param name="_encumbrance">the weight of the item</param>
        /// <param name="_rarity"> a value from 0 to 5, otherwise the item is not valid</param>
        /// <param name="_condition">if null, the item is in perfect condition</param>
        /// <param name="_qualities">if null or empty, the item has no special qualities</param>
        /// <param name="_availableGenres">if null or empty, the item is available in all settings</param>
        /// <param name="_descriptionKey">if null or empty, the item does not have, or doesn't even need a description</param>
        /// <param name="_isEquipped">true, if the item is currently equipped on someone/something</param>
        /// <param name="_handType"></param>
        [JsonConstructor]
        public Weapon(string _name, uint _basePrice, uint _encumbrance, uint _rarity, ItemConditionEnum _condition, Dictionary<ItemQuality, uint> _qualities, 
            List<GenreEnum> _availableGenres, string _descriptionKey, bool _isEquipped, WeaponHandTypeEnum _handType, SkillEnum _requiredSkill, uint _damage,
            uint _critialRating, RangeEnum _range)
            : base(_name, _basePrice, _encumbrance, _rarity, _condition, _qualities, _availableGenres, _descriptionKey, _isEquipped)
        {
            this._handType = _handType;
            this._requiredSkill = _requiredSkill;
            this._damage = _damage;
            this._criticalRating = _criticalRating;
            this._range = _range;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Weapon " + this._nameKey);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates new invalid weapon
        /// </summary>
        public Weapon() : base()
        {
            _handType = WeaponHandTypeEnum.SINGLE;
            _requiredSkill = SkillEnum.CUSTOM;
            _damage = 0;
            _criticalRating = 0;
            _range = RangeEnum.ENGAGED;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new invalid Weapon from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given Weapon
        /// </summary>
        /// <param name="other">if null, an invalid weapon item is created</param>
        public Weapon(Weapon other) : base(other)
        {
            if (other == null) return;

            _handType = other._handType;
            _requiredSkill = other._requiredSkill;
            _damage = other._damage;
            _criticalRating = other._criticalRating;
            _range = other._range;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Weapon from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------

    }
}
