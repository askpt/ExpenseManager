using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.ViewModel;
using ExpenseManager.Model;
using System.Collections.Generic;
using ExpenseManager.Persistence;

namespace Test.Function
{
    /// <summary>
    /// The test class for the income type functions
    /// </summary>
    [TestClass]
    public class IncomeTypeTest
    {
        /// <summary>
        /// The test method for the register income type
        /// </summary>
        [TestMethod]
        public void TestRegisterExpenseType()
        {
            IncomeTypeController incTC = new IncomeTypeController();
            incTC.RegisterIncomeType("AAA", "aaa");
            incTC.RegisterIncomeType("A1B1", "testes");

            List<IncomeType> list = PersistenceFactory.GetFactory().GetRepository().GetIncomeTypeRepository().All();

            Assert.AreEqual(list[0].ToString(), "AAA - aaa");
            Assert.AreEqual(list[1].ToString(), "A1B1 - testes");
        }
    }
}
