using BTG.Credit.Ras.Interview.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BTG.Credit.Ras.Interview.Application.Controllers
{
    [Route("[controller]")]
    public class CalendarController : Controller
    {
        private readonly ICalendarService _calendarService;

        public CalendarController(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        [HttpPost("is_weekend")]
        public IActionResult IsWeekend([FromBody] DateTime referenceDate)
        {
            return Ok(_calendarService.IsWeekend(referenceDate));
        }
    }
}
