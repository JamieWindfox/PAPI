using PAPI.Item;
using PAPI.Logging;
using System.Collections.Generic;

namespace PAPI.Character
{
    public class Inventory
    {
        // A dictionary of all items in inventory (with number of count)
        private Dictionary<PAPIItem, uint> m_inventory;

        // The total encumbrance of the inventory e.g. the 'backpack'
        private uint m_encumbrance;

        // ################################################# CTORS #################################################
        // A new Inventory is always empty, items must be added amanually
        public Inventory()
        {
            m_inventory = new Dictionary<PAPIItem, uint>();
            m_encumbrance = 0;
        }

        // ################################################# GETTER #################################################
        public uint GetEncumbrance() { return m_encumbrance; }


        // ################################################# SETTER #################################################
        public void Add(PAPIItem item)
        {
            if (m_inventory.ContainsKey(item))
            {
                m_inventory[item]++;
            }
            else
            {
                m_inventory.Add(item, 1);
            }
            m_encumbrance += item.GetEncumbrance();
            WfLogger.Log(this.GetType() + ".Add(Item)", LogLevel.INFO, "Added one " + item.GetName() + " to inventory (new quantity: " 
                + m_inventory[item] + ")");
        }

        public PAPIItem Take(PAPIItem item)
        {
            if (m_inventory.ContainsKey(item) && m_inventory[item] > 0)
            {
                m_inventory[item]--;
                m_encumbrance -= item.GetEncumbrance();
            }
            else
            {
                return null;
            }
            WfLogger.Log(this.GetType() + ".Take(Item)", LogLevel.INFO, "Removed one " + item.GetName() + " from inventory (new quantity: "
               + m_inventory[item] + ")");
            return item;
        }
    }
}