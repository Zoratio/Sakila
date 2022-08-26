using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Controllers;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class RControllerTest
    {
        [TestMethod]
        public void Test_GetRController()
        {
            RentalController test = new RentalController();

            var result1 = test.GetGenreRevenues();
            Assert.IsNotNull(result1);
        }
    }
}
