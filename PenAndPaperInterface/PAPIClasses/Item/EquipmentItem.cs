using PAPI.Settings;
using System.Collections.Generic;

namespace PAPI.Item
{
    public class EquipmentItem : PAPIItem
    {

        public EquipmentItem(string name, uint basePrice, uint encumbrance, uint rarity, List<GenreEnum> genres) 
            : base(name, basePrice, encumbrance, rarity, genres)
        {

        }
    }
}