using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManager.Model;

namespace ExpenseManager.Persistence
{
    /// <summary>
    /// The interface for the payment method repository
    /// </summary>
    public interface IPaymentMethodRepository
    {
        /// <summary>
        /// Saves a payment method object in the repository
        /// </summary>
        /// <param name="payMeth">the object of payment method</param>
        void Save(PaymentMethod payMeth);
        /// <summary>
        /// Method to get all of payment methods
        /// </summary>
        /// <returns>the list of payment methods</returns>
        List<PaymentMethod> All();
    }
}
