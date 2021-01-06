using PAPI.Logging;
using System;

namespace PAPI.Settings
{
    public static class EnumConverter
    {
        /// <summary>
        /// Converts the given enum value to a string, looking similar to "EnumType_VALUE"
        /// </summary>
        /// <param name="enumValue">the enum, which is going to be rturned as a string value</param>
        /// <returns>the stirng representation of the given enum value</returns>
        public static string Convert(Enum enumValue)
        {
            string result = enumValue.GetType().ToString() + "_" + enumValue.ToString();

            WfLogger.Log("EnumConverter", LogLevel.DEBUG, "Converted " + enumValue + " to string " + result);

            return result;
        }
    }
}
