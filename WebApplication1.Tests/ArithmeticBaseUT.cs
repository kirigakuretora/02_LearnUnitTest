using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace WebApplication1.Tests
{
    [TestClass]
    public class ArithmeticBaseUT
    {
        /// <summary>
        /// 建構 Generic
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
        /// Int32 + Int32 = Int32
        /// </summary>
        [TestMethod()]
        public void TestMethod1()
        {
            var TestArithmeticBase = new ArithmeticBase();
            Int32 First = 1;
            Int32 Secound = 2;
            Int32 Result = 3;
            IsTrue = TestArithmeticBase.Arithmetic(First, Secound);
            Assert.AreEqual(Result, IsTrue);

        }


        /// <summary>
        /// Double + Double = Double
        /// </summary>
        [TestMethod()]
        public void TestMethod2()
        {
            var TestArithmeticBase = new ArithmeticBase();
            Double First = 50.1;
            Double Secound = 70.1;
            Double Result = 120.2;
            IsTrue = TestArithmeticBase.ArithmeticSecound(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Double + Int32 = Double
        /// </summary>
        [TestMethod()]
        public void TestMethod3()
        {
            var TestArithmeticBase = new ArithmeticBase();
            Double First = 1.9;
            Int32 Secound = 1;
            Double Result = 2.9;
            IsTrue = TestArithmeticBase.ArithmeticSecound(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }
    }

}
