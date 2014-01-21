using ExpenseManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Persistence.InMemory
{
    /// <summary>
    /// The income type in memory repository
    /// </summary>
    public class IncomeTypeRepository : IIncomeType
    {
        /// <summary>
        /// the singleton instance of income type
        /// </summary>
        private static IncomeTypeRepository instance = null;
        /// <summary>
        /// the list of income types
        /// </summary>
        private List<IncomeType> incomeTypes;

        /// <summary>
        /// the private constructor of the income type repository
        /// </summary>
        private IncomeTypeRepository()
        {
            incomeTypes = new List<IncomeType>();
        }

        /// <summary>
        /// the method that will access the instance of running income type repository
        /// </summary>
        /// <returns>the running instance of income type repository</returns>
        public static IncomeTypeRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new IncomeTypeRepository();
            }

            return instance;
        }

        /// <summary>
        /// Saves an income type object in repository
        /// </summary>
        /// <param name="incT">the object of income type</param>
        public void Save(IncomeType incT)
        {
            incomeTypes.Add(incT);
        }

        /// <summary>
        /// Method to get all of income types
        /// </summary>
        /// <returns>the list of income types</returns>
        public List<IncomeType> All()
        {
            return incomeTypes;
        }
    }
}
