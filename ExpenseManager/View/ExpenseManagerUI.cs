using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.View
{
    /// <summary>
    /// The main menu of the program
    /// </summary>
    class ExpenseManagerUI
    {
        /// <summary>
        /// The method where we will choose the correct option to go
        /// </summary>
        public void Show()
        {
            int option;
            const int EXIT = 0, REGISTER_EXPENSE = 1, REGISTER_EXPENSE_TYPE = 2, REGISTER_PAYMENT_METHOD = 3;
            do
            {
                Menu();
                Console.WriteLine("Choose an option.");
                
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case REGISTER_EXPENSE:
                            //TODO some code
                            break;
                        case REGISTER_EXPENSE_TYPE:
                            RegisterExpenseTypeUI retUI = new RegisterExpenseTypeUI();
                            retUI.Show();
                            break;
                        case REGISTER_PAYMENT_METHOD:
                            //TODO some code
                            break;
                        case EXIT:
                            Console.WriteLine("Bye! Bye!");
                            break;
                        default:
                            Console.WriteLine("Unknown option\nPlease try again!");
                            break;
                    }
                }
                else
                {
                    option = 999;
                }

            } while (option != 0);
        }
        /// <summary>
        /// Shows the main menu
        /// </summary>
        private void Menu()
        {
            Console.WriteLine(" === Main Menu ===");
            Console.WriteLine("1. Register Expense");
            Console.WriteLine("2. Register Expense Type");
            Console.WriteLine("3. Register Payment Method");

            Console.WriteLine("0. Exit\n");
        }
    }
}
