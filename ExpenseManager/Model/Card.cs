using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpenseManager.Model
{
    /// <summary>
    /// The card abstract class that will implement the Payment Method class
    /// </summary>
    public abstract class Card : PaymentMethod
    {
        /// <summary>
        /// the card name
        /// </summary>
        private string cardName;
        /// <summary>
        /// the bank of the card
        /// </summary>
        private string bank;
        /// <summary>
        /// the owner of the card
        /// </summary>
        private string owner;
        /// <summary>
        /// the validity of the card
        /// </summary>
        private DateTime valid;
        /// <summary>
        /// the number of the card
        /// </summary>
        private int number;

        /// <summary>
        /// The main constructor for the card
        /// </summary>
        /// <param name="cardName">the card name</param>
        /// <param name="bank">the card bank</param>
        /// <param name="owner">the card owner</param>
        /// <param name="valid">the validity of the card</param>
        /// <param name="number">the number of the card</param>
        public Card(string cardName, string bank, string owner, DateTime valid, int number)
        {
            this.cardName = cardName;
            this.bank = bank;
            this.owner = owner;
            this.valid = valid;
            this.number = number;
        }

    }
}
