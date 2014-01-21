using ExpenseManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Persistence
{
    /// <summary>
    /// The interface for the income repository
    /// </summary>
    public interface IIncomeRepository
    {
        /// <summary>
        /// Saves an income object in the repository
        /// </summary>
        /// <param name="inc">the object of income</param>
        void Save(Income inc);

        /// <summary>
        /// Method to get all of incomes
        /// </summary>
        /// <returns>the list of incomes</returns>
        IList<Income> All();
    }
}
