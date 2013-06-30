using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManager.Persistence.InMemory;

namespace ExpenseManager.Persistence
{
    /// <summary>
    /// The Persistence Factory for the repository types
    /// </summary>
    class PersistenceFactory
    {
        /// <summary>
        /// the singleton instance of persistence factory
        /// </summary>
        private static PersistenceFactory instance = null;
        /// <summary>
        /// the config string for the repository
        /// </summary>
        private string repositoryConfigString = null;

        /// <summary>
        /// the private constructor of the expense type repository
        /// </summary>
        private PersistenceFactory() { }

        /// <summary>
        /// Method that will returns the repository type (In Memory or Database)
        /// </summary>
        /// <returns>repository type</returns>
        public IPersistenceFactory GetRepository()
        {
            if (repositoryConfigString == null)
                repositoryConfigString = GetRepositoryConfiguration();
            if (repositoryConfigString.Equals("InMemory"))
                return InMemoryFactory.GetInstance();
            return null;
        }

        /// <summary>
        /// the method that will access the instance of factory
        /// </summary>
        /// <returns>the running instance of factory</returns>
        public static PersistenceFactory GetFactory()
        {
            if (instance == null)
                instance = new PersistenceFactory();
            return instance;
        }

        /// <summary>
        /// Method that will choose the repository based on the configurations
        /// </summary>
        /// <returns>a string with choosed configuration</returns>
        private string GetRepositoryConfiguration()
        {
            //TODO add file config
            int opt = 1;

            if (opt == 1)
            {
                return "InMemory";
            }

            return null;
        }
    }
}
