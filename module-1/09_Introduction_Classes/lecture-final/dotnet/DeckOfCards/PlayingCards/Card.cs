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
        /// Creates a new card
        /// </summary>
        /// <param name="isFaceUp">Whether or not the card is face up</param>
        public Card(bool isFaceUp)
        {
            this.IsFaceUp = isFaceUp;
        }

        /// <summary>
        /// Creates a new card
        /// </summary>
        public Card()
        {
            this.IsFaceUp = true;
        }

        /// <summary>
        /// Gets or sets the numerical value of the card
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the suit the card has (Hearts, Spades, Diamonds, Clubs)
        /// </summary>
        public string Suit { get; set; }

        /// <summary>
        /// Gets or sets whether or not the card is face up
        /// </summary>
        public bool IsFaceUp { get; private set; } // = true;

        /// <summary>
        /// Gets a user-readible message for the card
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
                    return "The Card is Face Down";
                }
            }
        }

        /// <summary>
        /// Flips whether or not the card is face up
        /// </summary>
        public bool Flip()
        {
            this.IsFaceUp = !this.IsFaceUp;

            return this.IsFaceUp;
        }

        public void WeCanPassParametersToMethods(int x, int y)
        {
            Console.WriteLine(x + y);
        }
    }
}
