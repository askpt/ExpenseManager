using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.Model;

namespace Test.Model
{
    /// <summary>
    /// The expense test class
    /// </summary>
    [TestClass]
    public class ExpenseTest
    {
        /// <summary>
        /// Test if the to string method is correct
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            ExpenseType type = new ExpenseType("AAA", "aaa");
            Money money1 = new Money("EUR");
            Payment pay1 = new Payment(money1, 15);
            DateTime date = new DateTime(2012, 12, 21, 15, 30, 00);
            Expense exp = new Expense(type, pay1, date, "AAA");


            Assert.AreEqual("Expense:\nDescription: AAA\nType: AAA - aaa\nPayment: Payment: Money\nCurrency: EUR\nAmount: 15\nDate: 21/12/2012 15:30:00", exp.ToString());
        }
    }
}
