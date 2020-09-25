using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.PlayingCards
{
    /// <summary>
    /// This represents a playing card in a deck
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Cretes a new card
        /// </summary>
        /// <param name="isFaceUp"></param> whether or not the card is face up
        public Card(bool isFaceUp) //Default constructor. Does not have a return type
        {
            this.IsFaceUp = isFaceUp;   
        }
        public Card()
        {
            this.IsFaceUp = true;
        }
        /// <summary>
        /// Gets or sets numerical value of card
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the suit the card has (Hearts, spades, diamonds, clubs)
        /// </summary>
        public string Suit { get; set; }

        /// <summary>
        /// gets if the suit is face up or down
        /// </summary>
        public bool IsFaceUp { get; private set; } = true; //sets default value to true

        /// <summary>
        /// Gets a user readable messge for the card
        /// </summary>
        public string DisplayText
        {
            get
            {
                if (this.IsFaceUp)
                {
                    return this.Value + " of " + this.Suit;
                }
                else
                {
                    return "This card is face down";
                }
            }
        }
        /// <summary>
        /// Flips wheter or not the card is face up
        /// </summary>
        public void Flip()
        {
            this.IsFaceUp = !this.IsFaceUp;
        }
    }
}
