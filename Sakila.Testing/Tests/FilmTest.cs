using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class FilmTest
    {
        [TestMethod]
        public void Test_GetFilm()
        {
            Film test = new Film();
            test.FilmId = 1;
            test.Title = "Tom";
            test.Description = "GUINESS";
            test.LanguageId = 1;
            test.RentalDuration = 1;
            test.RentalRate = 0.1m;
            test.ReplacementCost = 0.1m;
            test.Rating = "good";
            Assert.AreEqual(1, test.FilmId, "Wrong ID number");
            Assert.AreEqual("Tom", test.Title, "Wrong a1 name");
            Assert.AreEqual("GUINESS", test.Description, "Wrong a2 name");
            Assert.AreEqual(1, test.LanguageId, "Wrong ID");
            Assert.AreEqual(1, test.RentalDuration, "Wrong phone info");
            Assert.AreEqual(0.1m, test.RentalRate, "Wrong phone info");
            Assert.AreEqual(0.1m, test.ReplacementCost, "Wrong phone info");
            Assert.AreEqual("good", test.Rating, "Wrong phone info");
        }
    }
}
