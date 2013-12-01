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
        /// the generated id for databases
        /// </summary>
        private int id { get; set; }
        /// <summary>
        /// the key of expense type
        /// </summary>
        public string key { get; set; }
        /// <summary>
        /// the description of expense type
        /// </summary>
        public string description { get; set; }

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
        /// The default constructor
        /// </summary>
        public ExpenseType() { }

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
