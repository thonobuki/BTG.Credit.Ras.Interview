using BTG.Credit.Ras.Interview.Domain.DataList;
using Microsoft.AspNetCore.Mvc;

namespace BTG.Credit.Ras.Interview.Application.Controllers
{
    [Route("[controller]")]
    public class DataListController : Controller
    {
        private readonly IDataListService _dataListService;

        public DataListController(IDataListService dataListService)
        {
            _dataListService = dataListService;
        }

        [HttpGet("list_that_contains_customers_with_birthdate")]
        public IActionResult ListThatContainsCustomersWithBirthdate([FromQuery] DateTime refDate)
        {
            return Ok(_dataListService.ListThatContainsCustomersWithBirthDate(refDate));
        }
    }
}
