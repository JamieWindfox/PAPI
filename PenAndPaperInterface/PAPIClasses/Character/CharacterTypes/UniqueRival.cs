using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character
{
    public class UniqueRival : Rival, IUniqueCharacter
    {

        // ################################################# CTOR #################################################

        // ################################################# GETTER #################################################

        // ################################################# SETTER #################################################
        public MotivationSet GetMotivations()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public void SetMotivation(Motivation motivation)
        {
            throw new NotImplementedException();
        }

        public void SetMotivationSet(MotivationSet motivationsSet)
        {
            throw new NotImplementedException();
        }
    }
}
