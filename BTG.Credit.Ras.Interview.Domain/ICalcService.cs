using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTG.Credit.Ras.Interview.Domain
{
    public interface ICalcService
    {
        Task<decimal> Calc(CalcRequest req);
        CalcType Type { get; set; }
    }
}
