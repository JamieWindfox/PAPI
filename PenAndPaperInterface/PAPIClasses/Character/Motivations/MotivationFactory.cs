using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character.Motivations
{
    public static class MotivationFactory
    {
        public static List<Motivation> _allMotivations = new List<Motivation>();


        /// <summary>
        /// Returns a random Motivation of the given type, if no Motivation is found, null is returned
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Motivation RandomMotivation(MotivationTypeEnum type)
        {
            Random random = new Random();
            int index = random.Next(0, _allMotivations.Count - 1);

            for(int i = index, remainingRounds = 2; i < _allMotivations.Count && remainingRounds > 0; i = i+1 % _allMotivations.Count, remainingRounds--)
            {
                if(_allMotivations[i]._type == type)
                {
                    return _allMotivations[i];
                }
            }

            return null;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public static MotivationSet RandomMotivationSet()
        {
            MotivationSet newMotivationSet = new MotivationSet();
            newMotivationSet._motivations.Clear();

            List<MotivationTypeEnum> allTypes = new List<MotivationTypeEnum>()
            { MotivationTypeEnum.STRENGTH, MotivationTypeEnum.FLAW, MotivationTypeEnum.DESIRE, MotivationTypeEnum.FEAR };

            foreach (MotivationTypeEnum type in allTypes)
            {
                newMotivationSet._motivations.Add(MotivationFactory.RandomMotivation(type));
            }

            return newMotivationSet;
        }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
