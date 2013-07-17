using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpenseManager.Model;
using ExpenseManager.ViewModel;
using ExpenseManager.Persistence;

namespace Test.Function
{
    /// <summary>
    /// The test class for the payment methods functions
    /// </summary>
    [TestClass]
    public class PaymentMethodTest
    {
        /// <summary>
        /// The test method for the register payment method
        /// </summary>
        [TestMethod]
        public void TestRegisterPaymentMethod()
        {
            PaymentMethodController rpmC = new PaymentMethodController();

            rpmC.CreateCreditCard("AA", "hi", "Me", new DateTime(2012, 12, 1), 1165131, 15);
            rpmC.CreateCreditCard("BB", "oi", "you", new DateTime(2013, 09, 1), 156135, 17);

            rpmC.CreateDebitCard("AAA", "123A", "Me", new DateTime(2013, 07, 1), 157568);
            rpmC.CreateDebitCard("BASD", "qwwe", "You", new DateTime(4000, 12, 7), 16416);

            rpmC.CreateCheque("ABC", "AAA", 15645131);
            rpmC.CreateCheque("ASW", "ASD", 156465);

            rpmC.CreateMoney("EUR");
            rpmC.CreateMoney("DLR");

            List<PaymentMethod> list = PersistenceFactory.GetFactory().GetRepository().GetPaymentMethodRepository().All();

            Assert.AreEqual(list[0].ToString(), "Credit Card\nCard Name: AA\nCard Number: 1165131\nOwner: Me\nBank: hi\nValidity: 2012/12\nLimit: 15");
            Assert.AreEqual(list[1].ToString(), "Credit Card\nCard Name: BB\nCard Number: 156135\nOwner: you\nBank: oi\nValidity: 2013/9\nLimit: 17");

            Assert.AreEqual(list[2].ToString(), "Debit Card\nCard Name: AAA\nCard Number: 157568\nOwner: Me\nBank: 123A\nValidity: 2013/7");
            Assert.AreEqual(list[3].ToString(), "Debit Card\nCard Name: BASD\nCard Number: 16416\nOwner: You\nBank: qwwe\nValidity: 4000/12");

            Assert.AreEqual(list[4].ToString(), "Cheque\nCheque Book Name: ABC\nBank: AAA\nAccount Number: 15645131");
            Assert.AreEqual(list[5].ToString(), "Cheque\nCheque Book Name: ASW\nBank: ASD\nAccount Number: 156465");

            Assert.AreEqual(list[6].ToString(), "Money\nCurrency: EUR");
            Assert.AreEqual(list[7].ToString(), "Money\nCurrency: DLR");
        }
    }
}
