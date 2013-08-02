using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Model
{
    /// <summary>
    /// The class for the payment of the expenses
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// The payment method
        /// </summary>
        private PaymentMethod method;
        /// <summary>
        /// The payment amount
        /// </summary>
        private float amount;

        /// <summary>
        /// The main constructor for the payment
        /// </summary>
        /// <param name="method">the payment method</param>
        /// <param name="amount">the payment amount</param>
        public Payment(PaymentMethod method, float amount)
        {
            this.method = method;
            this.amount = amount;
        }

        /// <summary>
        /// The ToString method that will show the content of the payment
        /// </summary>
        /// <returns>the content of payment in this format: Payment: method\nAmount: amount</returns>
        public override string ToString()
        {
            return "Payment: " + method + "\nAmount: " + amount;
        }
    }
}
