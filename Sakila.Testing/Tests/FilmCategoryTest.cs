using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class FilmCategoryTest
    {
        [TestMethod]
        public void Test_GetFilmCategory()
        {
            FilmCategory test = new FilmCategory();
            test.FilmId = 1;
            test.CategoryId = 1;
            test.Category = new Category();
            test.Film = new Film();
            Assert.AreEqual(1, test.FilmId, "Wrong ID number");
            Assert.AreEqual(1, test.CategoryId, "Wrong ID number");
            Assert.IsNotNull(test.Category);
            Assert.IsNotNull(test.Film);
        }
    }
}
