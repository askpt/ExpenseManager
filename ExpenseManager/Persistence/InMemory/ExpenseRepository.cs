using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManager.Model;

namespace ExpenseManager.Persistence.InMemory
{
    /// <summary>
    /// The expense in memory repository
    /// </summary>
    public class ExpenseRepository : IExpenseRepository
    {
        /// <summary>
        /// the singleton instance of expense
        /// </summary>
        private static ExpenseRepository instance = null;
        /// <summary>
        /// the list of expenses
        /// </summary>
        private List<Expense> expenses;

        /// <summary>
        /// the private constructor of the expense repository
        /// </summary>
        private ExpenseRepository()
        {
            expenses = new List<Expense>();
        }

        /// <summary>
        /// the method that will access the instance of running expense repository
        /// </summary>
        /// <returns>the running instance of expense repository</returns>
        public static ExpenseRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new ExpenseRepository();
            }

            return instance;
        }

        /// <summary>
        /// Saves an expense object in repository
        /// </summary>
        /// <param name="exp">the object of expense</param>
        public void Save(Model.Expense exp)
        {
            expenses.Add(exp);
        }

        /// <summary>
        /// Method to get all of expenses
        /// </summary>
        /// <returns>the list of expenses</returns>
        public List<Model.Expense> All()
        {
            return expenses;
        }
    }
}
