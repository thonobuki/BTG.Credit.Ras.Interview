using BTG.Credit.Ras.Interview.Domain;

namespace BTG.Credit.Ras.Interview.Service
{
    public class CalendarService : ICalendarService
    {
        public bool IsWeekend(DateTime refDate)
        {
            return (refDate.DayOfWeek == DayOfWeek.Sunday || refDate.DayOfWeek == DayOfWeek.Saturday);
        }
    }
}
