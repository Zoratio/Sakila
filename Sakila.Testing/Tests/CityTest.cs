using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class CityTest
    {
        [TestMethod]
        public void Test_GetCity()
        {
            City test = new City();
            test.CityId = 1;
            test.City1 = "PENELOPE";
            test.CountryId = 1;
            Assert.AreEqual(1, test.CityId, "Wrong ID number");
            Assert.AreEqual("PENELOPE", test.City1, "Wrong a1 name");
            Assert.AreEqual(1, test.CountryId, "Wrong a2 name");
        }
    }
}
