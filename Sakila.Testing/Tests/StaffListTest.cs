using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class StaffListTest
    {
        [TestMethod]
        public void Test_GetStaffList()
        {
            StaffList test = new StaffList();
            test.Id = 1;
            test.Name = "Tom";
            test.Address = "GUINESS";
            test.ZipCode = "a";
            test.Phone = "a";
            test.City = "a";
            test.Country = "a";
            test.Sid = 1;
            Assert.AreEqual(1, test.Id, "Wrong ID number");
            Assert.AreEqual("Tom", test.Name, "Wrong a1 name");
            Assert.AreEqual("GUINESS", test.Address, "Wrong a2 name");
            Assert.AreEqual("a", test.ZipCode, "Wrong ID");
            Assert.AreEqual("a", test.Phone, "Wrong phone info");
            Assert.AreEqual("a", test.City, "Wrong phone info");
            Assert.AreEqual("a", test.Country, "Wrong phone info");
            Assert.AreEqual(1, test.Sid, "Wrong phone info");
        }
    }
}
