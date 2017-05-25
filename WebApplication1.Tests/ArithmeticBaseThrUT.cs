using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace WebApplication1.Tests
{
    [TestClass]
    public class ArithmeticBaseThrUT
    {
        /// <summary>
        /// Generic Result
        /// </summary>
        private Object IsTrue;
        private void SetIsTrue<T>(T tIsTrue)
        {
            IsTrue = tIsTrue;
        }

        public T getResult<T>()
        {
            return (T)IsTrue;
        }

        /// <summary>
        /// Tests the dictionary method.
        /// </summary>
        [TestMethod()]
        public void TestDictionaryMethod()
        {
            var TestArithmeticBaseThr = new ArithmeticBaseThr();
            var First = new Dictionary<Int32, Int32>
            {
                { 0, 1 },
                { 1, 2 },
                { 2, 3 },
                { 3, 4 },
                { 4, 5 }
            };
            Int32 Result = 15;
            IsTrue = TestArithmeticBaseThr.Arithmetic(First);
            Assert.AreEqual(Result, IsTrue);
        }


        /// <summary>
        /// Tests the dictionary decima method.
        /// </summary>
        [TestMethod()]
        public void TestDictionaryDecimaMethod()
        {
            var TestArithmeticBaseThr = new ArithmeticBaseThr();
            var First = new Dictionary<Int32, Int32>
            {
                { 0, -1 },
                { 1, 2 },
                { 2, -3 },
                { 3, 4 },
                { 4, -5 }
            };
            Int32 Result = -3;
            IsTrue = TestArithmeticBaseThr.Arithmetic(First);
            Assert.AreEqual(Result, IsTrue);

        }

        /// <summary>
        /// Tests the arrary list method.
        /// </summary>
        [TestMethod()]
        public void TestArraryListMethod()
        {
            var TestArithmeticBaseThr = new ArithmeticBaseThr();
            var First = new Int32[] { 1, 2, 3, 4, 5 };
            Int32 Result = 15;
            IsTrue = TestArithmeticBaseThr.ArithmeticThird(First);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Tests the arrary list decima method.
        /// </summary>
        [TestMethod()]
        public void TestArraryListDecimaMethod()
        {
            var TestArithmeticBaseThr = new ArithmeticBaseThr();
            var First = new Int32[] { -1, 2, -3, 4,-5 };
            Int32 Result = -3;
            IsTrue = TestArithmeticBaseThr.ArithmeticThird(First);
            Assert.AreEqual(Result, IsTrue);
        }
    }
}
