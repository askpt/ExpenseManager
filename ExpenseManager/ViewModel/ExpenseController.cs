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
    /// The controller class to the expense functions
    /// </summary>
    public class ExpenseController
    {
        /// <summary>
        /// The method that will return the number of expense types existing in the repository
        /// </summary>
        /// <returns>the number of existing expense types</returns>
        public int GetExpenseTypeRepositorySize()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetExpenseTypeRepository().All().Count;
        }

        /// <summary>
        /// The method that will return the number of payment methods existing in the repository
        /// </summary>
        /// <returns>the number of existing payment methods</returns>
        public int GetPaymentMethodRepositorySize()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetPaymentMethodRepository().All().Count;
        }

        /// <summary>
        /// The method that will return the last expense type in the repository
        /// </summary>
        /// <returns>An expense type</returns>
        public ExpenseType GetLastExpenseType()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetExpenseTypeRepository().All().Last();
        }

        /// <summary>
        /// The method that will return a choosen expense type
        /// </summary>
        /// <param name="option">the index of the choosen expense type</param>
        /// <returns>An expense type</returns>
        public ExpenseType GetExpenseType(int option)
        {
            return PersistenceFactory.GetFactory().GetRepository().GetExpenseTypeRepository().All()[option];
        }

        /// <summary>
        /// The method that will return the last payment method in the repository
        /// </summary>
        /// <returns>A payment method</returns>
        public PaymentMethod GetLastPaymentMethod()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetPaymentMethodRepository().All().Last();
        }

        /// <summary>
        /// The method that will return a choosen payment method
        /// </summary>
        /// <param name="option">the index of the choosen payment method</param>
        /// <returns>A payment method</returns>
        public PaymentMethod GetPaymentMethod(int option)
        {
            return PersistenceFactory.GetFactory().GetRepository().GetPaymentMethodRepository().All()[option];
        }

        /// <summary>
        /// Creates a new cheque payment 
        /// </summary>
        /// <param name="method">the payment method</param>
        /// <param name="amount">the payment amount</param>
        /// <param name="chequeNumber">the cheque number</param>
        /// <returns>the payment cheque</returns>
        public Payment CreatePayment(PaymentMethod method, double amount, int chequeNumber)
        {
            return new PaymentCheque(method, amount, chequeNumber);
        }

        /// <summary>
        /// Creates a new payment 
        /// </summary>
        /// <param name="method">the payment method</param>
        /// <param name="amount">the payment amount</param>
        /// <returns>the payment </returns>
        public Payment CreatePayment(PaymentMethod method, double amount)
        {
            return new Payment(method, amount);
        }

        /// <summary>
        /// Method that will save an expense
        /// </summary>
        /// <param name="type">expense type</param>
        /// <param name="payment">expense payment</param>
        /// <param name="date">expense date</param>
        /// <param name="description">expense description</param>
        public void RegisterExpense(ExpenseType type, Payment payment, DateTime date, string description)
        {
            Expense exp = new Expense(type, payment, date, description);

            PersistenceFactory.GetFactory().GetRepository().GetExpenseRepository().Save(exp);
        }

        /// <summary>
        /// The method that will return the list with all expenses.
        /// </summary>
        /// <returns>a list with all expenses</returns>
        public List<Expense> GetAllExpenses()
        {
            return PersistenceFactory.GetFactory().GetRepository().GetExpenseRepository().All();
        }

        /// <summary>
        /// The method that will return a list with all expenses from last week
        /// </summary>
        /// <returns>a list with all expenses from last week</returns>
        public List<Expense> GetExpensesFromLastWeek()
        {
            List<Expense> expenses = GetAllExpenses();
            List<Expense> expWeek = new List<Expense>();

            DateTime thisWeek = DateTime.Now.Subtract(new TimeSpan(7, 0, 0, 0));

            foreach (Expense item in expenses)
            {
                if (item.date.CompareTo(thisWeek) == 1)
                {
                    expWeek.Add(item);
                }
            }

            return expWeek;
        }

        /// <summary>
        /// The method that will return a list with all expenses from last month
        /// </summary>
        /// <returns>a list with all expenses from last month</returns>
        public List<Expense> GetExpensesFromLastMonth()
        {
            List<Expense> expenses = GetAllExpenses();
            List<Expense> expMonth = new List<Expense>();

            DateTime thisMonth = DateTime.Now.Subtract(new TimeSpan(30, 0, 0, 0));

            foreach (Expense item in expenses)
            {
                if (item.date.CompareTo(thisMonth) == 1)
                {
                    expMonth.Add(item);
                }
            }

            return expMonth;
        }

        /// <summary>
        /// The method that will return a list with all expenses from a given month, year and type
        /// </summary>
        /// <param name="type">the expense type</param>
        /// <param name="month">the month</param>
        /// <param name="year">the year</param>
        /// <returns>a list with expenses</returns>
        public List<Expense> GetExpensesByTypeAndMonth(ExpenseType type, int month, int year)
        {
            List<Expense> expRet = new List<Expense>();
            List<Expense> expenses = GetAllExpenses();

            foreach (Expense item in expenses)
            {
                if (item.type.key == type.key && item.date.Year == year && item.date.Month == month)
                {
                    expRet.Add(item);
                }
            }

            return expRet;
        }
    }
}
