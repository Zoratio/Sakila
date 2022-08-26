using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class FilmTextTest
    {
        [TestMethod]
        public void Test_GetFilmText()
        {
            FilmText test = new FilmText();
            test.FilmId = 1;
            test.Title = "Tom";
            test.Description = "GUINESS";           
            Assert.AreEqual(1, test.FilmId, "Wrong ID number");
            Assert.AreEqual("Tom", test.Title, "Wrong a1 name");
            Assert.AreEqual("GUINESS", test.Description, "Wrong a2 name");
        }
    }
}
