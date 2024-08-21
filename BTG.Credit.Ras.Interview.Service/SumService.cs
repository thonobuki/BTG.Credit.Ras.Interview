using AutoMapper;
using BTG.Credit.Ras.Interview.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTG.Credit.Ras.Interview.Service
{
    public class SumService : CalcService
    {
        public SumService(IMapper mapper) : base(mapper)
        {
        }

        public override CalcType Type { get; set; } = CalcType.Sum;

        public override Task<decimal> Calc(CalcRequest req)
        {
            return Task.Run<decimal>(() => req.Num1 + req.Num2);
        }
    }
}
