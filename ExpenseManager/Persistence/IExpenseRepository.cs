using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpenseManager.Model;

namespace ExpenseManager.Persistence
{
    /// <summary>
    /// The interface for the expense repository
    /// </summary>
    public interface IExpenseRepository
    {
        /// <summary>
        /// Saves an expense object in the repository
        /// </summary>
        /// <param name="exp">the object of expense</param>
        void Save(Expense exp);

        /// <summary>
        /// Method to get all of expense
        /// </summary>
        /// <returns>the list of expenses</returns>
        List<Expense> All();

        /// <summary>
        /// Method to get all of expenses from last week
        /// </summary>
        /// <returns>the list of expenses from last week</returns>
        List<Expense> GetFromLastWeek();
    }
}
