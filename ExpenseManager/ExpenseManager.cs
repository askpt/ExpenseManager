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
        }

        /// <summary>
        /// Bootstrapper for the expense type
        /// </summary>
        private void ExpenseTypeBoot(){
            IExpenseTypeRepository repo = PersistenceFactory.GetFactory().GetRepository().GetExpenseTypeRepository();

            repo.Save(new ExpenseType("FOO", "Food"));
            repo.Save(new ExpenseType("CLO", "Cloths"));
            repo.Save(new ExpenseType("SPO", "Sports"));    
        }

    }
}
