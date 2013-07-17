using ExpenseManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                            //TODO add list code
                            throw new NotImplementedException();
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

            RegisterExpenseTypeController retC = new RegisterExpenseTypeController();
            retC.RegisterExpenseType(key, description);
        }
    }
}
