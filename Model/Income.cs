using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Model
{
    /// <summary>
    /// The class of Income
    /// </summary>
    public class Income
    {
        /// <summary>
        /// Income Description
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// Income Date
        /// </summary>
        public DateTime date { get; set; }
        /// <summary>
        /// Income Amount
        /// </summary>
        public double amount { get; set; }
        /// <summary>
        /// Income Type
        /// </summary>
        public IncomeType incomeType { get; set; }

        /// <summary>
        /// The main constructor of the income type
        /// </summary>
        /// <param name="description">income description</param>
        /// <param name="date">income date</param>
        /// <param name="amount">income amount</param>
        /// <param name="incomeType">income type</param>
        public Income(string description, DateTime date, double amount, IncomeType incomeType)
        {
            this.description = description;
            this.date = date;
            this.amount = amount;
            this.incomeType = incomeType;
        }

        /// <summary>
        /// The ToString method that will show the content of the income
        /// </summary>
        /// <returns>the content of the income in this format: Income:\nDescription: description\nType: type\nAmount: amount\nDate: date</returns>
        public override string ToString()
        {
            return "Income:\nDescription: " + description + "\nType: " + incomeType + "\nAmount: " + amount + "\nDate: " + date;
        }
    }
}
