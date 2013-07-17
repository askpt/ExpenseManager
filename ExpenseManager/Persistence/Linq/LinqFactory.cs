using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using ExpenseManager.Model;

namespace ExpenseManager.Persistence.Linq
{
    /// <summary>
    /// The factory for the Linq save method
    /// </summary>
    public class LinqFactory : IPersistenceFactory
    {
        /// <summary>
        /// the singleton instance of linq factory
        /// </summary>
        private static IPersistenceFactory instance = null;

        /// <summary>
        /// Constructor of the Linq Factory
        /// </summary>
        private LinqFactory() { }

        /// <summary>
        /// the method that will access the instance of repository
        /// </summary>
        /// <returns>the running instance of repository</returns>
        public static IPersistenceFactory GetInstance()
        {
            if (instance == null)
            {
                instance = new LinqFactory();
            }
            return instance;
        }

        /// <summary>
        /// Gets the Expense Type Repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        public IExpenseTypeRepository GetExpenseTypeRepository()
        {
            return new ExpenseTypeRepository();
        }

        /// <summary>
        /// Gets the payment method Repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        public IPaymentMethodRepository GetPaymentMethodRepository()
        {
            return new PaymentMethodRepository();
        }
    }
}
