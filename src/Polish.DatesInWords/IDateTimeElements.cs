using System;

namespace Polish.DatesInWords
{
    /// <summary>
    /// Date elements with the date in words and methods to manipulate it.
    /// </summary>
    public interface IDateTimeElements
    {
        /// <summary>
        /// Original date
        /// </summary>
        DateTime DateTime { get; }

        /// <summary>
        /// Years count in words. For example 2023 is: dwa tysiące dwudziestego trzeciego
        /// </summary>
        string YearsCountInWords { get; }

        /// <summary>
        /// Year word. For exemple: roku
        /// </summary>
        string YearsInWords { get; }

        /// <summary>
        /// Month name in Polish word. For example: stycznia
        /// </summary>
        string MonthInWords { get; }

        /// <summary>
        /// Days count in words. For example 22 is: dwudziesty drugi
        /// </summary>
        string DaysCountInWords { get; }

        /// <summary>
        /// Day word. For example: dzień
        /// </summary>
        string DaysInWords { get; }

        /// <summary>
        /// Day of week in Polish words. For example: czwartek
        /// </summary>
        string DayOfWeekInWords { get; }
    }
}