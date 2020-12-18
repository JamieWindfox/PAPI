using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character.Characteristics
{
    public static class CharacteristicFactory
    {
        public static List<Characteristic> _characteristicsList { get; private set; } = BaseCharacteristicList();

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Returns a List of all Characteristics, all with base value 1 and no Modification
        /// </summary>
        /// <returns></returns>
        public static List<Characteristic> BaseCharacteristicList()
        {
            WfLogger.Log("CharacteristicFactory.BaseCharacteristicList()", LogLevel.DETAILED, "Create a List of Characteristics where all of them have value 1");
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

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Returns a random characterisitc set where the sum of all characiteristic values summed up must be the given value
        /// The value must be between 6 (where every value = 1) and 36 (where every value is maxed out); 
        /// If an invalid value is given, a completely random set is returned
        /// </summary>
        /// <param name="sumOfValues"></param>
        /// <returns></returns>
        public static CharacteristicSet RandomCharacteristicSet(int sumOfValues)
        {
            List<Characteristic> list = new List<Characteristic>(BaseCharacteristicList());
            var rand = new Random();
            int min = (int)Characteristic.MIN_VALUE * 6;
            int max = (int)Characteristic.MAX_VALUE * 6;

            if (sumOfValues < min || sumOfValues > max)
            {
                sumOfValues = Math.Abs(rand.Next(min, max));
                WfLogger.Log("CharacteristicFactory.RandomCharacteristicSet(int)", LogLevel.DETAILED, "sumOfValues was invalid, new random value = " + sumOfValues);
            }            

            while(sumOfValues > 0)
            {
                for(int i = 0; i < list.Count; ++i)
                {
                    if(rand.Next((int)Characteristic.MAX_VALUE) == i)
                    {
                        list[i].Training();
                    }
                }
            }
            WfLogger.Log("CharacteristicFactory.RandomCharacteristicSet(int)", LogLevel.DETAILED, "Create a random CharacteristicSet where the sum of all values is " + sumOfValues);

            return new CharacteristicSet(list);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

    }
}
