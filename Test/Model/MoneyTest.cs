using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.Model;

namespace Test.Model
{
    /// <summary>
    /// The Money payment method test
    /// </summary>
    [TestClass]
    public class MoneyTest
    {
        /// <summary>
        /// Test if the to string method is correct
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            Money money1 = new Money("EUR");
            Money money2 = new Money("DLR");

            Assert.AreEqual("Money\nCurrency: EUR", money1.ToString());
            Assert.AreEqual("Money\nCurrency: DLR", money2.ToString());
        }
    }
}
