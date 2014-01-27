using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.ViewModel;
using ExpenseManager.Model;

namespace Test.Function
{
    /// <summary>
    /// The test class for the balance function
    /// </summary>
    [TestClass]
    public class BalanceTest
    {
        /// <summary>
        /// The test method for the view balance
        /// </summary>
        [TestMethod]
        public void TestViewBalance()
        {
            IncomeController ic = new IncomeController();
            IncomeType typeI = new IncomeType("AAA", "aaa");
            DateTime dateI = new DateTime(2012, 12, 21, 15, 30, 00);
            ic.RegisterIncome(typeI, dateI, 25, "AAA");

            ExpenseController ec = new ExpenseController();
            ExpenseType typeE = new ExpenseType("AAA", "aaa");
            Money moneyE = new Money("EUR");
            Payment payE = new Payment(moneyE, 15);
            DateTime dateE = new DateTime(2012, 12, 21, 15, 30, 00);
            ec.RegisterExpense(typeE, payE, dateE, "AAA");

            BalanceController bc = new BalanceController();
            double actual = bc.CalculateBalance();
            Assert.AreEqual(10, actual);
        }
    }
}
