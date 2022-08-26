using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class FilmListTest
    {
        [TestMethod]
        public void Test_GetFilmList()
        {
            FilmList test = new FilmList();
            test.Fid = (short?)1;
            test.Title = "Tom";
            test.Description = "GUINESS";
            test.Category = "a";
            test.Price = 0.1m;
            test.Length = (short?)1;
            test.Rating = "good";
            test.Actors = "Taylor";
            Assert.AreEqual((short?)1, test.Fid, "Wrong ID number");
            Assert.AreEqual("Tom", test.Title, "Wrong a1 name");
            Assert.AreEqual("GUINESS", test.Description, "Wrong a2 name");
            Assert.AreEqual("a", test.Category, "Wrong ID");
            Assert.AreEqual(0.1m, test.Price, "Wrong phone info");
            Assert.AreEqual((short?)1, test.Length, "Wrong phone info");
            Assert.AreEqual("good", test.Rating, "Wrong phone info");
            Assert.AreEqual("Taylor", test.Actors, "Wrong phone info");
        }
    }
}
