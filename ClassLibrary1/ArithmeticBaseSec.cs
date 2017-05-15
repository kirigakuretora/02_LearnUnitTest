using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public sealed class ArithmeticBaseSec
    {
        /// <summary>
        ///  Generic Result
        /// </summary>
        private object Result;
        private void SetResult<T>(T tResult) 
        {
            Result = tResult;
        }

        public T GetResult<T>()
        {
            return (T)Result;
        }

        public Int32 Arithmetic(Int32 First, Int32 Secound)
        {
            Result = First + Secound;
            return (Int32)Result;
        }

        public Double ArithmeticSecound(Double First, Double Secound)
        {
            Result = Math.Round(First + Secound, 2);
            return (Double)Result;
        }

        public Int32 ArithmeticThird(Int32 First, Int32 Secound)
        {
            Result = First - Secound;
            return (Int32)Result;
        }

        public Int32 ArithmeticFourth(Int32 First, Int32 Secound)
        {
            Result = First * Secound;
            return (Int32)Result;
        }

        public Int32 ArithmeticFifth(Int32 First, Int32 Secound)
        {
            Result = First / Secound;
            return (Int32)Result;
        }

    }
}
