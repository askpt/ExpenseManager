using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Model
{
    /// <summary>
    /// The class that will extends the payment, in case of payment method is a cheque
    /// </summary>
    public class PaymentCheque : Payment
    {
        /// <summary>
        /// The cheque number
        /// </summary>
        public int chequeNumber { get; set; }

        /// <summary>
        /// The main constructor for the cheque payment
        /// </summary>
        /// <param name="method">the payment method</param>
        /// <param name="amount">the payment amount</param>
        /// <param name="chequeNumber">the cheque number</param>
        public PaymentCheque(PaymentMethod method, double amount, int chequeNumber)
            : base(method, amount)
        {
            this.chequeNumber = chequeNumber;
        }

        /// <summary>
        /// The ToString method that will show the content of the cheque payment
        /// </summary>
        /// <returns>the content of payment in this format: Payment: method\nAmount: amount\nCheque Number: chequeNumber</returns>
        public override string ToString()
        {
            return base.ToString() + "\nCheque Number: " + chequeNumber;
        }
    }
}
