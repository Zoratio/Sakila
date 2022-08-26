using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void Test_GetAddress()
        {
            Address test = new Address();
            test.AddressId = 1;
            test.Address1 = "PENELOPE";
            test.Address2 = "GUINESS";
            test.District = "Film about cars";
            test.CityId = 1;
            test.PostalCode = "123";
            test.Phone = "123";
            Assert.AreEqual(1, test.AddressId, "Wrong ID number");
            Assert.AreEqual("PENELOPE", test.Address1, "Wrong a1 name");
            Assert.AreEqual("GUINESS", test.Address2, "Wrong a2 name");
            Assert.AreEqual("Film about cars", test.District, "Wrong district info");
            Assert.AreEqual(1, test.CityId, "Wrong ID");
            Assert.AreEqual("123", test.PostalCode, "Wrong code info");
            Assert.AreEqual("123", test.Phone, "Wrong phone info");
        }
    }
}
