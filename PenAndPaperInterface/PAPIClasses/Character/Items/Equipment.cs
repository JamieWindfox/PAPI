using PAPI.Item;
using PAPI.Logging;
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
        public List<Weapon> _weapons { get; private set; }

        /// <summary>
        /// The readied weapon with which the character does not need an extra maneuvre to use
        /// </summary>
        public Weapon _readyWeapon { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all possible traits of the equipment
        /// _armour: if null, no armour is equipped; 
        /// _clothing: if null, no clothing is equipped; 
        /// _weapons: if null, no weapon is equipped and there can't be a readyWeapon; 
        /// _readyWeapon: if null, no weapon is ready to use, this weapon must also be in the list of _weapons, if it's not, it is automatically added here; 
        /// </summary>
        /// <param name="_armour"></param>
        /// <param name="_clothing"></param>
        /// <param name="_weapons"></param>
        /// <param name="_readyWeapon"></param>
        [JsonConstructor]
        public Equipment(Armour _armour, Clothing _clothing, List<Weapon> _weapons, Weapon _readyWeapon)
        {
            this._armour = _armour;
            this._clothing = _clothing;

            if(_weapons == null || _weapons.Count == 0)
            {
                this._weapons = new List<Weapon>();
                _readyWeapon = null;
            }
            else
            {
                this._weapons = _weapons;
            }

            this._readyWeapon = _readyWeapon;

            if(this._readyWeapon != null && !this._weapons.Contains(this._readyWeapon))
            {
                this._weapons.Add(this._readyWeapon);
            }

            WfLogger.Log(this, LogLevel.DETAILED, "Created new Equipment");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

    }
}