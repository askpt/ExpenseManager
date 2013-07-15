using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Model
{
    /// <summary>
    /// The class for the credit card that will implement the class card
    /// </summary>
    public class CreditCard : Card
    {
        /// <summary>
        /// The limit of credit card
        /// </summary>
        private int limit;

        /// <summary>
        /// The main constructor for the credit card
        /// </summary>
        /// <param name="cardName">the card name</param>
        /// <param name="bank">the card bank</param>
        /// <param name="owner">the card owner</param>
        /// <param name="valid">the validity of the card</param>
        /// <param name="number">the number of the card</param>
        /// <param name="limit">the limit of the card</param>
        public CreditCard(string cardName, string bank, string owner, DateTime valid, int number, int limit)
            : base(cardName, bank, owner, valid, number)
        {
            this.limit = limit;
        }
    }
}
