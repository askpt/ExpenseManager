using ExpenseManager.ViewModel;
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
                            CreateCreditCard();
                            break;
                        case DEBIT_CARD:
                            CreateDebitCard();
                            break;
                        case CHEQUE:
                            CreateCheque();
                            break;
                        case MONEY:
                            CreateMoney();
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

        /// <summary>
        /// Shows the interface to create a credit card
        /// </summary>
        private void CreateCreditCard()
        {
            String cardName, bank, owner;
            DateTime valid;
            int number, yearTemp, monthTemp, limit;
            RegisterPaymentMethodController rc = new RegisterPaymentMethodController();

            Console.WriteLine("Enter the card name");
            cardName = Console.ReadLine();

            Console.WriteLine("Enter the bank");
            bank = Console.ReadLine();

            Console.WriteLine("Enter the owner of the credit card");
            owner = Console.ReadLine();

            Console.WriteLine("Enter the expire year");
            yearTemp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the expire month");
            monthTemp = int.Parse(Console.ReadLine());
            valid = new DateTime(yearTemp, monthTemp, 1);

            Console.WriteLine("Enter the card number");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the credit limit");
            limit = int.Parse(Console.ReadLine());

            rc.CreateCreditCard(cardName, bank, owner, valid, number, limit);
        }

        /// <summary>
        /// Shows the interface to create a debit card
        /// </summary>
        private void CreateDebitCard()
        {
            String cardName, bank, owner;
            DateTime valid;
            int number, yearTemp, monthTemp;
            RegisterPaymentMethodController rc = new RegisterPaymentMethodController();

            Console.WriteLine("Enter the card name");
            cardName = Console.ReadLine();

            Console.WriteLine("Enter the bank");
            bank = Console.ReadLine();

            Console.WriteLine("Enter the owner of the debit card");
            owner = Console.ReadLine();

            Console.WriteLine("Enter the expire year");
            yearTemp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the expire month");
            monthTemp = int.Parse(Console.ReadLine());
            valid = new DateTime(yearTemp, monthTemp, 1);

            Console.WriteLine("Enter the card number");
            number = int.Parse(Console.ReadLine());

            rc.CreateDebitCard(cardName, bank, owner, valid, number);
        }

        /// <summary>
        /// Shows the interface to create a cheque
        /// </summary>
        private void CreateCheque()
        {
            String chequeBook, bank;
            int accountNumber;
            RegisterPaymentMethodController rc = new RegisterPaymentMethodController();

            Console.WriteLine("Insert a cheque book name");
            chequeBook = Console.ReadLine();

            Console.WriteLine("Insert the bank name.");
            bank = Console.ReadLine();

            Console.WriteLine("Insert the account number");
            accountNumber = int.Parse(Console.ReadLine());

            rc.CreateCheque(chequeBook, bank, accountNumber);
        }

        /// <summary>
        /// Shows the interface to create money
        /// </summary>
        private void CreateMoney()
        {
            String currency;
            RegisterPaymentMethodController rc = new RegisterPaymentMethodController();

            Console.WriteLine("Insert the currency");
            currency = Console.ReadLine();

            rc.CreateMoney(currency);
        }

    }
}
