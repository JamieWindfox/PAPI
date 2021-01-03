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
        /// </summary>
        /// <param name="_motivations">if null or not exactly 4, random motivaitons get generated</param>
        [JsonConstructor]
        public MotivationSet(List<Motivation> _motivations)
        {
            this._motivations = (_motivations == null || _motivations.Count != 4) ? MotivationFactory.RandomMotivationSet()._motivations : _motivations;
            WfLogger.Log(this, LogLevel.DETAILED, "Created new MotiavationSet");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public MotivationSet() : this(new List<Motivation>())
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new random MotiavationSet as default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        public MotivationSet(MotivationSet other) : this()
        {
            if (other == null) return;

            _motivations = new List<Motivation>(other._motivations);
            WfLogger.Log(this, LogLevel.DETAILED, "Created new MotiavationSet from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------
    }
}