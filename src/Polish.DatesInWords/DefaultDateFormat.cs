namespace Polish.DatesInWords
{
    internal class DefaultDateFormat : IDateFormat
    {
        public string Get(IDateTimeElements elements)
        {
            return $"{elements.DateTime.Day} {elements.MonthInWords} {elements.DateTime.Year}";
        }
    }
}
