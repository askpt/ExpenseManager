using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.Model;

namespace Test.Model
{
    /// <summary>
    /// The cheque test class
    /// </summary>
    [TestClass]
    public class ChequeTest
    {
        /// <summary>
        /// Test if the to string method is correct
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            Cheque cq1 = new Cheque("ABC", "AAA", 15645131);
            Cheque cq2 = new Cheque("ASW", "ASD", 156465);
            
            Assert.AreEqual("Cheque\nCheque Book Name: ABC\nBank: AAA\nAccount Number: 15645131", cq1.ToString());
            Assert.AreEqual("Cheque\nCheque Book Name: ASW\nBank: ASD\nAccount Number: 156465", cq2.ToString());
        }
    }
}
