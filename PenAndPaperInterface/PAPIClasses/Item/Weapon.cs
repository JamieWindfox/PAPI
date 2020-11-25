using PAPI.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Item
{
    class Weapon : EquipmentItem
    {



        // ################################################# CTORS #################################################
        public Weapon(string name, uint basePrice, uint encumbrance, uint rarity, List<GenreEnum> genres)
            : base(name, basePrice, encumbrance, rarity, genres)
        { }

        public Weapon(Weapon other)
            : this(other.GetName(), other.GetBasePrice(), other.GetEncumbrance(), other.GetRarity(), other.GetGenres())
        { }


        // ################################################# GETTER #################################################



        // ################################################# SETTER #################################################
    }
}
