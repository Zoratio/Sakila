using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class CategoryTest
    {
        [TestMethod]
        public void Test_GetCategoryInfo()
        {
            Category test = new Category();
            test.CategoryId = 1;
            test.Name = "PENELOPE";
            Assert.AreEqual(1, test.CategoryId, "Wrong ID number");
            Assert.AreEqual("PENELOPE", test.Name, "Wrong name");
        }
    }
}
