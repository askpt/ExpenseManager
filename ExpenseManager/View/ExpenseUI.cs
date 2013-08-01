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
                            ShowRegisterExpense();
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
        /// Method that will list all of expenses in repository
        /// </summary>
        private void List()
        {
            throw new NotImplementedException();
        }

        #region Register Expense
        /// <summary>
        /// The specific method to the register expense ui
        /// </summary>
        private void ShowRegisterExpense()
        {
            ExpenseController ec = new ExpenseController();

            // Expense Type
            ExpenseType type = GetExpenseType();

            //TODO: Finish the code
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

        #endregion

        /// <summary>
        /// The visual main menu of expense
        /// </summary>
        private void Menu()
        {
            Console.WriteLine(" === Register Expense Menu ===");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. List");

            Console.WriteLine("0. Exit\n");
        }
    }
}
