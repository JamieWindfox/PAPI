using PAPI.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PAPI.Settings
{
    public class BookResource
    {
        /// <summary>
        /// Rule book an page of it where the resource can be found
        /// </summary>
        public RuleBookEnum _ruleBook { get; private set; }
        public uint _page { get; private set; }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// The JSON Constructor must contain all traits of the book resource
        /// </summary>
        /// <param name="_ruleBook">if No_RULE_BOOK, resource is invalid</param>
        /// <param name="_page"> if 0, resource in invalid</param>
        [JsonConstructor]
        public BookResource(RuleBookEnum _ruleBook, uint _page)
        {
            if(_ruleBook == RuleBookEnum.NO_RULE_BOOK || _page == 0)
            {
                _ruleBook = RuleBookEnum.NO_RULE_BOOK;
                _page = 0;
            }
            this._ruleBook = _ruleBook;
            this._page = _page;

            WfLogger.Log(this, LogLevel.DETAILED, "Book Resource created: " + this._ruleBook.ToString() + ", p. " + this._page);
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates an invalid book resource for custom assets
        /// </summary>
        public BookResource() : this(RuleBookEnum.NO_RULE_BOOK, 0)
        {
            WfLogger.Log(this, LogLevel.DETAILED, "Created new book resource from default");
        }

        // --------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Creates a copy of the given resource
        /// </summary>
        /// <param name="other">if null, an invalid resource is created</param>
        public BookResource(BookResource other) : this()
        {
            if (other == null) return;

            _ruleBook = other._ruleBook;
            _page = other._page;

            WfLogger.Log(this, LogLevel.DETAILED, "Created new book resource from another");
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------------------------------------------------

    }
}
