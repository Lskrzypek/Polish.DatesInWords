using Polish.DatesInWords.Words.DaysOfWeek;
using Polish.NumbersInWords;
using System;

namespace Polish.DatesInWords
{
    /// <summary>
    /// Extends <see cref="DateTime"/> and <see cref="DayOfWeek"/> to get Polish words.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Returns the date in words in Polish. For example: 2021-05-23 is conveted to "23 maja 2021". Use fluent methods to set up date declension.
        /// </summary>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static DateTimeElementsBuilder ToPolishWords(this DateTime dateTime)
        {
            return DoToWords(dateTime);
        }

        /// <summary>
        /// Returns day of week name in Polish.
        /// </summary>
        /// <param name="case">Case. For example Nominative, Genitive... (PL: Przypadek. Na przykład mianownik, dopełniacz...)</param>
        /// <param name="isPlural"></param>
        /// <returns>Returns fluent builder, where you can setup date declension.</returns>
        public static string ToPolishWords(this DayOfWeek dayOfWeek, Case @case = Case.Nominative, bool isPlural = false)
        {
            return DayOfWeekWords.GetDayInWeek(dayOfWeek).GetWord(@case, isPlural);
        }

        private static DateTimeElementsBuilder DoToWords(DateTime dateTime)
        {
            return new DateTimeElementsBuilder(dateTime);
        }
    }
}
