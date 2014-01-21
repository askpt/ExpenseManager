using ExpenseManager.Model;
using ExpenseManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.View
{
    /// <summary>
    /// The specific register income ui
    /// </summary>
    public class IncomeUI
    {
        /// <summary>
        /// The main menu of income
        /// </summary>
        public void Show()
        {
            int option = 999;
            const int EXIT = 0, REGISTER = 1, LIST = 2;
            do
            {
                Menu();
                Console.WriteLine("Choose an option.");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case REGISTER:
                            ShowRegisterIncome();
                            break;
                        case LIST:
                            List();
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
        /// Method that will list all of incomes in repository
        /// </summary>
        private void List()
        {
            IncomeController ic = new IncomeController();

            Console.WriteLine(" === Income List ===");

            List<Income> incomes = ic.GetAllIncomes().ToList();
            int i = 0;
            foreach (Income item in incomes)
            {
                Console.WriteLine(i);
                Console.WriteLine(item);
                Console.WriteLine("---\n");
                i++;
            }
        }

        #region Register Income
        /// <summary>
        /// The specific method to the register income ui
        /// </summary>
        private void ShowRegisterIncome()
        {
            IncomeController ic = new IncomeController();

            IncomeType type = GetIncomeType();
            DateTime date = GetDate();
            Console.WriteLine("Insert a description");
            string description = Console.ReadLine();

            double amount;

            Console.WriteLine("Insert Amount:");
            while (!double.TryParse(Console.ReadLine(), out amount)) ;

            ic.RegisterIncome(type, date, amount, description);
        }

        /// <summary>
        /// The method that will create a new date for the income
        /// </summary>
        /// <returns>a income date</returns>
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
        /// The method that will choose a income type in the repository
        /// </summary>
        /// <returns>A income type</returns>
        private IncomeType GetIncomeType()
        {
            IncomeType type = null;
            IncomeController ic = new IncomeController();
            IncomeTypeUI itUI = new IncomeTypeUI();

            int numIncType = ic.GetIncomeTypeRepositorySize();
            if (numIncType == 0)
            {
                Console.WriteLine("Create a new Income Type");
                itUI.ShowRegisterIncomeType();
                type = ic.GetLastExpenseType();
            }
            else
            {
                int option = 999;
                Console.WriteLine("Choose an Income Type");
                itUI.List();

                do
                {
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        type = ic.GetIncomeType(option);
                    }
                    else
                    {
                        option = -1;
                    }
                } while (option < 0 || option > numIncType);
            }

            return type;
        }
        #endregion

        /// <summary>
        /// The visual main menu of income
        /// </summary>
        private void Menu()
        {
            Console.WriteLine(" === Register Income Menu ===");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. List");

            Console.WriteLine("0. Exit\n");
        }
    }

}
