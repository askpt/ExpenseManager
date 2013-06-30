using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.Model;

namespace Test.Model
{
    /// <summary>
    /// The expense type test class
    /// </summary>
    [TestClass]
    public class ExpenseTypeTest
    {
        /// <summary>
        /// Test if the to string method is correct
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            ExpenseType expType1 = new ExpenseType("AAA", "aaa");
            ExpenseType expType2 = new ExpenseType("A1B1", "testes");

            Assert.AreEqual("AAA - aaa", expType1.ToString());
            Assert.AreEqual("A1B1 - testes", expType2.ToString());
        }
    }
}
