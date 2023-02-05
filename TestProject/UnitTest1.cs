using Microsoft.VisualStudio.TestTools.UnitTesting;
using AheraTaera_CMS;


namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_Age70_Auckland_WeekendDelivery()
        {
            Discount bm = new Discount();
            int age = 70;
            string city = "Auckland";
            bool weekenddelivery = true;

            int res = bm.GetDiscount(age, city, weekenddelivery);
            Assert.AreEqual(13, res);
        }
        
        [TestMethod]
        public void TestMethod2_Age25_Christchurch()
        {
            Discount bm = new Discount();
            int age = 25;
            string city = "Christchurch";
            bool weekenddelivery = false;

            int res = bm.GetDiscount(age, city, weekenddelivery);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestMethod3_Age78_Hamiton()
        {
            Discount bm = new Discount();
            int age = 78;
            string city = "Hamilton";
            bool weekenddelivery = false;

            int res = bm.GetDiscount(age, city, weekenddelivery);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestMethod4_HomeDelivery()
        {
            Discount bm = new Discount();
            bool homedelivery = true;

            float res = bm.GetShipmentCharge(homedelivery);
            Assert.AreEqual(10.0, res);
        }

        [TestMethod]
        public void TestMethod5_ShopDelivery()
        {
            Discount bm = new Discount();
            bool homedelivery = false;

            float res = bm.GetShipmentCharge(homedelivery);
            Assert.AreEqual(0.0, res);
        }
    }
}
