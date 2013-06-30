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
    interface IPersistenceFactory
    {
        /// <summary>
        /// Gets the Expense Type Repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        IExpenseTypeRepository GetExpenseTypeRepository();
    }
}
