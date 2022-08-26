using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class RentalTest
    {
        [TestMethod]
        public void Test_GetRental()
        {
            Rental test = new Rental();
            test.RentalId = 1;
            test.InventoryId = 1;
            test.CustomerId = 1;
            test.StaffId = 1;
            Assert.AreEqual(1, test.RentalId, "Wrong ID number");
            Assert.AreEqual(1, test.InventoryId, "Wrong a1 name");
            Assert.AreEqual(1, test.CustomerId, "Wrong a2 name");
            Assert.AreEqual(1, test.StaffId, "Wrong ID");
        }
    }
}
