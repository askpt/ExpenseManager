using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.Model;

namespace Test.Model
{
    /// <summary>
    /// The debit card test class
    /// </summary>
    [TestClass]
    public class DebitCardTest
    {
        /// <summary>
        /// Test if the to string method is correct
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            DebitCard dc1 = new DebitCard("AAA", "123A", "Me", new DateTime(2013, 07, 1), 157568);
            DebitCard dc2 = new DebitCard("BASD", "qwwe", "You", new DateTime(4000, 12, 7), 16416);

            Assert.AreEqual("Debit Card\nCard Name: AAA\nCard Number: 157568\nOwner: Me\nBank: 123A\nValidity: 2013/7", dc1.ToString());
            Assert.AreEqual("Debit Card\nCard Name: BASD\nCard Number: 16416\nOwner: You\nBank: qwwe\nValidity: 4000/12", dc2.ToString());
        }
    }
}
