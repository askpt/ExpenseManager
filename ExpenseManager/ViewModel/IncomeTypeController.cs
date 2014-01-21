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
    /// The controller class to the income type functions
    /// </summary>
    public class IncomeTypeController
    {
        /// <summary>
        /// The method that will share data between ui, model and persistance
        /// </summary>
        /// <param name="key">the key of income type</param>
        /// <param name="description">the description of income type</param>
        public void RegisterIncomeType(string key, string description)
        {
            IncomeType incT = new IncomeType(key, description);

            PersistenceFactory.GetFactory().GetRepository().GetIncomeTypeRepository().Save(incT);
        }

        /// <summary>
        /// The method that will return the list will all income types
        /// </summary>
        /// <returns>a list with all income types</returns>
        public List<IncomeType> GetAllIncomeTypes()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetIncomeTypeRepository().All();
        }
    }
}
