using PAPI.Exception;
using PAPI.Logging;
using System.Collections.Generic;

namespace PAPI.Character
{
    public class MotivationSet
    {
        public Dictionary<MotivationTypeEnum, Motivation> motivations { get; private set; }


        // ################################################# CTOR #################################################
        public MotivationSet(Dictionary<MotivationTypeEnum, Motivation> motivations)
        {
            this.motivations = motivations;
            if(motivations.Count != 4)
            {
                string errMsg = "Each Unique Character must have exactly 4 Motivations, but " + motivations.Count + " were given.";
                WfLogger.Log(this, LogLevel.ERROR, errMsg);
                throw new PAPIException(errMsg);

            }
        }

        public MotivationSet()
        {
            motivations = new Dictionary<MotivationTypeEnum, Motivation>();
            motivations.Add(MotivationTypeEnum.STRENGTH, null);
            motivations.Add(MotivationTypeEnum.FLAW, null);
            motivations.Add(MotivationTypeEnum.DESIRE, null);
            motivations.Add(MotivationTypeEnum.FEAR, null);
        }



        // ################################################# GETTER #################################################
        public Motivation GetMotivation(MotivationTypeEnum type) { return motivations[type]; }

        public override string ToString()
        {
            return "Strength: " + motivations[MotivationTypeEnum.STRENGTH]
                + ", Flaw: " + motivations[MotivationTypeEnum.FLAW]
                + ", Desire: " + motivations[MotivationTypeEnum.DESIRE]
                + ", Fear: " + motivations[MotivationTypeEnum.FEAR];
        }


        // ################################################# SETTER #################################################

        public void AddMotivation(Motivation motivation)
        {
            if(motivations.ContainsKey(motivation.GetMotivationType()))
            {
                motivations[motivation.GetMotivationType()] = motivation;
            }
            else
            {
                motivations.Add(motivation.GetMotivationType(), motivation);
            }
        }

    }
}