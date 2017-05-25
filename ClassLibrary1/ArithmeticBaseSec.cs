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

        /// <summary>
        /// Arithmetics the specified first.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Int32 Arithmetic(Int32 First, Int32 Secound)
        {
            Result = First + Secound;
            return (Int32)Result;
        }

        /// <summary>
        /// Arithmetics the secound.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Double ArithmeticSecound(Double First, Double Secound)
        {
            Result = Math.Round(First + Secound, 5, MidpointRounding.AwayFromZero);
            return (Double)Result;
        }

        /// <summary>
        /// Arithmetics the third.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Int32 ArithmeticThird(Int32 First, Int32 Secound)
        {
            Result = First - Secound;
            return (Int32)Result;
        }

        /// <summary>
        /// Arithmetics the fourth.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Int32 ArithmeticFourth(Int32 First, Int32 Secound)
        {
            Result = First * Secound;
            return (Int32)Result;
        }

        /// <summary>
        /// Arithmetics the fifth.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Double ArithmeticFifth(Double First, Double Secound)
        {
            Result = Math.Round(First / Secound, 5, MidpointRounding.AwayFromZero);
            return (Double)Result;
        }

    }
}
