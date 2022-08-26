using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class CountryTest
    {
        [TestMethod]
        public void Test_GetCountry()
        {
            Country test = new Country();
            test.CountryId = 1;
            test.Country1 = "PENELOPE";
            Assert.AreEqual(1, test.CountryId, "Wrong ID number");
            Assert.AreEqual("PENELOPE", test.Country1, "Wrong a1 name");
        }
    }
}
