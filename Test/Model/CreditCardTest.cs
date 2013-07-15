using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.Model;

namespace Test.Model
{
    /// <summary>
    /// The credit card test class
    /// </summary>
    [TestClass]
    public class CreditCardTest
    {
        /// <summary>
        /// Test if the to string method is correct
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            CreditCard cc1 = new CreditCard("AA", "hi", "Me", new DateTime(2012, 12, 1), 1165131, 15);
            CreditCard cc2 = new CreditCard("BB", "oi", "you", new DateTime(2013, 09, 1), 156135, 17);

            Assert.AreEqual("Credit Card\nCard Name: AA\nCard Number: 1165131\nOwner: Me\nBank: hi\nValidity: 2012/12\nLimit: 15", cc1.ToString());
            Assert.AreEqual("Credit Card\nCard Name: BB\nCard Number: 156135\nOwner: you\nBank: oi\nValidity: 2013/9\nLimit: 17", cc2.ToString());
        }
    }
}
