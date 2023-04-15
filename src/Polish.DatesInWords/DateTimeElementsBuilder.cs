using Polish.NumbersInWords;
using System;

namespace Polish.DatesInWords
{
    /// <summary>
    /// Builder to provide dates in words. Use fluent methods to setup words declension.
    /// </summary>
    public class DateTimeElementsBuilder
    {
        private DateTime _dateTime;
        private Case _case = NumbersInWords.Case.Nominative;
        private DatesInWordsConfiguration _configuration = new DatesInWordsConfiguration();

        private IDateTimeElements _dateTimeElements = null;

        /// <summary>
        /// Date elements with the date in words and methods to manipulate it.
        /// </summary>
        public IDateTimeElements DateTimeElements
        {
            get
            {
                if(_dateTimeElements == null)
                    _dateTimeElements = CreateDateTimeElements();

                return _dateTimeElements;
            }
        }

        public DateTimeElementsBuilder(DateTime dateTime)
        {
            _dateTime = dateTime;
        }

        private IDateTimeElements CreateDateTimeElements()
        {
            return new DateTimeElements(_dateTime, _case, _configuration);
        }

        /// <summary>
        /// Sets a case of the date. For example: Nominative (PL: mianownik), Genitive (PL: dopełniacz) etc.
        /// </summary>
        public DateTimeElementsBuilder Case(Case @case)
        {
            _case = @case;
            return this;
        }

        /// <summary>
        /// The case influence on the month. Without this setting the month is in Genitive case (PL: w dopełniaczu).
        /// </summary>
        public DateTimeElementsBuilder UseMonthsInCase()
        {
            _configuration.UseMonthsInCase = true;
            return this;
        }

        /// <summary>
        /// The case influence on the year. Without this setting the year is in Genitive case (PL: w dopełniaczu).
        /// </summary>
        public DateTimeElementsBuilder UseYearsInCase()
        {
            _configuration.UseYearsInCase = true;
            return this;
        }

        /// <summary>
        /// Returns a text created by the defined function. You can use it to create a phrase with specific declension.
        /// </summary>
        public string Write(Func<IDateTimeElements, string> writeFunc)
        {
            return writeFunc(DateTimeElements);
        }

        /// <summary>
        /// Returns date in words. Default format is like: 12 stycznia 2023. To change the format use the Write method.
        /// </summary>
        public override string ToString()
        {
            return Write(DefaultDateTimeFormat.Get);
        }

        public static implicit operator string(DateTimeElementsBuilder builder) => builder.ToString();
    }
}
