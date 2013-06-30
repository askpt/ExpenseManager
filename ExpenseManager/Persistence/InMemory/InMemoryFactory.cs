using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManager.Persistence;

namespace ExpenseManager.Persistence.InMemory
{
    /// <summary>
    /// The in memory factory
    /// </summary>
    class InMemoryFactory : IPersistenceFactory
    {
        /// <summary>
        /// the singleton instance of persistence factory
        /// </summary>
        private static IPersistenceFactory instance = null;

        /// <summary>
        /// the private constructor of the repository
        /// </summary>
        private InMemoryFactory() { }

        /// <summary>
        /// the method that will access the instance of repository
        /// </summary>
        /// <returns>the running instance of repository</returns>
        public static IPersistenceFactory GetInstance()
        {
            if (instance == null)
                instance = new InMemoryFactory();
            return instance;
        }

        /// <summary>
        /// Gets the Expense Type Repository
        /// </summary>
        /// <returns>the instance of this repository</returns>
        public IExpenseTypeRepository GetExpenseTypeRepository()
        {
            return ExpenseTypeRepository.GetInstance();
        }
    }
}
