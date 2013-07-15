using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Model
{
    /// <summary>
    /// The class for the money that will implement the payment method
    /// </summary>
    public class Money : PaymentMethod
    {
        /// <summary>
        /// the currency of the money
        /// </summary>
        private string currency;

        /// <summary>
        /// The main constructor for the money
        /// </summary>
        ///<param name="currency">the currency of the money</param>
        public Money(string currency)
        {
            this.currency = currency;
        }

    }
}
