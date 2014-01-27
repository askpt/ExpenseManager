using ExpenseManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.View
{
    /// <summary>
    /// The specific balance ui
    /// </summary>
    public class BalanceUI
    {

        /// <summary>
        /// The main menu of balance
        /// </summary>
        public void Show()
        {
            int option = 999;
            const int EXIT = 0, VIEW = 1;
            do
            {
                Menu();
                Console.WriteLine("Choose an option.");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case VIEW:
                            ViewBalance();
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
        /// The method that will show the actual balance
        /// </summary>
        private void ViewBalance()
        {
            double balance = 0;
            BalanceController balC = new BalanceController();

            balance = balC.CalculateBalance();

            Console.WriteLine("Actual Balance is: {0}.\n", balance);
        }

        /// <summary>
        /// The visual main menu of balance
        /// </summary>
        private void Menu()
        {
            Console.WriteLine(" === Balance Menu ===");
            Console.WriteLine("1. View");

            Console.WriteLine("0. Exit\n");
        }
    }
}
