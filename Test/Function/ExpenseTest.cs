using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.Model;
using ExpenseManager.ViewModel;
using ExpenseManager.Persistence;

namespace Test.Function
{
    /// <summary>
    /// The test class for the expense function
    /// </summary>
    [TestClass]
    public class ExpenseTest
    {
        /// <summary>
        /// The test method for the register expense
        /// </summary>
        [TestMethod]
        public void TestRegisterExpense()
        {
            ExpenseController ec = new ExpenseController();
            ExpenseType type = new ExpenseType("AAA", "aaa");
            Money money1 = new Money("EUR");
            Payment pay1 = new Payment(money1, 15);
            DateTime date = new DateTime(2012, 12, 21, 15, 30, 00);
            ec.RegisterExpense(type, pay1, date, "AAA");
        
            List<Expense> list = PersistenceFactory.GetFactory().GetRepository().GetExpenseRepository().All();

            Assert.AreEqual("Expense:\nDescription: AAA\nType: AAA - aaa\nPayment: Payment: Money\nCurrency: EUR\nAmount: 15\nDate: 21/12/2012 15:30:00", list[0].ToString());
        }

    }
}