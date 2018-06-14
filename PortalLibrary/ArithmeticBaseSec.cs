using System;

namespace PortalLibrary
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
        public Int32 Addition(Int32 First, Int32 Secound)
        {
            Result = First + Secound;
            return (Int32)Result;
        }

        /// <summary>
        /// Additions the specified first.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Double AdditionSecound(Double First, Double Secound)
        {
            Result = Math.Round(First + Secound, 5, MidpointRounding.AwayFromZero);
            return (Double)Result;
        }

        /// <summary>
        /// Subtractions the specified first.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Int32 Subtraction(Int32 First, Int32 Secound)
        {
            Result = First - Secound;
            return (Int32)Result;
        }

        /// <summary>
        /// Multiplications the specified first.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Int32 Multiplication(Int32 First, Int32 Secound)
        {
            Result = First * Secound;
            return (Int32)Result;
        }

        /// <summary>
        /// Divisions the specified first.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Double Division(Double First, Double Secound)
        {
            Result = Math.Round(First / Secound, 5, MidpointRounding.AwayFromZero);
            return (Double)Result;
        }

    }
}
