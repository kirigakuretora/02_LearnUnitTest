using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortalLibrary;

namespace PortalTests.Tests
{
    [TestClass]
    public class ArithmeticBaseSecUT
    {
        /// <summary>
        /// Note:  Generic  Result
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
        /// Note: Int32 + Int32 = Int32
        /// </summary>
        [TestMethod()]
        public void TestMethod4()
        {
            var TestArithmeticBaseSec = new ArithmeticBaseSec();
            Int32 First = 1;
            Int32 Secound = 2;
            Int32 Result = 3;
            IsTrue = TestArithmeticBaseSec.Addition(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Note: Double + Double = Double
        /// </summary>
        [TestMethod()]
        public void TestMethod5()
        {
            var TestArithmeticBaseSec = new ArithmeticBaseSec();
            Double First = 50.1;
            Double Secound = 70.1;
            Double Result = 120.2;
            IsTrue = TestArithmeticBaseSec.AdditionSecound(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Note: Double + Int32 = Double
        /// </summary>
        [TestMethod()]
        public void TestMethod6()
        {
            var TestArithmeticBaseSec = new ArithmeticBaseSec();
            Double First = 1.9;
            Int32 Secound = 1;
            Double Result = 2.9;
            IsTrue = TestArithmeticBaseSec.AdditionSecound(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Note: Tests the repeating decimal method.
        /// </summary>
        [TestMethod()]
        public void TestRepeatingDecimalMethod()
        {
            var TestArithmeticBaseSec = new ArithmeticBaseSec();
            Double First = 1.0;
            Double Secound = 3;
            Double Result = 0.33333; // Note:  實際值: 0.333333.....
            IsTrue = TestArithmeticBaseSec.Division(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Tests the circulating decimal method.
        /// </summary>
        [TestMethod()]
        public void TestCirculatingDecimalMethod()
        {
            var TestArithmeticBaseSec = new ArithmeticBaseSec();
            Double First = 22.0;
            Double Secound = 7.0;
            Double Result = 3.14286; // Note:  實際值: 3.142857.....
            IsTrue = TestArithmeticBaseSec.Division(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Tests the circulating decimal secound method.
        /// </summary>
        [TestMethod()]
        public void TestCirculatingDecimalSecoundMethod()
        {
            var TestArithmeticBaseSec = new ArithmeticBaseSec();
            Double First = 1.0;
            Double Secound = 6.0;
            Double Result = 0.16667; //Note:  實際值: 0.166666....
            IsTrue = TestArithmeticBaseSec.Division(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Tests the minus circulating decimalthirdd method.
        /// </summary>
        [TestMethod()]
        public void TestMinusCirculatingDecimaldMethod()
        {
            var TestArithmeticBase = new ArithmeticBase();
            Double First = 1.0;
            Double Secound = -6.0;
            Double Result = -0.16667; // Note: 實際值: -0.166666....
            IsTrue = TestArithmeticBase.Division(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Tests the minus circulating decimalthirdd method.
        /// </summary>
        [TestMethod()]
        public void TestMinusCirculatingDecimalSecounddMethod()
        {
            var TestArithmeticBase = new ArithmeticBase();
            Double First = -1.0;
            Double Secound = -6.0;
            Double Result = 0.16667; // Note: 實際值: 0.166666....
            IsTrue = TestArithmeticBase.Division(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }
    }
}
