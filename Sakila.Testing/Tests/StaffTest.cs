using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class StaffTest
    {
        [TestMethod]
        public void Test_GetStaff()
        {
            staff test = new staff();
            test.StaffId = 1;
            test.FirstName = "Tom";
            test.LastName = "GUINESS";
            test.AddressId = 1;
            test.Email = "a";
            test.StoreId = 1;
            test.Active = true;
            test.Username = "good";
            test.Password = "good";
            Assert.AreEqual(1, test.StaffId, "Wrong ID number");
            Assert.AreEqual("Tom", test.FirstName, "Wrong a1 name");
            Assert.AreEqual("GUINESS", test.LastName, "Wrong a2 name");
            Assert.AreEqual(1, test.AddressId, "Wrong ID");
            Assert.AreEqual("a", test.Email, "Wrong phone info");
            Assert.AreEqual(1, test.StoreId, "Wrong phone info");
            Assert.AreEqual(true, test.Active, "Wrong phone info");
            Assert.AreEqual("good", test.Username, "Wrong phone info");
            Assert.AreEqual("good", test.Password, "Wrong phone info");
        }
    }
}
