using System;

namespace PortalLibrary
{

    public sealed class ArithmeticBase
    {
        /// <summary>
        /// Note: Additions the specified first.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Int32 Addition(Int32 First, Int32 Secound)
        {
            Int32 Result = First + Secound;
            return Result;
        }

        /// <summary>
        /// Note: Additions the specified first.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Double AdditionSecound(Double First, Double Secound)
        {
            Double Result = Math.Round(First + Secound,5, MidpointRounding.AwayFromZero);
            return Result;
        }

        /// <summary>
        /// Note: Subtractions the specified first.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Int32 Subtraction(Int32 First, Int32 Secound)
        {
            Int32 Result = First - Secound;
            return Result;
        }

        /// <summary>
        /// Note: Multiplications the specified first.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Int32 Multiplication(Int32 First, Int32 Secound)
        {
            Int32 Result = First * Secound;
            return Result;
        }

        /// <summary>
        /// Note: Divisions the specified first.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <param name="Secound">The secound.</param>
        /// <returns></returns>
        public Double Division(Double First, Double Secound)
        {
            Double Result = Math.Round(First / Secound,5, MidpointRounding.AwayFromZero);
            return Result;
        }
    }
}
