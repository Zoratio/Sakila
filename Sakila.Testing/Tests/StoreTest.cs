using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class StoreTest
    {
        [TestMethod]
        public void Test_GetStore()
        {
            Store test = new Store();
            test.StoreId = 1;
            test.ManagerStaffId = 1;
            test.AddressId = 1;
            Assert.AreEqual(1, test.StoreId, "Wrong ID number");
            Assert.AreEqual(1, test.ManagerStaffId, "Wrong a1 name");
            Assert.AreEqual(1, test.AddressId, "Wrong a2 name");
        }
    }
}
