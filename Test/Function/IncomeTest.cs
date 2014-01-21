using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.ViewModel;
using ExpenseManager.Model;
using ExpenseManager.Persistence;
using System.Collections.Generic;

namespace Test.Function
{
    /// <summary>
    /// The test class for the income function
    /// </summary>
    [TestClass]
    public class IncomeTest
    {
        /// <summary>
        /// The test method for the register income
        /// </summary>
        [TestMethod]
        public void TestRegisterIncome()
        {
            IncomeController ic = new IncomeController();

            IncomeType type = new IncomeType("AAA", "aaa");
            DateTime date = new DateTime(2012, 12, 21, 15, 30, 00);

            ic.RegisterIncome(type, date, 25, "AAA");

            List<Income> incs = ic.GetAllIncomes();
            Assert.AreEqual("Income:\nDescription: AAA\nType: AAA - aaa\nAmount: 25\nDate: 21/12/2012 15:30:00", incs[0].ToString());
        }
    }
}
