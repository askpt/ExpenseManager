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
    public class RegisterExpenseTypeUI
    {
        /// <summary>
        /// The specific method to the register expense type ui
        /// </summary>
        public void Show()
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
