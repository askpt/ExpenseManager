using ExpenseManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpenseManager.Persistence;

namespace ExpenseManager.ViewModel
{
    /// <summary>
    /// The controller class to the expense type functions
    /// </summary>
    public class ExpenseTypeController
    {
        /// <summary>
        /// The method that will share data between ui, model and persistance
        /// </summary>
        /// <param name="key">the key of expense type</param>
        /// <param name="description">the description of expense type</param>
        public void RegisterExpenseType(string key, string description)
        {
            ExpenseType expType = new ExpenseType(key, description);

            PersistenceFactory.GetFactory().GetRepository().GetExpenseTypeRepository().Save(expType);
        }

        /// <summary>
        /// The method that will return the list with all expense types.
        /// </summary>
        /// <returns>a list with all expense types</returns>
        public List<ExpenseType> GetAllExpenseTypes()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetExpenseTypeRepository().All();
        }
    }
}
