using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManager.View;

namespace ExpenseManager
{
    /// <summary>
    /// Main class of the project
    /// </summary>
    class ExpenseManager
    {
        /// <summary>
        /// Method that will start the project
        /// </summary>
        public static void Main()
        {
            ExpenseManagerUI emUI = new ExpenseManagerUI();
            emUI.Show();
        }
    }
}
