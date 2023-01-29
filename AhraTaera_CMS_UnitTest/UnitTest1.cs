using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Q4_UnittestApp;

namespace AhraTaera_CMS_UnitTest
{



    [TestClass]
    public class UnitTest1
    {
    /*    public double SumofSquareOfTwoNumbers(double num1, double num2)
        {
            double c = (num1 * num1) + (num2 * num2);
            Console.Write(c);
            return c;
        }
      */
        [TestMethod]
        public void TestMethod1()
        {
          //  Program bm = new Program();
            double num1 = 3;
            double num2 = 4;

            double res = SumofSquareOfTwoNumbers(num1, num2);//bm.SumofSquareOfTwoNumbers(num1, num2);
            Assert.AreEqual(25.0, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
        }

        [TestMethod]
        public void TestMethod3()
        {
        }

        [TestMethod]
        public void TestMethod4()
        {
        }

        [TestMethod]
        public void TestMethod5()
        {
        }
    }
}
