using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenseManager.View
{
    /// <summary>
    /// The specific register payment method ui
    /// </summary>
    public class RegisterPaymentMethodUI
    {
        /// <summary>
        /// The specific method to the register payment method ui
        /// </summary>
        public void Show()
        {
            int option = 999;
            const int EXIT = 0, CREDIT_CARD = 1, DEBIT_CARD = 2, CHEQUE = 3, MONEY = 4;
            do
            {
                Menu();
                Console.WriteLine("Choose an option.");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case CREDIT_CARD:
                            //TODO some code
                            break;
                        case DEBIT_CARD:
                            //TODO some code
                            break;
                        case CHEQUE:
                            //TODO some code
                            break;
                        case MONEY:
                            //TODO some code
                            break;
                        case EXIT:
                            Console.WriteLine("Exiting");
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
            Console.WriteLine(" === Register Payment Method Menu ===");
            Console.WriteLine("1. Credit Card");
            Console.WriteLine("2. Debit Card");
            Console.WriteLine("3. Cheque");
            Console.WriteLine("4. Money");

            Console.WriteLine("0. Exit\n");
        }
    }
}
