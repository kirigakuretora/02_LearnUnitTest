using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public sealed class ArithmeticBase
    {
        public Int32 Arithmetic(Int32 First, Int32 Secound)
        {
            Int32 Result = First + Secound;
            return Result;
        }

        public Double ArithmeticSecound(Double First, Double Secound)
        {
            Double Result = Math.Round(First + Secound,2);
            return Result;
        }

    }
}
