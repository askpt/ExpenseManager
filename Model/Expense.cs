using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Model
{
    /// <summary>
    /// The class of Expense
    /// </summary>
    public class Expense
    {
        /// <summary>
        /// Expense type
        /// </summary>
        private ExpenseType type;
        /// <summary>
        /// Payment Type
        /// </summary>
        private Payment payment;
        /// <summary>
        /// Payment Date
        /// </summary>
        private DateTime date;
        /// <summary>
        /// Payment Description
        /// </summary>
        private string description;

        /// <summary>
        /// The main constructor of the expense
        /// </summary>
        /// <param name="type">expense type</param>
        /// <param name="payment">expense payment</param>
        /// <param name="date">expense date</param>
        /// <param name="description">expense description</param>
        public Expense(ExpenseType type, Payment payment, DateTime date, string description)
        {
            this.type = type;
            this.payment = payment;
            this.date = date;
            this.description = description;
        }

        /// <summary>
        /// The ToString method that will show the content of the payment
        /// </summary>
        /// <returns>the content of the expense in this format: Expense:\nDescription: description\nType: type\nPayment: payment\nDate: date</returns>
        public override string ToString()
        {
            return "Expense:\nDescription: " + description + "\nType: " + type + "\nPayment: " + payment + "\nDate: " + date;
        }
    }
}
