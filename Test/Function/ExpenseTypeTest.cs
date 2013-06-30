using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.Model;
using ExpenseManager.ViewModel;
using ExpenseManager.Persistence;

namespace Test.Function
{
    [TestClass]
    public class ExpenseTypeTest
    {
        [TestMethod]
        public void TestRegisterExpense()
        {
            RegisterExpenseTypeController retC = new RegisterExpenseTypeController();
            retC.RegisterExpenseType("AAA", "aaa");
            retC.RegisterExpenseType("A1B1", "testes");

            List<ExpenseType> list = PersistenceFactory.GetFactory().GetRepository().GetExpenseTypeRepository().All();

            Assert.AreEqual(list[0].ToString(), "AAA - aaa");
            Assert.AreEqual(list[1].ToString(), "A1B1 - testes");
        }
    }
}
