using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace WebApplication1.Tests
{
    [TestClass]
    public class ArithmeticBaseSecUT
    {
        /// <summary>
        ///  建構 Generic
        /// </summary>
        private Object IsTrue;
        public void SetIsTrue<T>(T tIsTrue)
        {
            IsTrue = tIsTrue;
        }

        public T getResult<T>()
        {
            return (T)IsTrue;
        }


        /// <summary>
        /// Generic
        /// </summary>
        [TestMethod()]
        public void TestMethod4()
        {
            var TestArithmeticBaseSec = new ArithmeticBaseSec();
            Int32 First = 1;
            Int32 Secound = 2;
            Int32 Result = 3;
            IsTrue = TestArithmeticBaseSec.Arithmetic(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Generic Double + Double = Double
        /// </summary>
        [TestMethod()]
        public void TestMethod5()
        {
            var TestArithmeticBaseSec = new ArithmeticBaseSec();
            Double First = 50.1;
            Double Secound = 70.1;
            Double Result = 120.2;
            IsTrue = TestArithmeticBaseSec.ArithmeticSecound(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Generic  Double + Int32 = Double
        /// </summary>
        [TestMethod()]
        public void TestMethod6()
        {
            var TestArithmeticBase = new ArithmeticBaseSec();
            Double First = 1.9;
            Int32 Secound = 1;
            Double Result = 2.9;
            IsTrue = TestArithmeticBase.ArithmeticSecound(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }
    }
}
