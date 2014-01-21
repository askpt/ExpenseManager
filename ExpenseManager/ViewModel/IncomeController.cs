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
    /// The controller class to the income functions
    /// </summary>
    public class IncomeController
    {
        /// <summary>
        /// The method that will return the list with all incomes
        /// </summary>
        /// <returns>a list with all incomes</returns>
        public IList<Income> GetAllIncomes()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetIncomeRepository().All();
        }

        /// <summary>
        /// The method that will save an income
        /// </summary>
        /// <param name="type">income type</param>
        /// <param name="date">income date</param>
        /// <param name="amount">income amount</param>
        /// <param name="description">income description</param>
        public void RegisterIncome(IncomeType type, DateTime date, double amount, string description)
        {
            Income inc = new Income(description, date, amount, type);

            PersistenceFactory.GetFactory().GetRepository().GetIncomeRepository().Save(inc);
        }

        /// <summary>
        /// The method that will return the size of income type repository
        /// </summary>
        /// <returns>the size of income type repository</returns>
        public int GetIncomeTypeRepositorySize()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetIncomeTypeRepository().All().Count;
        }

        /// <summary>
        /// The method that will return the last income type of the repository
        /// </summary>
        /// <returns>the last income type of repository</returns>
        public IncomeType GetLastExpenseType()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetIncomeTypeRepository().All().Last();
        }

        /// <summary>
        /// The method that will return the choosen income type
        /// </summary>
        /// <param name="option">the option in the list of income types</param>
        /// <returns>a income type</returns>
        public IncomeType GetIncomeType(int option)
        {
            return PersistenceFactory.GetFactory().GetRepository().GetIncomeTypeRepository().All()[option];
        }
    }
}
