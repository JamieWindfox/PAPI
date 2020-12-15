using PAPI.Settings;
using System.Collections.Generic;

namespace PAPI.Item
{
    public class EquipmentItem : PAPIItem
    {

        /// <summary>
        /// The JSON Constructor must contain all possible traits of an EquipmentItem
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_basePrice"></param>
        /// <param name="_encumbrance"></param>
        /// <param name="_rarity"></param>
        /// <param name="_condition"></param>
        /// <param name="_qualities"></param>
        /// <param name="_availableGenres"></param>
        /// <param name="_description"></param>
        public EquipmentItem(string _name, uint _basePrice, uint _encumbrance, uint _rarity, ItemConditionEnum _condition, 
            Dictionary<ItemQuality, uint> _qualities, List<GenreEnum> _availableGenres, Dictionary<Language, string> _description) 
            : base(_name, _basePrice, _encumbrance, _rarity, _condition, _qualities, _availableGenres, _description)
        {

        }
    }
}