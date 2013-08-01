using ExpenseManager.Model;
using ExpenseManager.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.ViewModel
{
    /// <summary>
    /// The controller class to the expense functions
    /// </summary>
    public class ExpenseController
    {
        /// <summary>
        /// The method that will return the number of expense types existing in the repository
        /// </summary>
        /// <returns>the number of existing expense types</returns>
        public int GetExpenseTypeRepositorySize()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetExpenseTypeRepository().All().Count;
        }

        /// <summary>
        /// The method that will return the number of payment methods existing in the repository
        /// </summary>
        /// <returns>the number of existing payment methods</returns>
        public int GetPaymentMethodRepositorySize()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetPaymentMethodRepository().All().Count;
        }

        /// <summary>
        /// The method that will return the last expense type in the repository
        /// </summary>
        /// <returns>An expense type</returns>
        public ExpenseType GetLastExpenseType()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetExpenseTypeRepository().All().Last();
        }

        /// <summary>
        /// The method that will return a choosen expense type
        /// </summary>
        /// <param name="option">the index of the choosen expense type</param>
        /// <returns>An expense type</returns>
        public ExpenseType GetExpenseType(int option)
        {
            return PersistenceFactory.GetFactory().GetRepository().GetExpenseTypeRepository().All()[option];
        }
    }
}
