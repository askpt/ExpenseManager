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
    /// The specific register income type ui
    /// </summary>
    public class IncomeTypeUI
    {
        /// <summary>
        /// The main menu of income type
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
                            ShowRegisterIncomeType();
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
        /// The visual main menu of income type
        /// </summary>
        public void Menu()
        {
            Console.WriteLine(" === Register Income Type Menu ===");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. List");

            Console.WriteLine("0. Exit\n");
        }



        /// <summary>
        /// The specific method to the register income type ui
        /// </summary>
        public void ShowRegisterIncomeType()
        {
            string key, description;

            Console.WriteLine("Insert the key for the income type");
            key = Console.ReadLine();
            Console.WriteLine("Insert the description fot the income type");
            description = Console.ReadLine();

            IncomeTypeController incTC = new IncomeTypeController();
            incTC.RegisterIncomeType(key, description);
        }

        /// <summary>
        /// Method that will list all of income types in repository
        /// </summary>
        public void List()
        {
            IncomeTypeController incTC = new IncomeTypeController();

            Console.WriteLine(" === Income Type List ===");

            List<IncomeType> list = incTC.GetAllIncomeTypes();
            int i = 0;

            foreach (IncomeType item in list)
            {
                Console.WriteLine(i);
                Console.WriteLine(item);
                Console.WriteLine("---\n");
                i++;
            }
        }
    }
}
