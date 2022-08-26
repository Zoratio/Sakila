using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class FilmActorTest
    {
        [TestMethod]
        public void Test_GetFilmActor()
        {
            FilmActor test = new FilmActor();
            test.ActorId = 1;
            test.FilmId = 1;
            test.Actor = new Actor();
            test.Film = new Film();
            Assert.AreEqual(1, test.ActorId, "Wrong ID number");
            Assert.AreEqual(1, test.FilmId, "Wrong ID number");
            Assert.IsNotNull(test.Actor);
            Assert.IsNotNull(test.Film);
        }
    }
}
