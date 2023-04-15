using Polish.DatesInWords;
using Polish.DatesInWords.Words;
using Polish.DatesInWords.Words.Months;
using Polish.NumbersInWords;
using System;

namespace Polish.DatesInWords
{
    internal class DateTimeElements : IDateTimeElements
    {
        public DateTime DateTime { get; private set; }

        public string YearsCountInWords => _yearBuilder.ToString();

        public string YearsInWords => _yearBuilder.Write(x => x.GetPhraseAfterNumber(new Year()));

        public string MonthInWords => GetMonthInWords();

        public string DaysCountInWords => _dayBuilder.ToString();

        public string DaysInWords => _dayBuilder.Write(x => x.GetPhraseAfterNumber(new Day()));

        public string DayOfWeekInWords => DateTime.DayOfWeek.ToPolishWords(_case);

        private Case _case;
        private IDatesInWordsConfiguration _configuration;

        private NumberElementsBuilder _yearBuilder;
        private NumberElementsBuilder _dayBuilder;

        public DateTimeElements(DateTime dateTime, Case @case, IDatesInWordsConfiguration configuration)
        {
            DateTime = dateTime;
            _case = @case;
            _configuration = configuration;

            _yearBuilder = dateTime.Year.ToPolishWords()
                .Case((configuration.UseYearsInCase ? _case : Case.Genitive).ToNumericCase())
                .Ordinal();

            _dayBuilder = dateTime.Day.ToPolishWords()
                .Case(@case.ToNumericCase())
                .Ordinal();
        }

        private string GetMonthInWords()
        {
            var @case = _configuration.UseMonthsInCase ? _case : Case.Genitive;
            return Month.GetMonth(DateTime.Month).GetWord(@case.ToNumericCase());
        }
    }
}
