using ExpenseManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManager.Persistence;

namespace ExpenseManager.ViewModel
{
    /// <summary>
    /// The controller for the register payment function
    /// </summary>
    public class RegisterPaymentMethodController
    {
        /// <summary>
        /// The controller method to create the credit card
        /// </summary>
        /// <param name="cardName">the card name</param>
        /// <param name="bank">the card bank</param>
        /// <param name="owner">the card owner</param>
        /// <param name="valid">the card validity</param>
        /// <param name="number">the card number</param>
        /// <param name="limit">the card limit</param>
        public void CreateCreditCard(string cardName, string bank, string owner, DateTime valid, int number, int limit)
        {
            CreditCard cc = new CreditCard(cardName, bank, owner, valid, number, limit);

            PersistenceFactory.GetFactory().GetRepository().GetPaymentMethodRepository().Save(cc);
        }

        /// <summary>
        /// The controller method to create the debit card
        /// </summary>
        /// <param name="cardName">the card name</param>
        /// <param name="bank">the card bank</param>
        /// <param name="owner">the card owner</param>
        /// <param name="valid">the card validity</param>
        /// <param name="number">the card number</param>
        public void CreateDebitCard(string cardName, string bank, string owner, DateTime valid, int number)
        {
            DebitCard dc = new DebitCard(cardName, bank, owner, valid, number);

            PersistenceFactory.GetFactory().GetRepository().GetPaymentMethodRepository().Save(dc);
        }

        /// <summary>
        /// The controller method to create the cheque book
        /// </summary>
        /// <param name="chequeBook">the cheque book name</param>
        /// <param name="bank">the cheque book bank</param>
        /// <param name="accountNumber">the account number of the cheque book</param>
        public void CreateCheque(string chequeBook, string bank, int accountNumber)
        {
            Cheque cc = new Cheque(chequeBook, bank, accountNumber);

            PersistenceFactory.GetFactory().GetRepository().GetPaymentMethodRepository().Save(cc);
        }

        /// <summary>
        /// The controller method to create the money
        /// </summary>
        /// <param name="currency">the currency of the money</param>
        public void CreateMoney(string currency)
        {
            Money mc = new Money(currency);

            PersistenceFactory.GetFactory().GetRepository().GetPaymentMethodRepository().Save(mc);
        }
    }
}
