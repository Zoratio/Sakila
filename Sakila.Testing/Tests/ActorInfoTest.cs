using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class ActorInfoTest
    {
        [TestMethod]
        public void Test_GetActorInfo()
        {
            ActorInfo test = new ActorInfo();
            test.ActorId = 1;
            test.FirstName = "PENELOPE";
            test.LastName = "GUINESS";
            test.FilmInfo = "Film about cars";
            Assert.AreEqual(1, test.ActorId, "Wrong ID number");
            Assert.AreEqual("PENELOPE", test.FirstName, "Wrong first name");
            Assert.AreEqual("GUINESS", test.LastName, "Wrong last name");
            Assert.AreEqual("Film about cars", test.FilmInfo, "Wrong film info");
        }
    }
}
