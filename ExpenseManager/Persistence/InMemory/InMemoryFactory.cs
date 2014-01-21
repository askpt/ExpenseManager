using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManager.Persistence;

namespace ExpenseManager.Persistence.InMemory
{
    /// <summary>
    /// The in memory factory
    /// </summary>
    public class InMemoryFactory : IPersistenceFactory
    {
        /// <summary>
        /// the singleton instance of persistence factory
        /// </summary>
        private static InMemoryFactory instance = null;

        /// <summary>
        /// the private constructor of the repository
        /// </summary>
        private InMemoryFactory() { }

        /// <summary>
        /// the method that will access the instance of repository
        /// </summary>
        /// <returns>the running instance of repository</returns>
        public static InMemoryFactory GetInstance()
        {
            if (instance == null)
                instance = new InMemoryFactory();
            return instance;
        }

        /// <summary>
        /// Gets the Expense Type Repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        public IExpenseTypeRepository GetExpenseTypeRepository()
        {
            return ExpenseTypeRepository.GetInstance();
        }

        /// <summary>
        /// Gets the payment method Repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        public IPaymentMethodRepository GetPaymentMethodRepository()
        {
            return PaymentMethodRepository.GetInstance();
        }

        /// <summary>
        /// Gets the expense repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        public IExpenseRepository GetExpenseRepository()
        {
            return ExpenseRepository.GetInstance();
        }

        /// <summary>
        /// Gets the income type repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        public IIncomeTypeRepository GetIncomeTypeRepository()
        {
            return IncomeTypeRepository.GetInstance();
        }

        /// <summary>
        /// Gets the income repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        public IIncomeRepository GetIncomeRepository()
        {
            return IncomeRepository.GetInstance();
        }
    }
}
