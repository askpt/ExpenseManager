﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.Model
{
    /// <summary>
    /// The class for the debit card that will implement the class card
    /// </summary>
    public class DebitCard : Card
    {
        /// <summary>
        /// The main constructor for the debit card
        /// </summary>
        /// <param name="cardName">the card name</param>
        /// <param name="bank">the card bank</param>
        /// <param name="owner">the card owner</param>
        /// <param name="valid">the validity of the card</param>
        /// <param name="number">the number of the card</param>
        public DebitCard(string cardName, string bank, string owner, DateTime valid, int number)
            : base(cardName, bank, owner, valid, number)
        {
        }

        /// <summary>
        /// The ToString Method that will show the content of the debit card
        /// </summary>
        /// <returns>the content of expense type in this format: Debit Card\nCard Name: cardName\nCard Number: number\nOwner: owner\nBank: bank\nValidity: valid</returns>
        public override string ToString()
        {
            return "Debit Card\n" + base.ToString();
        }
    }
}
