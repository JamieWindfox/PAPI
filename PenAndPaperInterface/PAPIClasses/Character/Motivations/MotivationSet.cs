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
        /// <param name="_motivations">if null or not exactly 4, an empty set is created</param>
        [JsonConstructor]
        public MotivationSet(List<Motivation> _motivations)
        {
            this._motivations = (_motivations == null || _motivations.Count != 4) ? new List<Motivation>() : _motivations;
            WfLogger.Log(this, LogLevel.DETAILED, "Created new MotiavationSet");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// creates a random set of motivations
        /// </summary>
        public MotivationSet() : this(new List<Motivation>())
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new invalid MotiavationSet as default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given MotivationSet
        /// </summary>
        /// <param name="other">if null, an invalid empty motivation set is created</param>
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