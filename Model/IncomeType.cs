using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Model
{
    /// <summary>
    /// The class of the income types
    /// </summary>
    public class IncomeType
    {
        /// <summary>
        /// the generated id for databases
        /// </summary>
        private int id { get; set; }
        /// <summary>
        /// the key of income type
        /// </summary>
        public string key { get; set; }
        /// <summary>
        /// the description of income type
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// the full constructor of income type
        /// </summary>
        /// <param name="key">the key of income type</param>
        /// <param name="description">the description of income type</param>
        public IncomeType(string key, string description)
        {
            this.key = key;
            this.description = description;
        }

        /// <summary>
        /// The default constructor
        /// </summary>
        public IncomeType() { }

        /// <summary>
        /// The ToString Method that will show the content of the income type
        /// </summary>
        /// <returns>the content of income type in this format: key - description</returns>
        public override string ToString()
        {
            return key + " - " + description;
        }
    }
}
