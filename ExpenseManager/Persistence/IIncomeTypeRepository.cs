using ExpenseManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Persistence
{
    /// <summary>
    /// The interface for the income type repository
    /// </summary>
    public interface IIncomeTypeRepository
    {
        /// <summary>
        /// Saves an income type object in the repository
        /// </summary>
        /// <param name="incT">the object of income type</param>
        void Save(IncomeType incT);

        /// <summary>
        /// Method to get all of income type
        /// </summary>
        /// <returns>the list of income type</returns>
        List<IncomeType> All();
    }
}
