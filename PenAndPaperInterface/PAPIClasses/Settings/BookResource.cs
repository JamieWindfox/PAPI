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
        public RuleBook _ruleBook { get; private set; }
        public uint _page { get; private set; }

        /// <summary>
        /// The JSON Constructor must contain all poiisble trait sof the book resource
        /// _ruleBook: if No_RULE_BOOK, resource is invalid
        /// _page: if 0, resource in invalid
        /// </summary>
        /// <param name="_ruleBook"></param>
        /// <param name="_page"></param>
        [JsonConstructor]
        public BookResource(RuleBook _ruleBook, uint _page)
        {
            if(_ruleBook == RuleBook.NO_RULE_BOOK || _page == 0)
            {
                _ruleBook = RuleBook.NO_RULE_BOOK;
                _page = 0;
                return;
            }
            this._ruleBook = _ruleBook;
            this._page = _page;

            WfLogger.Log(this, LogLevel.DETAILED, "Book Resource created: " + this._ruleBook.ToString()
                + ", p. " + this._page);
        }

    }
}
