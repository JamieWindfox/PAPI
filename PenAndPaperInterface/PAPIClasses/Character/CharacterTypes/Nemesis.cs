using System;


namespace PAPI.Character.CharacterTypes
{
    public class Nemesis : Rival
    {
        // The name of an unique character
        private readonly string m_name;


        // ################################################# CTOR #################################################


        // ################################################# GETTER #################################################

        public string GetName() { return m_name; }



        // ################################################# SETTER #################################################
        public void SetMotivation(MotivationTypeEnum type, Motivation motivation)
        {
            throw new NotImplementedException();
        }

        public void SetMotivationSet(MotivationSet motivationsSet)
        {
            throw new NotImplementedException();
        }

    }
}
