using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Controllers;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class FControllerTest
    {
        [TestMethod]
        public void Test_GetFController()
        {
            FilmController test = new FilmController();

            var result1 = test.GetFilm("DINO");
            Assert.IsNotNull(result1);
        }
    }
}
