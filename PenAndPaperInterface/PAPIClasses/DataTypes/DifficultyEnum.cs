

namespace PAPI.DataTypes
{
    /// <summary>
    /// Defines the different difficulties
    /// </summary>
    public enum DifficultyEnum
    {
        /// <summary>
        /// Needs no dice, just storytelling
        /// </summary>
        NONE,

        /// <summary>
        /// 1 purple difficulty die
        /// </summary>
        EASY,

        /// <summary>
        /// 2 purple difficulty dice
        /// </summary>
        AVERAGE,

        /// <summary>
        /// 3 purple difficulty dice
        /// </summary>
        HARD,

        /// <summary>
        /// 4 purple difficulty dice
        /// </summary>
        DAUNTING,

        /// <summary>
        /// 5 purple difficulty dice
        /// </summary>
        FORMIDABLE,

        /// <summary>
        /// A story point must be spent in order to try; Then 5 purple difficulty dice
        /// </summary>
        IMPOSSIBLE
    }
}
