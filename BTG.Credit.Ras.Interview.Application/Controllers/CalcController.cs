using AutoMapper;
using BTG.Credit.Ras.Interview.Application.Model;
using BTG.Credit.Ras.Interview.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTG.Credit.Ras.Interview.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private readonly IEnumerable<ICalcService> _calcServices;
        private readonly IMapper _mapper;

        public CalcController(IEnumerable<ICalcService> calcServices, IMapper mapper)
        {
            _calcServices = calcServices;
            _mapper = mapper;
        }

        [HttpPost]
        public async IAsyncEnumerable<decimal> Calc(IList<CalcRequestModel> calcsReq)
        {

            foreach (var calc in calcsReq)
            {
                var req = _mapper.Map<CalcRequest>(calc);
                var service = _calcServices.Where(c => c.Type == req.Type).First();
                yield return await service.Calc(req);
            }
        }
    }
}
