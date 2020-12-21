using PAPI.Exception;
using PAPI.Logging;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PAPI.Character.Motivations
{
    public class MotivationSet
    {
        public List<Motivation> _motivations { get; private set; }


        // --------------------------------------------------------------------------------------------------------------------------------
        
        /// <summary>
        /// The JSON Constructor must contain all traits of a motivation set;
        /// _motivataions: if null, random motivaitons get generated, if there aren't exactly one for each type, the missing ones are assigned randomly,
        /// and from the one that are too much, the first one gets assigned
        /// </summary>
        /// <param name="_motivations"></param>
        [JsonConstructor]
        public MotivationSet(List<Motivation> _motivations)
        {
            this._motivations = new List<Motivation>();

            if(_motivations == null)
            {
                _motivations = new List<Motivation>();
            }

            List<MotivationTypeEnum> missingMotivations = new List<MotivationTypeEnum>() 
            { MotivationTypeEnum.STRENGTH, MotivationTypeEnum.FLAW, MotivationTypeEnum.DESIRE, MotivationTypeEnum.FEAR };

            // Add first existing motivation of each type to this
            foreach(Motivation motivation in _motivations)
            {
                if (missingMotivations.Contains(motivation._type))
                {
                    this._motivations.Add(motivation);
                    missingMotivations.Remove(motivation._type);
                }
            }


            // Fill out the motivationSet blanks with random motivations of the missing types
            foreach(MotivationTypeEnum type in missingMotivations)
            {
                this._motivations.Add(MotivationFactory.RandomMotivation(type));
            }
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        

    }
}