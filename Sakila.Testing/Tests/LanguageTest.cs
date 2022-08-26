using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class LanguageTest
    {
        [TestMethod]
        public void Test_GetLanguage()
        {
            Language test = new Language();
            test.LanguageId = 1;
            test.Name = "a";
            Assert.AreEqual(1, test.LanguageId, "Wrong ID number");
            Assert.AreEqual("a", test.Name, "Wrong a1 name");
        }
    }
}
