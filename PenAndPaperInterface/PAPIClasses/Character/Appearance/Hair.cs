using PAPI.DataTypes;
using PAPI.Logging;
using PAPIClasses;
using System.Text.Json.Serialization;

namespace PAPI.Character.Appearance
{
    public class Hair
    {
        public HairStyleEnum _style { get; private set; }

        public HairLengthEnum _length { get; private set; }
        public ColorEnum _color { get; private set; }
        public string _description { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The json ctor must contain all traits of a hair object
        /// </summary>
        /// <param name="_style">what style is the hair worn? if bald, length is set automatically to none</param>
        /// <param name="_length">how long is the hair?</param>
        /// <param name="_color">even if bald, the color the hair would be is in here</param>
        /// <param name="_description">if null, the description is empty</param>
        [JsonConstructor]
        public Hair(HairStyleEnum _style, HairLengthEnum _length, ColorEnum _color, string _description)
        {
            this._style = _style;
            this._length = (_style == HairStyleEnum.BALD) ? HairLengthEnum.NONE : _length;
            this._color = _color;
            this._description = (_description == null) ? "" : _description;

            WfLogger.Log(this, LogLevel.DETAILED, "Created Hair (" + this._style + ", " + this._length + ", " + this._color + ")");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        public Hair() : this(HairStyleEnum.BALD, HairLengthEnum.NONE, ColorEnum.BROWN, null)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new Hair from default CTOR");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Change the hair style to the given value
        /// </summary>
        /// <param name="newHairStyle">all BodyTypeEnum values are valid</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool ChangeStyle(HairStyleEnum newHairStyle)
        {
            if (newHairStyle == _style)
            {
                WfLogger.Log(this, LogLevel.INFO, "Didn't change hair style, because it already was " + _style);
                return false;
            }
            _style = newHairStyle;
            WfLogger.Log(this, LogLevel.DEBUG, "Changed hair style to " + _style);
            return true;
        }
        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Change the hair style to the given value
        /// </summary>
        /// <param name="newHairStyle">all BodyTypeEnum values are valid</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool ChangeLength(HairLengthEnum newHairLength)
        {
            if (newHairLength == _length)
            {
                WfLogger.Log(this, LogLevel.INFO, "Didn't change hair length, because it already was " + _length);
                return false;
            }
            _length = newHairLength;
            WfLogger.Log(this, LogLevel.DEBUG, "Changed hair length to " + _length);
            return true;
        }


        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Change the hair color to the given value
        /// </summary>
        /// <param name="newHairColor">all BodyTypeEnum values are valid</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool ChangeColor(ColorEnum newHairColor)
        {
            if (newHairColor == _color)
            {
                WfLogger.Log(this, LogLevel.INFO, "Didn't change hair color, because it already was " + _color);
                return false;
            }
            _color = newHairColor;
            WfLogger.Log(this, LogLevel.DEBUG, "Changed hair color to " + _color);
            return true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Change the hair description to the given value
        /// </summary>
        /// <param name="newDescription">if null or empty, the description is empty (if there was one before, it gets cleared)</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool ChangeDescription(string newDescription)
        {
            if (newDescription != null && newDescription == _description)
            {
                WfLogger.Log(this, LogLevel.INFO, "Didn't change hair description, because it already was " + _description);
                return false;
            }
            _description = (newDescription == null) ? "" : newDescription;
            WfLogger.Log(this, LogLevel.DEBUG, "Changed hair description to " + _description);
            return true;
        }

        // --------------------------------------------------------------------------------------------------------------------------------
    }
}
