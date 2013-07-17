using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpenseManager.Model;

namespace ExpenseManager.Persistence.Linq
{
    /// <summary>
    /// The payment method in linq
    /// </summary>
    public class PaymentMethodRepository : IPaymentMethodRepository
    {

        /// <summary>
        /// Saves a payment method object in the repository
        /// </summary>
        /// <param name="payMeth">the object of payment method</param>
        public void Save(PaymentMethod payMeth)
        {
            LinqDataContext.GetInstance().PaymentMethod.InsertOnSubmit(payMeth);
            LinqDataContext.GetInstance().SubmitChanges();
        }

        /// <summary>
        /// Methid to get all of payment methods
        /// </summary>
        /// <returns>the list of payment methods</returns>
        public List<PaymentMethod> All()
        {
            return LinqDataContext.GetInstance().PaymentMethod.ToList();
        }
    }
}
