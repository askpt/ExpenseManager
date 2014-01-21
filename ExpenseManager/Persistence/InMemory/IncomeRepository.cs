using ExpenseManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Persistence.InMemory
{
    /// <summary>
    /// The income in memory repository
    /// </summary>
    public class IncomeRepository : IIncomeRepository
    {
        /// <summary>
        /// the singleton instance of income
        /// </summary>
        private static IncomeRepository instance = null;
        /// <summary>
        /// the list of incomes
        /// </summary>
        private List<Income> incomes;

        /// <summary>
        /// the private constructor of the income repository
        /// </summary>
        private IncomeRepository()
        {
            incomes = new List<Income>();
        }

        /// <summary>
        /// the method that will access the instance of running income repository
        /// </summary>
        /// <returns>the running instance of income repository</returns>
        public static IncomeRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new IncomeRepository();
            }

            return instance;
        }

        /// <summary>
        /// Saves an income object in repository
        /// </summary>
        /// <param name="inc">the object of income</param>
        public void Save(Model.Income inc)
        {
            incomes.Add(inc);
        }

        /// <summary>
        /// Method to get all of incomes
        /// </summary>
        /// <returns>the list of incomes</returns>
        public IList<Model.Income> All()
        {
            return incomes;
        }
    }
}
