namespace Logitop.Models
{
    public class DateTimeRange
    {
        public DateTime StartDate;
        public DateTime EndDate;

        public DateTimeRange(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public TimeSpan GetDuration() => EndDate - StartDate;
    }
}
