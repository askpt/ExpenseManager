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
        public string cardName { get; set; }
        /// <summary>
        /// the bank of the card
        /// </summary>
        public string bank { get; set; }
        /// <summary>
        /// the owner of the card
        /// </summary>
        public string owner { get; set; }
        /// <summary>
        /// the validity of the card
        /// </summary>
        public DateTime valid { get; set; }
        /// <summary>
        /// the number of the card
        /// </summary>
        public int number { get; set; }

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

        /// <summary>
        /// The ToString Method that will show the content of the card
        /// </summary>
        /// <returns>the content of expense type in this format: Card Name: cardName\nCard Number: number\nOwner: owner\nBank: bank\nValidity: valid</returns>
        public override string ToString()
        {
            return "Card Name: " + cardName + "\nCard Number: " + number + "\nOwner: " + owner + "\nBank: " + bank + "\nValidity: " + valid.Year + "/" + valid.Month;
        }

    }
}
