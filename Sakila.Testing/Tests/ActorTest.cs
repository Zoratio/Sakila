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
            Actor test = new Actor();
            test.ActorId = 1;
            test.FirstName = "PENELOPE";
            test.LastName = "GUINESS";
            Assert.AreEqual(1, test.ActorId, "Wrong ID number");
            Assert.AreEqual("PENELOPE", test.FirstName, "Wrong first name");
            Assert.AreEqual("GUINESS", test.LastName, "Wrong last name");
        }
    }
}
