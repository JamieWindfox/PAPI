using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character.Characteristics
{
    public static class CharacteristicHandler
    {
        public static List<Characteristic> _characteristicsList { get; private set; }


        /// <summary>
        /// Returns a List of all Characteristics, all with base value 1 and no Modification
        /// </summary>
        /// <returns></returns>
        public static List<Characteristic> GetBaseCharacteristics()
        {
            return new List<Characteristic>()
            {
                new Characteristic(CharacteristicEnum.BRAWN, 1, null),
                new Characteristic(CharacteristicEnum.AGILITY, 1, null),
                new Characteristic(CharacteristicEnum.INTELLECT, 1, null),
                new Characteristic(CharacteristicEnum.CUNNING, 1, null),
                new Characteristic(CharacteristicEnum.WILLPOWER, 1, null),
                new Characteristic(CharacteristicEnum.PRESENCE, 1, null)
            };
        }
    }
}
