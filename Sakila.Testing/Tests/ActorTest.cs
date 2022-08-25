using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void Test_GetActor()
        {
            Actor testActor = new Actor();
            testActor.ActorId = 1;
            testActor.FirstName = "PENELOPE";
            testActor.LastName = "GUINESS";
            Assert.AreEqual(1, testActor.ActorId, "Wrong ID number");
            Assert.AreEqual("PENELOPE", testActor.FirstName, "Wrong first name");
            Assert.AreEqual("GUINESS", testActor.LastName, "Wrong last name");
        }
    }
}
