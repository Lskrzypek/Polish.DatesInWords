namespace Polish.DatesInWords
{
    internal static class DefaultDateTimeFormat
    {
        public static string Get(IDateTimeElements elements)
        {
            return $"{elements.DateTime.Day} {elements.MonthInWords} {elements.DateTime.Year}";
        }
    }
}
