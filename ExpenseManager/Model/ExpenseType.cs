using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenseManager.Model
{
    /// <summary>
    /// The class of the expense types
    /// </summary>
    public class ExpenseType
    {
        /// <summary>
        /// the key of expense type
        /// </summary>
        private string key;
        /// <summary>
        /// the description of expense type
        /// </summary>
        private string description;

        /// <summary>
        /// the full constructor of expense type
        /// </summary>
        /// <param name="key">the key of expense type</param>
        /// <param name="description">the description of expense type</param>
        public ExpenseType(string key, string description)
        {
            this.key = key;
            this.description = description;
        }

        /// <summary>
        /// The ToString Method that will show the content of the expense type
        /// </summary>
        /// <returns>the content of expense type in this format: key - description</returns>
        public override string ToString()
        {
            return key + " - " + description;
        }
    }
}
