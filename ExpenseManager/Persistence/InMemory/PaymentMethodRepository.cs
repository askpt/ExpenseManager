using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManager.Model;

namespace ExpenseManager.Persistence.InMemory
{
    /// <summary>
    /// The expense type in memory repository
    /// </summary>
    public class PaymentMethodRepository : IPaymentMethodRepository
    {
        /// <summary>
        /// the singleton instance of payment method
        /// </summary>
        private static PaymentMethodRepository instance = null;
        /// <summary>
        /// the list of payment methods
        /// </summary>
        private List<PaymentMethod> methods;

        /// <summary>
        /// the private constructor of the payment method repository
        /// </summary>
        private PaymentMethodRepository()
        {
            methods = new List<PaymentMethod>();
        }

        /// <summary>
        /// Saves an payment method object in the repository
        /// </summary>
        /// <param name="payMeth">the object of payment method</param>
        public void Save(PaymentMethod payMeth)
        {
            methods.Add(payMeth);
        }

        /// <summary>
        /// Method to get all of payment methods
        /// </summary>
        /// <returns>the list of payment methods</returns>
        public List<Model.PaymentMethod> All()
        {
            return methods;
        }

        /// <summary>
        /// the method that will access the instance of running payment method repository
        /// </summary>
        /// <returns>the running instance of payment method repository</returns>
        public static IPaymentMethodRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new PaymentMethodRepository();
            }

            return instance;
        }
    }
}
