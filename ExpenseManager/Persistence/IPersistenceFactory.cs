using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Persistence
{
    /// <summary>
    /// The Persistence Factory
    /// </summary>
    public interface IPersistenceFactory
    {
        /// <summary>
        /// Gets the Expense Type Repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        IExpenseTypeRepository GetExpenseTypeRepository();

        /// <summary>
        /// Gets the Payment Method Repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        IPaymentMethodRepository GetPaymentMethodRepository();

        /// <summary>
        /// Gets the Expense Repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        IExpenseRepository GetExpenseRepository();

        /// <summary>
        /// Gets the Income Type Repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        IIncomeType GetIncomeTypeRepository();

        /// <summary>
        /// Gets the Income Repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        IIncomeRepository GetIncomeRepository();
    }
}
