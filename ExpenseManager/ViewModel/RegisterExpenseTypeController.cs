using ExpenseManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpenseManager.Persistence;

namespace ExpenseManager.ViewModel
{
    /// <summary>
    /// The controller class to the register expense type function
    /// </summary>
    public class RegisterExpenseTypeController
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
    }
}
