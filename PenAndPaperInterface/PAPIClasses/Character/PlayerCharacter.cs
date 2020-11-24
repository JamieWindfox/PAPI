using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character
{
    public class PlayerCharacter : PAPICharacter, IUniqueCharacter
    {
        private MotivationSet m_motivations;
        private string m_name;


         // ################################################# CTOR #################################################



        // ################################################# GETTER #################################################
        public MotivationSet GetMotivations() { return m_motivations; }

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
