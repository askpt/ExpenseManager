using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.Model;

namespace Test.Model
{
    /// <summary>
    /// The income type test class
    /// </summary>
    [TestClass]
    public class IncomeTypeTest
    {
        /// <summary>
        /// Test if the to string method is correct
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            IncomeType expType1 = new IncomeType("AAA", "aaa");
            IncomeType expType2 = new IncomeType("A1B1", "testes");

            Assert.AreEqual("AAA - aaa", expType1.ToString());
            Assert.AreEqual("A1B1 - testes", expType2.ToString());
        }
    }
}
