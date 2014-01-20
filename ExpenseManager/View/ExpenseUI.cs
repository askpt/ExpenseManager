using ExpenseManager.Model;
using ExpenseManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenseManager.View
{
    /// <summary>
    /// The specific register expense ui
    /// </summary>
    public class ExpenseUI
    {
        /// <summary>
        /// The main menu of expense
        /// </summary>
        public void Show()
        {
            int option = 999;
            const int EXIT = 0, REGISTER = 1, LIST = 2, QUERY = 3;
            do
            {
                Menu();
                Console.WriteLine("Choose an option.");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case REGISTER:
                            ShowRegisterExpense();
                            break;
                        case LIST:
                            List();
                            break;
                        case QUERY:
                            ListAvailableQueries();
                            break;
                        case EXIT:
                            Console.WriteLine("Exiting");
                            break;
                        default:
                            Console.WriteLine("Unknown option\nPlease try again!");
                            break;
                    }
                }

            } while (option != 0);
        }

        #region Queries
        /// <summary>
        /// Method that will list all of available queries for expenses
        /// </summary>
        private void ListAvailableQueries()
        {
            int option = 999;
            const int EXIT = 0, WEEK = 1, MONTH = 2, TYPEANDMONTH = 3, TYPEANDMONTHGRAPH = 4;
            do
            {
                QueryMenu();
                Console.WriteLine("Choose an option.");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case WEEK:
                            ListLastWeek();
                            break;
                        case MONTH:
                            ListLastMonth();
                            break;
                        case TYPEANDMONTH:
                            ListByTypeAndMonth();
                            break;
                        case TYPEANDMONTHGRAPH:
                            GraphByTypeAndMonth();
                            break;
                        case EXIT:
                            Console.WriteLine("Exiting");
                            break;
                        default:
                            Console.WriteLine("Unknown option\nPlease try again!");
                            break;
                    }
                }
            } while (option != 0);
        }

        /// <summary>
        /// Show a graph of the expenses by type from a given month
        /// </summary>
        private void GraphByTypeAndMonth()
        {
            int month = 99, year = 99;
            do
            {
                Console.WriteLine("Choose a month.\nPress 0 to exit.");
                int.TryParse(Console.ReadLine(), out month);
            } while (month > 12 || month < 0);

            if (month > 0)
            {
                do
                {
                    Console.WriteLine("Choose a year.\nPress 0 to exit.");
                    int.TryParse(Console.ReadLine(), out year);
                } while (year > DateTime.Now.Year || year < 0);

                if (year > 0)
                {
                    List<string> typeStr = new List<string>();
                    List<double> sums = new List<double>();
                    double max = 0;

                    ExpenseTypeController etc = new ExpenseTypeController();
                    List<ExpenseType> expenseTypes = etc.GetAllExpenseTypes();

                    ExpenseController ec = new ExpenseController();
                    foreach (ExpenseType type in expenseTypes)
                    {
                        List<Expense> expenses = ec.GetExpensesByTypeAndMonth(type, month, year);
                        if (expenses.Count > 0)
                        {
                            typeStr.Add(type.key);
                            double tmpAmount = 0;
                            foreach (Expense exp in expenses)
                            {
                                tmpAmount += exp.payment.amount;   
                            }
                            if (tmpAmount > max)
                            {
                                max = tmpAmount;
                            }

                            sums.Add(tmpAmount);
                        }
                    }

                    for (int i = 0; i < typeStr.Count; i++)
                    {
                        Console.Write(typeStr[i] + "\t");
                        int nrStar = (int)sums[i] * 10 / (int)max;
                        for (int j = 0; j < nrStar; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

        /// <summary>
        /// List the expenses by category from given month
        /// </summary>
        private void ListByTypeAndMonth()
        {
            int month = 99, year = 99;
            do
            {
                Console.WriteLine("Choose a month.\nPress 0 to exit.");
                int.TryParse(Console.ReadLine(), out month);
            } while (month > 12 || month < 0);

            if (month > 0)
            {
                do
                {
                    Console.WriteLine("Choose a year.\nPress 0 to exit.");
                    int.TryParse(Console.ReadLine(), out year);
                } while (year > DateTime.Now.Year || year < 0);

                if (year > 0)
                {
                    ExpenseTypeController etc = new ExpenseTypeController();
                    List<ExpenseType> expenseTypes = etc.GetAllExpenseTypes();

                    ExpenseController ec = new ExpenseController();
                    foreach (ExpenseType type in expenseTypes)
                    {
                        List<Expense> expenses = ec.GetExpensesByTypeAndMonth(type, month, year);
                        if (expenses.Count > 0)
                        {
                            Console.WriteLine(type.ToString());
                            foreach (Expense exp in expenses)
                            {
                                Console.WriteLine(exp.ToString());
                            }
                        }
                    }
                }

            }
        }

        /// <summary>
        /// List the expenses from last week
        /// </summary>
        private void ListLastWeek()
        {
            ExpenseController ec = new ExpenseController();

            Console.WriteLine(" === Expense List ===");

            List<Expense> expenses = ec.GetExpensesFromLastWeek();
            int i = 0;
            foreach (Expense item in expenses)
            {
                Console.WriteLine(i);
                Console.WriteLine(item);
                Console.WriteLine("---\n");
                i++;
            }
        }

        /// <summary>
        /// List the expenses from last month
        /// </summary>
        private void ListLastMonth()
        {
            ExpenseController ec = new ExpenseController();

            Console.WriteLine(" === Expense List ===");

            List<Expense> expenses = ec.GetExpensesFromLastMonth();
            int i = 0;
            foreach (Expense item in expenses)
            {
                Console.WriteLine(i);
                Console.WriteLine(item);
                Console.WriteLine("---\n");
                i++;
            }
        }

        /// <summary>
        /// The visual main menu of expense queries
        /// </summary>
        private void QueryMenu()
        {
            Console.WriteLine(" === Queries ===");
            Console.WriteLine("1. Last Week");
            Console.WriteLine("2. Last Month");
            Console.WriteLine("3. Expense Type by Month");
            Console.WriteLine("4. Graph for Expense Type by Given Month");

            Console.WriteLine("0. Exit\n");
        }

        #endregion
        /// <summary>
        /// Method that will list all of expenses in repository
        /// </summary>
        private void List()
        {
            ExpenseController ec = new ExpenseController();

            Console.WriteLine(" === Expense List ===");

            List<Expense> expenses = ec.GetAllExpenses();
            int i = 0;
            foreach (Expense item in expenses)
            {
                Console.WriteLine(i);
                Console.WriteLine(item);
                Console.WriteLine("---\n");
                i++;
            }
        }

        #region Register Expense
        /// <summary>
        /// The specific method to the register expense ui
        /// </summary>
        private void ShowRegisterExpense()
        {
            ExpenseController ec = new ExpenseController();

            ExpenseType type = GetExpenseType();
            Payment pay = GetPayment();
            DateTime date = GetDate();
            Console.WriteLine("Insert a description");
            string description = Console.ReadLine();

            ec.RegisterExpense(type, pay, date, description);
        }

        /// <summary>
        /// The method that will create a new date for the expense
        /// </summary>
        /// <returns>a expense date</returns>
        private DateTime GetDate()
        {
            int year, month, day, hour, minute;

            Console.WriteLine("Insert the year");
            while (!int.TryParse(Console.ReadLine(), out year) || !((year < 99999) && (year > -1))) ;

            Console.WriteLine("Insert the month");
            while (!int.TryParse(Console.ReadLine(), out month) || !((month < 13) && (month > 0))) ;

            Console.WriteLine("Insert the day");
            while (!int.TryParse(Console.ReadLine(), out day) || !((day < 32) && (day > 0))) ;

            Console.WriteLine("Insert the hour");
            while (!int.TryParse(Console.ReadLine(), out hour) || !((hour < 24) && (hour > -1))) ;

            Console.WriteLine("Insert the minutes");
            while (!int.TryParse(Console.ReadLine(), out minute) || !((minute < 60) && (minute > -1))) ;

            return new DateTime(year, month, day, hour, minute, 0);
        }

        /// <summary>
        /// The method that will choose a expense type in the repository
        /// </summary>
        /// <returns>A expense type</returns>
        private ExpenseType GetExpenseType()
        {
            ExpenseType type = null;
            ExpenseController ec = new ExpenseController();
            ExpenseTypeUI etUI = new ExpenseTypeUI();

            int numExpType = ec.GetExpenseTypeRepositorySize();
            if (numExpType == 0)
            {
                Console.WriteLine("Create a new Expense Type");
                etUI.ShowRegisterExpenseType();
                type = ec.GetLastExpenseType();
            }
            else
            {
                int option = 999;
                Console.WriteLine("Choose a Expense Type");
                etUI.List();

                do
                {
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        type = ec.GetExpenseType(option);
                    }
                    else
                    {
                        option = -1;
                    }
                } while (option < 0 || option > numExpType);
            }

            return type;
        }

        /// <summary>
        /// The method that will choose a payment method in the repository
        /// </summary>
        /// <returns>A payment method</returns>
        private PaymentMethod GetPaymentMethod()
        {
            PaymentMethod method = null;
            ExpenseController ec = new ExpenseController();
            PaymentMethodUI pmUI = new PaymentMethodUI();

            int numPayMeth = ec.GetPaymentMethodRepositorySize();
            if (numPayMeth == 0)
            {
                Console.WriteLine("Create a new Payment Method");
                pmUI.ShowRegisterPayment();
                method = ec.GetLastPaymentMethod();
            }
            else
            {
                int option = 999;
                Console.WriteLine("Choose a Payment Method");
                pmUI.List();

                do
                {
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        method = ec.GetPaymentMethod(option);
                    }
                    else
                    {
                        option = -1;
                    }
                } while (option < 0 || option > numPayMeth);
            }

            return method;
        }

        /// <summary>
        /// The method that will create a new payment
        /// </summary>
        /// <returns>A payment</returns>
        private Payment GetPayment()
        {
            ExpenseController ec = new ExpenseController();
            PaymentMethod method = GetPaymentMethod();
            double amount;

            Console.WriteLine("Insert Amount:");
            while (!double.TryParse(Console.ReadLine(), out amount)) ;

            if (method is Cheque)
            {
                int chequeNumber;
                Console.WriteLine("Insert Cheque Number:");
                while (!int.TryParse(Console.ReadLine(), out chequeNumber)) ;
                return ec.CreatePayment(method, amount, chequeNumber);
            }
            else
            {
                return ec.CreatePayment(method, amount);
            }
        }

        #endregion

        /// <summary>
        /// The visual main menu of expense
        /// </summary>
        private void Menu()
        {
            Console.WriteLine(" === Register Expense Menu ===");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. List");
            Console.WriteLine("3. Queries");

            Console.WriteLine("0. Exit\n");
        }
    }
}
