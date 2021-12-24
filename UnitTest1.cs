using Microsoft.VisualStudio.TestTools.UnitTesting;
using _053551_POMALEYKO_LAB5;
namespace ShopTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool check = true;
            bool temp = true;
            Catalog catalog = new Catalog();
            temp = catalog.ShowProducts();
            Assert.AreEqual(check, temp);


        }
    }
}