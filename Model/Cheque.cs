using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Model
{
    /// <summary>
    /// The class for the cheque that will implement the payment method
    /// </summary>
    public class Cheque : PaymentMethod
    {
        /// <summary>
        /// the cheque book name
        /// </summary>
        public string chequeBook { get; set; }
        /// <summary>
        /// the cheque book bank
        /// </summary>
        public string bank { get; set; }
        /// <summary>
        /// the account number of the cheque book
        /// </summary>
        public int accountNumber { get; set; }

        /// <summary>
        /// The main constructor for the cheque
        /// </summary>
        /// <param name="chequeBook">the cheque book name</param>
        /// <param name="bank">the cheque book bank</param>
        /// <param name="accountNumber">the account number of the cheque book</param>
        public Cheque(string chequeBook, string bank, int accountNumber)
        {
            this.chequeBook = chequeBook;
            this.bank = bank;
            this.accountNumber = accountNumber;
        }

        /// <summary>
        /// The ToString Method that will show the content of the cheque
        /// </summary>
        /// <returns>the content of expense type in this format: Cheque\nCheque Book Name: chequeBook\nBank: bank\nAccount Number: accountNumber</returns>
        public override string ToString()
        {
            return "Cheque\nCheque Book Name: " + chequeBook + "\nBank: " + bank + "\nAccount Number: " + accountNumber;
        }
    }
}
