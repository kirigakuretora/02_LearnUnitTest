using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class ArithmeticBaseThr
    {

        private Int32 Result { get; set; }
        public ArithmeticBaseThr()
        {
            Result = 0;
        }

        /// <summary>
        /// Arithmetics the specified first.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <returns></returns>
        public Int32 Arithmetic(Dictionary<Int32,Int32> First)
        {          
            foreach (var Sum in First)
            {
                Result+=Sum.Value;
            }
            return Result;
        }

        /// <summary>
        /// Arithmetics the secound.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <returns></returns>
        public Int32 ArithmeticSecound(SortedList<Int32, Int32> First)
        {
            foreach (var Sum in First)
            {
                Result += Sum.Value;
            }
            return Result;
        }

        /// <summary>
        /// Arithmetics the third.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <returns></returns>
        public Int32 ArithmeticThird(Int32[] First)
        {
            foreach (var Sum in First)
            {
                Result += Sum;
            }
            return Result;
        }

        /// <summary>
        /// Arithmetics the fourth.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <returns></returns>
        public Int32 ArithmeticFourth(List<Int32>First)
        {
            foreach (var Sum in First)
            {
                Result += Sum;
            }
            return Result;
        }

    }
}
