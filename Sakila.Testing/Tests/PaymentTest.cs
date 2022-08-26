using Microsoft.VisualStudio.TestTools.UnitTesting;
using SakilaBackend.Models;

namespace Sakila.Testing.Tests
{
    [TestClass]
    public class PaymentTest
    {
        [TestMethod]
        public void Test_GetPayment()
        {
            Payment test = new Payment();
            test.PaymentId = 1;
            test.CustomerId = 1;
            test.StaffId = 1;
            test.RentalId = 1;
            test.Amount = 1;
            Assert.AreEqual(1, test.PaymentId, "Wrong ID number");
            Assert.AreEqual(1, test.CustomerId, "Wrong a1 name");
            Assert.AreEqual(1, test.StaffId, "Wrong a2 name");
            Assert.AreEqual(1, test.RentalId, "Wrong ID");
            Assert.AreEqual(1, test.Amount, "Wrong phone info");
        }
    }
}
