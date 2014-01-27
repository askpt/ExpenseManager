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
    /// The controller class to the balance functions
    /// </summary>
    public class BalanceController
    {
        /// <summary>
        /// The method that will calculate the balance
        /// </summary>
        /// <returns>the actual balance</returns>
        public double CalculateBalance()
        {
            double retBal = Properties.GetInstance().startupBalance;
            List<Income> incomes = PersistenceFactory.GetFactory().GetRepository().GetIncomeRepository().All();
            List<Expense> expenses = PersistenceFactory.GetFactory().GetRepository().GetExpenseRepository().All();

            double sumInc = SumIncomes(incomes);
            double sumExp = SumExpenses(expenses);

            retBal += sumInc - sumExp;

            return retBal;
        }

        /// <summary>
        /// The method that will calculate a sum of incomes from a given list
        /// </summary>
        /// <param name="incomes">the list of incomes</param>
        /// <returns>a sum with of all incomes</returns>
        public double SumIncomes(List<Income> incomes)
        {
            double retSum = 0;

            foreach (Income item in incomes)
            {
                retSum += item.amount;
            }

            return retSum;
        }

        /// <summary>
        /// The method that will calculate a sum of expenses from a given list
        /// </summary>
        /// <param name="expenses">the list of expenses</param>
        /// <returns>a sum with of all expenses</returns>
        public double SumExpenses(List<Expense> expenses)
        {
            double retSum = 0;

            foreach (Expense item in expenses)
            {
                retSum += item.payment.amount;
            }

            return retSum;
        }
    }
}
