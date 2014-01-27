using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManager.View;
using ExpenseManager.Persistence;
using ExpenseManager.Model;

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
            Properties.GetInstance().Load();

            if (Properties.GetInstance().useBootstrap)
            {
                Bootstrapper bs = new Bootstrapper();
                bs.StartBootstrap();
            }
            ExpenseManagerUI emUI = new ExpenseManagerUI();
            emUI.Show();
        }
    }

    /// <summary>
    /// The properties class where will be written te main configuration
    /// </summary>
    class Properties
    {
        /// <summary>
        /// This will allow the user to setup the startup balance
        /// </summary>
        public double startupBalance { get; set; }
        /// <summary>
        /// The source repository (InMemory, Database, ...)
        /// </summary>
        public string repositorySource { get; set; }
        /// <summary>
        /// This will allow the use of bootstrap for testing purpose
        /// </summary>
        public bool useBootstrap { get; set; }
        /// <summary>
        /// the singleton instance of properties
        /// </summary>
        private static Properties instance = null;
        /// <summary>
        /// the method that will access the instance of running properties
        /// </summary>
        /// <returns>the running instance of properties</returns>
        public static Properties GetInstance()
        {
            if (instance == null)
            {
                instance = new Properties();
            }
            return instance;
        }
        /// <summary>
        /// the private constructor of the properties and will run with default settings
        /// </summary>
        private Properties()
        {
            repositorySource = "InMemory";
            useBootstrap = true;
        }
        /// <summary>
        /// this method will load the user file configuration properties
        /// </summary>
        public void Load()
        {
            //TODO add the file to be read
        }
    }

    /// <summary>
    /// The bootstrap class for the expenses
    /// </summary>
    public class Bootstrapper
    {
        /// <summary>
        /// Method that will call all the bootstrappers
        /// </summary>
        public void StartBootstrap()
        {
            ExpenseTypeBoot();
            IncomeTypeBoot();
            PaymentMethodBoot();
            ExpenseBoot();
            IncomeBoot();
        }

        /// <summary>
        /// Bootstrapper for the income type
        /// </summary>
        private void IncomeTypeBoot()
        {
            IIncomeTypeRepository repo = PersistenceFactory.GetFactory().GetRepository().GetIncomeTypeRepository();

            repo.Save(new IncomeType("SAL", "Salary"));
            repo.Save(new IncomeType("GIF", "Gift"));
            repo.Save(new IncomeType("REI", "Reimbursements"));
        }

        /// <summary>
        /// Bootstrapper for the expense type
        /// </summary>
        private void ExpenseTypeBoot()
        {
            IExpenseTypeRepository repo = PersistenceFactory.GetFactory().GetRepository().GetExpenseTypeRepository();

            repo.Save(new ExpenseType("FOO", "Food"));
            repo.Save(new ExpenseType("CLO", "Cloths"));
            repo.Save(new ExpenseType("SPO", "Sports"));
        }

        /// <summary>
        /// Bootstrapper for the payment method
        /// </summary>
        private void PaymentMethodBoot()
        {
            IPaymentMethodRepository repo = PersistenceFactory.GetFactory().GetRepository().GetPaymentMethodRepository();

            repo.Save(new CreditCard("VISA", "BES", "Silva", new DateTime(2014, 12, 31), 115313858, 57));
            repo.Save(new DebitCard("Maestro", "CGD", "Brown", new DateTime(2013, 12, 31), 135151681));
            repo.Save(new Cheque("ChequeBook A1", "Totta", 234348384));
            repo.Save(new Money("EUR"));
        }

        /// <summary>
        /// Bootstrapper for the expense
        /// </summary>
        private void ExpenseBoot()
        {
            List<ExpenseType> types = PersistenceFactory.GetFactory().GetRepository().GetExpenseTypeRepository().All();
            List<PaymentMethod> methods = PersistenceFactory.GetFactory().GetRepository().GetPaymentMethodRepository().All();
            IExpenseRepository repo = PersistenceFactory.GetFactory().GetRepository().GetExpenseRepository();

            Payment pay1 = new Payment(methods[0], 15);
            repo.Save(new Expense(types[0], pay1, new DateTime(2013, 12, 30, 15, 30, 00), "MacDonalds"));

            PaymentCheque pay2 = new PaymentCheque(methods[2], 23, 1257);
            repo.Save(new Expense(types[2], pay2, new DateTime(2013, 08, 03, 10, 58, 00), "Soccer"));

            repo.Save(new Expense(types[2], pay2, new DateTime(2014, 01, 19, 10, 58, 00), "Soccer 2"));
        }

        /// <summary>
        /// Bootstrapper for the income
        /// </summary>
        private void IncomeBoot()
        {
            List<IncomeType> types = PersistenceFactory.GetFactory().GetRepository().GetIncomeTypeRepository().All();
            IIncomeRepository repo = PersistenceFactory.GetFactory().GetRepository().GetIncomeRepository();

            repo.Save(new Income("AAA", DateTime.Now, 15, types[0]));
            repo.Save(new Income("BBB", new DateTime(2013, 12, 31, 21, 20, 00), 17, types[1]));
        }
    }
}
