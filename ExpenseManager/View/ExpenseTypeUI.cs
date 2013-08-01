using ExpenseManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExpenseManager.Model;

namespace ExpenseManager.View
{
    /// <summary>
    /// The specific register expense type ui
    /// </summary>
    public class ExpenseTypeUI
    {

        /// <summary>
        /// The main menu of expense type
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
                            ShowRegisterExpenseType();
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
        /// The visual main menu of expense type
        /// </summary>
        public void Menu()
        {
            Console.WriteLine(" === Register Expense Type Menu ===");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. List");

            Console.WriteLine("0. Exit\n");
        }



        /// <summary>
        /// The specific method to the register expense type ui
        /// </summary>
        public void ShowRegisterExpenseType()
        {
            string key, description;

            Console.WriteLine("Insert the key for the expense type");
            key = Console.ReadLine();
            Console.WriteLine("Insert the description fot the expense type");
            description = Console.ReadLine();

            ExpenseTypeController retC = new ExpenseTypeController();
            retC.RegisterExpenseType(key, description);
        }

        /// <summary>
        /// Method that will list all of expense types in repository
        /// </summary>
        public void List()
        {
            ExpenseTypeController etC = new ExpenseTypeController();

            Console.WriteLine(" === Expense Type List ===");

            List<ExpenseType> list = etC.GetAllExpenseTypes();
            int i = 0;

            foreach (ExpenseType item in list)
            {
                Console.WriteLine(i);
                Console.WriteLine(item);
                Console.WriteLine("---\n");
                i++;
            }
        }
    }
}