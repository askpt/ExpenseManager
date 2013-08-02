using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.Model;

namespace Test.Model
{
    /// <summary>
    /// The payment class test
    /// </summary>
    [TestClass]
    public class PaymentTest
    {
        /// <summary>
        /// Test if the to string method to the payment is correct
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            Money money1 = new Money("EUR");
            Payment pay1 = new Payment(money1, 15);
            Assert.AreEqual("Payment: Money\nCurrency: EUR\nAmount: 15", pay1.ToString());

            DebitCard dc1 = new DebitCard("AAA", "123A", "Me", new DateTime(2013, 07, 1), 157568);
            Payment pay2 = new Payment(dc1, 53.5);
            Assert.AreEqual("Payment: Debit Card\nCard Name: AAA\nCard Number: 157568\nOwner: Me\nBank: 123A\nValidity: 2013/7\nAmount: 53,5", pay2.ToString());

            CreditCard cc1 = new CreditCard("AA", "hi", "Me", new DateTime(2012, 12, 1), 1165131, 15);
            Payment pay3 = new Payment(cc1, 125);
            Assert.AreEqual("Payment: Credit Card\nCard Name: AA\nCard Number: 1165131\nOwner: Me\nBank: hi\nValidity: 2012/12\nLimit: 15\nAmount: 125", pay3.ToString());
        }

        /// <summary>
        /// Test if the to string method to the cheque payment is correct
        /// </summary>
        [TestMethod]
        public void TestToStringCheque() 
        {
            Cheque cq1 = new Cheque("ABC", "AAA", 15645131);
            PaymentCheque pay1 = new PaymentCheque(cq1, 20.5, 1576);
            Assert.AreEqual("Payment: Cheque\nCheque Book Name: ABC\nBank: AAA\nAccount Number: 15645131\nAmount: 20,5\nCheque Number: 1576", pay1.ToString());
        
        }
    }
}
