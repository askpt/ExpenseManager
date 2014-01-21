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
    }
}
