using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void Test_GetCustomer()
        {
            Customer test = new Customer();
            test.CustomerId = 1;
            test.StoreId = 1;
            test.FirstName = "GUINESS";
            test.LastName = "Film about cars";
            test.Email = "h";
            test.AddressId = 1;
            test.Active = true;
            Assert.AreEqual(1, test.CustomerId, "Wrong ID number");
            Assert.AreEqual(1, test.StoreId, "Wrong a1 name");
            Assert.AreEqual("GUINESS", test.FirstName, "Wrong a2 name");
            Assert.AreEqual("Film about cars", test.LastName, "Wrong district info");
            Assert.AreEqual("h", test.Email, "Wrong ID");
            Assert.AreEqual(1, test.AddressId, "Wrong code info");
            Assert.AreEqual(true, test.Active, "Wrong phone info");
        }
    }
}
