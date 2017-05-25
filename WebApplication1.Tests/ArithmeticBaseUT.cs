using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace WebApplication1.Tests
{
    [TestClass]
    public class ArithmeticBaseUT
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

        /// <summary>
        /// Tests the repeating decimal method.
        /// </summary>
        [TestMethod()]
        public void TestRepeatingDecimalMethod()
        {
            var TestArithmeticBase = new ArithmeticBase();
            Double First = 1.0;
            Double Secound = 3;
            Double Result = 0.33333; // 實際值: 0.333333.....
            IsTrue = TestArithmeticBase.ArithmeticFifth(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Tests the circulating decimal method.
        /// </summary>
        [TestMethod()]
        public void TestCirculatingDecimalMethod()
        {
            var TestArithmeticBase = new ArithmeticBase();
            Double First = 22.0;
            Double Secound = 7.0;
            Double Result = 3.14286; // 實際值: 3.142857.....
            IsTrue = TestArithmeticBase.ArithmeticFifth(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }

        /// <summary>
        /// Tests the circulating decimal secound method.
        /// </summary>
        [TestMethod()]
        public void TestCirculatingDecimalSecoundMethod()
        {
            var TestArithmeticBase = new ArithmeticBase();
            Double First = 1.0;
            Double Secound = 6.0;
            Double Result = 0.16667; // 實際值: 0.166666....
            IsTrue = TestArithmeticBase.ArithmeticFifth(First, Secound);
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
            Double Result = -0.16667; // 實際值: -0.166666....
            IsTrue = TestArithmeticBase.ArithmeticFifth(First, Secound);
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
            Double Result = 0.16667; // 實際值: 0.166666....
            IsTrue = TestArithmeticBase.ArithmeticFifth(First, Secound);
            Assert.AreEqual(Result, IsTrue);
        }
    }

}
