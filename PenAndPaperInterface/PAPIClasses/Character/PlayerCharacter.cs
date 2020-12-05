using System;
using System.Collections.Generic;
using System.Text;

namespace PAPI.Character
{
    public class PlayerCharacter : PAPICharacter, IUniqueCharacter
    {
        public MotivationSet motivationSet { get; private set; }
        public string name { get; private set; }



        // ################################################# CTOR #################################################



        public PlayerCharacter(string name)
        {
            this.name = name;
            motivationSet = new MotivationSet();
        }


        public PlayerCharacter() : this("NOT_VALID") { }


        // ################################################# SETTER #################################################
        public void SetMotivation(Motivation motivation)
        {
            motivationSet.AddMotivation(motivation);
        }

        public void SetMotivationSet(MotivationSet motivationsSet)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return name + ", Motivations: " + motivationSet.ToString();
        }


    }
}
