using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Controllers;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class AControllerTest
    {
        [TestMethod]
        public void Test_GetAController()
        {
            ActorController test = new ActorController();

            var result1 = test.GetActors();
            Assert.IsNotNull(result1);

            var result2 = test.GetActorsByName();
            Assert.IsNotNull(result2);

            var result3 = test.GetActor(1);
            Assert.IsNotNull(result3);

            var result4 = test.GetActorId("PENELOPE","GUINESS");
            Assert.IsNotNull(result4);

            //var result5 = test.PutActorName("THORA", "TEMPLE", "c", "d");
            //Assert.IsNotNull(result5);

            var result6 = test.GetAllActorFilms();
            Assert.IsNotNull(result6);

            var result7 = test.GetActorFilms(1);
            Assert.IsNotNull(result7);
        }
    }
}
