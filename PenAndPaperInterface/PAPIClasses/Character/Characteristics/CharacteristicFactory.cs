using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character.Characteristics
{
    public static class CharacteristicFactory
    {
        /// <summary>
        /// Generates all different Characteristics in a list 
        /// </summary>
        /// <returns>List of all Characteristics, all with base value 1 and no Modification</returns>
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
        /// </summary>
        /// <param name="sumOfValues">Must be between 6 (where every value = 1) and 30 (where every value is maxed out),
        /// If an invalid value is given, a completely random set is returned</param>
        /// <returns>A Random CharaccteristicSet with the given number as sum of all trained characteristics</returns>
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

            // Subtract the base value
            sumOfValues -= 6;

            while(sumOfValues > 0)
            {
                int index = rand.Next(6);

                if(!list[index].IsMaximized())
                {
                    list[index].Training();
                    sumOfValues--;
                }
            }
            WfLogger.Log("CharacteristicFactory.RandomCharacteristicSet(int)", LogLevel.DETAILED, "Create a random CharacteristicSet where the sum of all values is " + sumOfValues);

            return new CharacteristicSet(list);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

    }
}
