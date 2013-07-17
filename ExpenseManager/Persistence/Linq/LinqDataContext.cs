using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpenseManager.Model;

namespace ExpenseManager.Persistence.Linq
{
    /// <summary>
    /// The connection class for the Linq database
    /// </summary>
    public class LinqDataContext : DataContext
    {
        /// <summary>
        /// the running instance of data context
        /// </summary>
        private static LinqDataContext instance = null;

        /// <summary>
        /// The expense type table
        /// </summary>
        public Table<ExpenseType> ExpenseType;

        /// <summary>
        /// The payment method table
        /// </summary>
        public Table<PaymentMethod> PaymentMethod;

        /// <summary>
        /// This method will connect the server and will create a new database
        /// </summary>
        private LinqDataContext()
            : base("server=ANDRÉ;initial catalog=ExpenseManager;Integrated Security=SSPI;", XmlMappingSource.FromUrl("Mapping.xml"))
        {
            if (!base.DatabaseExists())
                base.CreateDatabase();
        }

        /// <summary>
        /// the method that will access the instance of repository
        /// </summary>
        /// <returns>the running instance of repository</returns>
        public static LinqDataContext GetInstance() {
            if (instance == null)
            {
                instance = new LinqDataContext();
            }

            return instance;
        }
    }
}
