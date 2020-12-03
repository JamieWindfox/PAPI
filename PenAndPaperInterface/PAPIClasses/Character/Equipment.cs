using PAPI.Item;
using PAPI.Logging;
using System.Collections.Generic;

namespace PAPI.Character
{
    public class Equipment
    {
        // The armour that is equipped
        private Armour m_armour;

        // The clothes that are equipped instead, under or over the equipped armour
        private Armour m_clothing;

        // The equipped weapons, number depends on hands
        private List<Weapon> m_weapons;


        // ################################################# CTORS #################################################
        // Equipment must be equipped manually per item
        public Equipment()
        {
            m_armour = null;
            m_clothing = null;
            m_weapons = null;
            WfLogger.Log(this.GetType() + ".CTOR", LogLevel.INFO, "Constructed empty Equipment");
        }

        // ################################################# GETTER #################################################
        public uint GetSoak() { return m_armour.GetSoak() + m_clothing.GetSoak(); }
        public uint GetDefense() { return m_armour.GetDefense() + m_clothing.GetDefense(); }
        


        // ################################################# SETTER #################################################

        // Adds the given Item to Equipment if possible
        public void Equip(EquipmentItem item)
        {
            if (item is Armour && m_armour == null)
            {
                m_armour = (Armour)item;
            }
            else if(item is Armour && m_clothing == null)
            {
                m_clothing = (Armour)item;
            }
            else if((item is ITwoHandWeapon && m_weapons.Count == 0) || (item is ISingleHandWeapon && m_weapons.Count < 2))
            {
                m_weapons.Add((Weapon)item);
            }
            else
            {
                WfLogger.Log(this.GetType() + ".Equip(EquipmentItem)", LogLevel.WARNING, item.GetName() + " couln't be equipped");
                return;
            }
            WfLogger.Log(this.GetType() + ".Equip(EquipmentItem)", LogLevel.INFO, "Equipped" + item.GetName());
        }

        // Renoves the given item from Equipment if possible
        public EquipmentItem Unequip(EquipmentItem item)
        {
            EquipmentItem itemToReturn;
            if(item == m_armour)
            {
                itemToReturn = new Armour((Armour)item);
                m_armour = null;
            }
            else if(item == m_clothing)
            {
                itemToReturn = new Armour((Armour)item);
                m_clothing = null;
            }
            else if(m_weapons.Contains((Weapon)item))
            {
                itemToReturn = new Weapon((Weapon)item);
                m_weapons.Remove((Weapon)item);
            }
            else
            {
                WfLogger.Log(this.GetType() + ".Unequip(EquipmentItem)", LogLevel.WARNING, item.GetName() + " couln't be unequipped because it never has been equipped");
                return null;
            }
            WfLogger.Log(this.GetType() + ".Unequip(EquipmentItem)", LogLevel.INFO, itemToReturn.GetName() + " got unequipped");
            return itemToReturn;
        }

    }
}