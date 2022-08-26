using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class SalesByStoreTest
    {
        [TestMethod]
        public void Test_GetSalesByStore()
        {
            SalesByStore test = new SalesByStore();
            test.Store = "a";
            test.Manager = "a";
            test.TotalSales = 1;
            Assert.AreEqual("a", test.Store, "Wrong ID number");
            Assert.AreEqual("a", test.Manager, "Wrong ID number");
            Assert.AreEqual(1, test.TotalSales, "Wrong a1 name");
        }
    }
}
