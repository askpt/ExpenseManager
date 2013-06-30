using ExpenseManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Persistence
{
    /// <summary>
    /// The interface for the expense type repository
    /// </summary>
    public interface IExpenseTypeRepository
    {
        /// <summary>
        /// Saves an expense type object in the repository
        /// </summary>
        /// <param name="expType">the object of expense type</param>
        void Save(ExpenseType expType);
        /// <summary>
        /// Method to get all of expense types
        /// </summary>
        /// <returns>the list of expense types</returns>
        List<ExpenseType> All();
    }
}
