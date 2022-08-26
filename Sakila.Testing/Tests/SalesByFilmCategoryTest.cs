using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class SalesByFilmCategoryTest
    {
        [TestMethod]
        public void Test_GetSalesByFilmCategory()
        {
            SalesByFilmCategory test = new SalesByFilmCategory();
            test.Category = "a";
            test.TotalSales = 1;
            Assert.AreEqual("a", test.Category, "Wrong ID number");
            Assert.AreEqual(1, test.TotalSales, "Wrong a1 name");
        }
    }
}
