using Polish.DatesInWords;
using Polish.NumbersInWords;
using System.Globalization;

namespace Polish.Dates.Tests
{
    public class BasicTests
    {
        [Theory]
        [InlineData("2000-01-01", "1 stycznia 2000")]
        [InlineData("2000-02-02", "2 lutego 2000")]
        [InlineData("2000-03-03", "3 marca 2000")]
        [InlineData("2000-04-04", "4 kwietnia 2000")]
        [InlineData("2000-05-05", "5 maja 2000")]
        [InlineData("2000-06-06", "6 czerwca 2000")]
        [InlineData("2000-07-07", "7 lipca 2000")]
        [InlineData("2000-08-08", "8 sierpnia 2000")]
        [InlineData("2000-09-09", "9 wrzeœnia 2000")]
        [InlineData("2000-10-10", "10 paŸdziernika 2000")]
        [InlineData("2000-11-11", "11 listopada 2000")]
        [InlineData("1984-12-19", "19 grudnia 1984")]
        public void ToWords_default(string dateText, string expectedWords)
        {
            var date = DateTime.Parse(dateText, CultureInfo.InvariantCulture);

            var resultWords = date.ToPolishWords();

            Assert.Equal(expectedWords, resultWords);
        }

        [Theory]
        [InlineData("2000-01-01", Case.Nominative, "pierwszy stycznia dwutysiêcznego roku")]
        [InlineData("2000-01-01", Case.Genitive, "pierwszego stycznia dwutysiêcznego roku")]
        [InlineData("2000-01-01", Case.Dative, "pierwszemu stycznia dwutysiêcznego roku")]
        [InlineData("2000-01-01", Case.Accusative, "pierwszy stycznia dwutysiêcznego roku")]
        [InlineData("2000-01-01", Case.Instrumental, "pierwszym stycznia dwutysiêcznego roku")]
        [InlineData("2000-01-01", Case.Locative, "pierwszym stycznia dwutysiêcznego roku")]
        [InlineData("2000-01-01", Case.Vocative, "pierwszy stycznia dwutysiêcznego roku")]
        public void ToWords_cases_all(string dateText, Case @case, string expectedWords)
        {
            var date = DateTime.Parse(dateText, CultureInfo.InvariantCulture);

            var resultWords = date.ToPolishWords()
                .Case(@case)
                .Write(x => $"{x.DaysCountInWords} {x.MonthInWords} {x.YearsCountInWords} {x.YearsInWords}");

            Assert.Equal(expectedWords, resultWords);
        }

        [Theory]
        [InlineData("2000-01-01", Case.Nominative, "styczeñ dwutysiêcznego roku")]
        [InlineData("2000-01-01", Case.Genitive, "stycznia dwutysiêcznego roku")]
        [InlineData("2000-01-01", Case.Dative, "styczniowi dwutysiêcznego roku")]
        [InlineData("2000-01-01", Case.Accusative, "styczeñ dwutysiêcznego roku")]
        [InlineData("2000-01-01", Case.Instrumental, "styczniem dwutysiêcznego roku")]
        [InlineData("2000-01-01", Case.Locative, "styczniu dwutysiêcznego roku")]
        [InlineData("2000-01-01", Case.Vocative, "styczniu dwutysiêcznego roku")]
        public void ToWords_cases_all_with_month_in_case(string dateText, Case @case, string expectedWords)
        {
            var date = DateTime.Parse(dateText, CultureInfo.InvariantCulture);

            var resultWords = date.ToPolishWords()
                .Case(@case)
                .UseMonthsInCase()
                .Write(x => $"{x.MonthInWords} {x.YearsCountInWords} {x.YearsInWords}");

            Assert.Equal(expectedWords, resultWords);
        }

        [Theory]
        [InlineData(DayOfWeek.Wednesday, Case.Genitive, false, "œrody")]
        [InlineData(DayOfWeek.Thursday, Case.Dative, true, "czwartkom")]
        public void ToWords_day_of_week(DayOfWeek dayOfWeek, Case @case, bool plural, string expectedWords)
        {
            var resultWords = dayOfWeek.ToPolishWords(@case, plural);

            Assert.Equal(expectedWords, resultWords);
        }
    }
}