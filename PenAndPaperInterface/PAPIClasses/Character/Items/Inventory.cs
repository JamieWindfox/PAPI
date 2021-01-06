using PAPI.Item;
using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PAPI.Character
{
    public class Inventory
    {
        public Dictionary<PAPIItem, uint> _inventory { get; private set; }

        public Backpack _backpack { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// A JSON COnstructor must contain all traits of an inventory
        /// </summary>
        /// <param name="_inventory">if null, inventory is empty</param>
        /// <param name="_backpack">if null, there is no backpack which could decrease the enumbrance of the inventory</param>
        [JsonConstructor]
        public Inventory(Dictionary<PAPIItem, uint> _inventory, Backpack _backpack)
        {
            this._inventory = (_inventory == null) ? new Dictionary<PAPIItem, uint>() : _inventory;
            this._backpack = _backpack;

            WfLogger.Log(this, LogLevel.DETAILED, "Creates new Inventory");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates an empty inventory with no backpack
        /// </summary>
        public Inventory() : this(null, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Creates new Inventory from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public Inventory(Inventory other) : this()
        {
            if (other == null) return;

            _backpack = (other._backpack == null) ? null : new Backpack(other._backpack);
            _inventory = (other._inventory == null) ? new Dictionary<PAPIItem, uint>() : other._inventory;
            WfLogger.Log(this, LogLevel.DETAILED, "Creates new Inventory from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Adds one unit of the given Item to the inventory
        /// </summary>
        /// <param name="item"></param>
        public void Add(PAPIItem item)
        {
            if (_inventory.ContainsKey(item))
            {
                _inventory[item]++;
            }
            else
            {
                _inventory.Add(item, 1);
            }
            WfLogger.Log(this.GetType() + ".Add(Item)", LogLevel.INFO, "Added one " + item._name + " to inventory (new quantity: " 
                + _inventory[item] + ")");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Removes one unit of the given Item from the inventory and returns the item if successful;
        /// If there is no item with the given key in the inventory, null is returned and nothing is removed
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public PAPIItem Take(PAPIItem item)
        {
            if (_inventory.ContainsKey(item) && _inventory[item] > 0)
            {
                _inventory[item]--;
            }
            else
            {
                WfLogger.Log(this, LogLevel.DETAILED, "Removed nothing from the inventory");
                return null;
            }
            WfLogger.Log(this, LogLevel.DETAILED, "Removed one " + item._name + " from inventory (new quantity: "
               + _inventory[item] + ")");
            return item;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Returns the total encumbrance of all items in the inventory, minus the capacity of the used backpack
        /// </summary>
        /// <returns></returns>
        public uint GetEncumbrance()
        {
            int weight = 0;

            foreach(KeyValuePair<PAPIItem, uint> item in _inventory)
            {
                weight += (int)(item.Key._encumbrance * item.Value);
            }
            weight -= (int)_backpack._capacity;
            if(weight < 0)
            {
                weight = 0;
            }
            return (uint)Math.Abs(weight);
        }


    }
}