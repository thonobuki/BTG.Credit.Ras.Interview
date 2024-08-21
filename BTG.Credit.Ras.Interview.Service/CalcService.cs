using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTG.Credit.Ras.Interview.Domain
{
    public abstract class CalcService: ICalcService
    {
        private readonly IMapper _mapper;

        public CalcService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public abstract Task<decimal> Calc(CalcRequest req);
        public abstract CalcType Type { get; set; }
    }
}
