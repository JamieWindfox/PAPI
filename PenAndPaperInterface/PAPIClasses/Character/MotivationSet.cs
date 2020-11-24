using System.Collections.Generic;

namespace PAPI.Character
{
    public class MotivationSet
    {
        private readonly Dictionary<MotivationTypeEnum, Motivation> m_motivations;


        // ################################################# CTOR #################################################
        public MotivationSet(Dictionary<MotivationTypeEnum, Motivation> motivations)
        {
            m_motivations = motivations;
        }

        public MotivationSet() : this(new Dictionary<MotivationTypeEnum, Motivation>()) { }



        // ################################################# GETTER #################################################
        public Motivation GetMotivation(MotivationTypeEnum type) { return m_motivations[type]; }



        // ################################################# SETTER #################################################


    }
}