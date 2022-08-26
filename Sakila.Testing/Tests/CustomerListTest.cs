using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class CustomerListTest
    {
        [TestMethod]
        public void Test_GetCustomerList()
        {
            CustomerList test = new CustomerList();
            test.Id = 1;
            test.Name = "Tom";
            test.Address = "GUINESS";
            test.ZipCode = "Film about cars";
            test.Phone = "h";
            test.City = "t";
            test.Country = "j";
            test.Notes = "h";
            test.Sid = 1;
            Assert.AreEqual(1, test.Id, "Wrong ID number");
            Assert.AreEqual("Tom", test.Name, "Wrong a1 name");
            Assert.AreEqual("GUINESS", test.Address, "Wrong a2 name");
            Assert.AreEqual("Film about cars", test.ZipCode, "Wrong district info");
            Assert.AreEqual("h", test.Phone, "Wrong ID");
            Assert.AreEqual("t", test.City, "Wrong code info");
            Assert.AreEqual("j", test.Country, "Wrong phone info");
            Assert.AreEqual("h", test.Notes, "Wrong phone info");
            Assert.AreEqual(1, test.Sid, "Wrong phone info");
        }
    }
}
