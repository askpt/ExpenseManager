using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.Model;

namespace Test.Model
{
    /// <summary>
    /// The income test class
    /// </summary>
    [TestClass]
    public class IncomeTest
    {
        /// <summary>
        /// Test if the to string method is correct
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            IncomeType type = new IncomeType("AAA", "aaa");
            DateTime date = new DateTime(2012, 12, 21, 15, 30, 00);
            Income inc = new Income("AAA", date, 25, type);

            Assert.AreEqual("Income:\nDescription: AAA\nType: AAA - aaa\nAmount: 25\nDate: 21/12/2012 15:30:00", inc.ToString());
        }
    }
}
