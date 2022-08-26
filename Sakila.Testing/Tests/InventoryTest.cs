using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class InventoryTest
    {
        [TestMethod]
        public void Test_GetInventory()
        {
            Inventory test = new Inventory();
            test.InventoryId = 1;
            test.FilmId = 1;
            test.StoreId = 1;
            Assert.AreEqual(1, test.InventoryId, "Wrong ID number");
            Assert.AreEqual(1, test.FilmId, "Wrong a1 name");
            Assert.AreEqual(1, test.StoreId, "Wrong a2 name");
        }
    }
}
