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
            const int EXIT = 0, VIEW = 1, SETUP = 2;
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
                        case SETUP:
                            SetupStartupBalance();
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
        /// Method that will set a new startup balance
        /// </summary>
        private void SetupStartupBalance()
        {
            double balance = -1;
            do
            {
                Console.WriteLine("Insert a new startup balance.");
                double.TryParse(Console.ReadLine(), out balance);
            } while (balance < 0);

            BalanceController bc = new BalanceController();

            if (bc.SetUpStartupBalance(balance))
            {
                Console.WriteLine("Startup balance changed successfully.");
            }
            else
            {
                Console.WriteLine("Error!");
            }
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
            Console.WriteLine("2. Setup Startup Balance");

            Console.WriteLine("0. Exit\n");
        }
    }
}
