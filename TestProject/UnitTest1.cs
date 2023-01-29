using Microsoft.VisualStudio.TestTools.UnitTesting;
using AheraTaera_CMS;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Utility bm = new Utility();
            int age = 70;
            string city = "Auckland";
            bool weekenddelivery = true;

            int res = bm.GetDiscount(age, city, weekenddelivery);
            Assert.AreEqual(13, res);
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            Utility bm = new Utility();
            int age = 25;
            string city = "Christchurch";
            bool weekenddelivery = false;

            int res = bm.GetDiscount(age, city, weekenddelivery);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Utility bm = new Utility();
            int age = 78;
            string city = "Christchurch";
            bool weekenddelivery = false;

            int res = bm.GetDiscount(age, city, weekenddelivery);
            Assert.AreEqual(10, res);
        }
    }
}
