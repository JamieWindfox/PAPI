using PAPI.Item;
using PAPI.Logging;
using PAPIClasses;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PAPI.Character
{
    public class Equipment
    {
        /// <summary>
        /// The armour that is equipped
        /// </summary>
        public Armour _armour { get; private set; }

        /// <summary>
        /// The clothes that are equipped instead, under or over the equipped armour
        /// </summary>
        public Clothing _clothing { get; private set; }

        /// <summary>
        /// The equipped weapon(s), number depends on hands, antlers teeth, etc. of the wielding character
        /// </summary>
        public Weapon _mainWeapon { get; private set; }

        /// <summary>
        /// If the main weapon is light waponm This can be a second light weapon, a shield or even a bomb
        /// </summary>
        public PAPIItem _secondaryItem { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all traits of the equipment
        /// </summary>
        /// <param name="_armour">if null, no armour is equipped</param>
        /// <param name="_clothing">if null, no clothing is equipped</param>
        /// <param name="_mainWeapon">if null, no weapon is equipped</param>
        /// <param name="_secondaryItem">if null, there is no secondary item equipped</param>
        [JsonConstructor]
        public Equipment(Armour _armour, Clothing _clothing, Weapon _mainWeapon, PAPIItem _secondaryItem)
        {
            this._armour = _armour;
            this._clothing = _clothing;

            this._mainWeapon = _mainWeapon;

            this._secondaryItem = (this._mainWeapon == null || this._mainWeapon._handType == WeaponHandTypeEnum.SINGLE) ? _secondaryItem : null;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Equipment");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// creates an empty equipment
        /// </summary>
        public Equipment() : this(null, null, null, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Equipment from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given Equipment
        /// </summary>
        /// <param name="other">if null, a default equipment is created</param>
        public Equipment(Equipment other) : this()
        {
            _armour = new Armour(other._armour);
            _clothing = new Clothing(other._clothing);
            _mainWeapon = new Weapon(other._mainWeapon);
            
            if(other._secondaryItem is Weapon)
            {
                _secondaryItem = new Weapon((Weapon)other._secondaryItem);
            }
            // TODO: Additional types

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Equipment from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}