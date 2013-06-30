using ExpenseManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Persistence.InMemory
{
    /// <summary>
    /// The expense type in memory repository
    /// </summary>
    class ExpenseTypeRepository : IExpenseTypeRepository
    {
        /// <summary>
        /// the singleton instance of expense type
        /// </summary>
        private static ExpenseTypeRepository instance = null;
        /// <summary>
        /// the list of expense types
        /// </summary>
        private List<ExpenseType> types;

        /// <summary>
        /// the private constructor of the expense type repository
        /// </summary>
        private ExpenseTypeRepository()
        {
            types = new List<ExpenseType>();
        }
        /// <summary>
        /// the method that will access the instance of running expense type repository
        /// </summary>
        /// <returns>the running instance of expense type repository</returns>
        public static ExpenseTypeRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new ExpenseTypeRepository();
            }
            return instance;
        }
        /// <summary>
        /// Saves an expense type object in the repository
        /// </summary>
        /// <param name="expType">the object of expense type</param>
        public void Save(ExpenseType expType)
        {
            Persist(expType);
        }
        /// <summary>
        /// Saves an expense type object in the repository
        /// </summary>
        /// <param name="expType">the object of expense type</param>
        private void Persist(ExpenseType expType)
        {
            types.Add(expType);

        }

        /// <summary>
        /// Method to get all of expense types
        /// </summary>
        /// <returns>the list of expense types</returns>
        public List<ExpenseType> All()
        {
            return types;
        }
    }
}
