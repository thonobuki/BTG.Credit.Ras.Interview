using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTG.Credit.Ras.Interview.Domain
{
    public class CalcRequest
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public CalcType Type { get; set; }
    }
}
