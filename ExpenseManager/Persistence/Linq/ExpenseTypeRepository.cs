using ExpenseManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Persistence.Linq
{
    /// <summary>
    /// The expense type in linq
    /// </summary>
    public class ExpenseTypeRepository : IExpenseTypeRepository
    {
        /// <summary>
        /// The data context of linq connection
        /// </summary>
        LinqDataContext db = new LinqDataContext();

        /// <summary>
        /// Saves an expense type object in the repository
        /// </summary>
        /// <param name="expType">the object of expense type</param>
        public void Save(ExpenseType expType)
        {
            db.ExpenseType.InsertOnSubmit(expType);
            db.SubmitChanges();
        }

        /// <summary>
        /// Method to get all of expense types
        /// </summary>
        /// <returns>the list of expense types</returns>
        public List<ExpenseType> All()
        {
            return db.ExpenseType.ToList();
        }
    }
}
