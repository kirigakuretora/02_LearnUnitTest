using System;
using System.Collections;
using System.Collections.Generic;

namespace PortalLibrary
{
    public class ArithmeticBaseThr
    {

        private Int32 Result { get; set; }
        public ArithmeticBaseThr()
        {
            Result = 0;
        }

        /// <summary>
        /// Dictionaries the sigma.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <returns></returns>
        public Int32 DictionarySigma(Dictionary<Int32,Int32> First)
        {          
            foreach (var Sum in First)
            {
                Result+=Sum.Value;
            }
            return Result;
        }

        /// <summary>
        /// Sortedlist the sigma.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <returns></returns>
        public Int32 SortedListSigma(SortedList<Int32, Int32> First)
        {
            foreach (var Sum in First)
            {
                Result += Sum.Value;
            }
            return Result;
        }

        /// <summary>
        /// Arrarylist the  sigma.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <returns></returns>
        public Int32 ArraryListSigma(Int32[] First)
        {
            foreach (var Sum in First)
            {
                Result += Sum;
            }
            return Result;
        }

        /// <summary>
        /// Lists the sigma.
        /// </summary>
        /// <param name="First">The first.</param>
        /// <returns></returns>
        public Int32 ListSigma(List<Int32>First)
        {
            foreach (var Sum in First)
            {
                Result += Sum;
            }
            return Result;
        }

    }
}
