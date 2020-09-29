using System;
using System.Collections.Generic;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// This class represents a general auction.
    /// </summary>
    public class Auction
    {
        private readonly List<Bid> allBids = new List<Bid>();
        private string auctioneer;

        /// <summary>
        /// Creates a new instance of an auction
        /// </summary>
        public Auction(string itemName)
        {
            // Auctions are easier to work with if they have a default high bid
            this.CurrentHighBid = new Bid("Nobody", 0);
            this.auctioneer = "Randy Savage";
            this.Item = itemName;

            Console.WriteLine("Starting a new auction for " + itemName);
        }

        public string Item { get; set; }

        /// <summary>
        /// Gets or sets the current auctioneer.
        /// This is a complex property.
        /// </summary>
        public string Auctioneer
        {
            get
            {
                return this.auctioneer;
            }
            set
            {
                // value is the right hand side when we call myAuction.Auctioneer = "something".
                this.auctioneer = value;

                // We can do whatever logic we want in a setter. Set other variables, 
                // change value to something else, etc.
                Console.WriteLine("Changing auctioneer to " + value);
            }
        }
        /*
        public string GetAuctioneer()
        {
            return this.auctioneer;
        }
        public void SetAuctioneer(string value)
        {
            this.auctioneer = value;
            Console.WriteLine("Changing auctioneer to " + value);
        }
        */

        /// <summary>
        /// The location of the auction.
        /// This is an auto property.
        /// </summary>
        public string Location { get; set; } = "Tech Elevator";

        /// <summary>
        /// Represents the current high bid.
        /// This is a property with a private setter.
        /// </summary>
        public Bid CurrentHighBid { get; private set; }

        /// <summary>
        /// All placed bids returned as an array.
        /// This is a derived property, because it's doing calculations on another value.
        /// </summary>
        public Bid[] AllBids
        {
            get { return allBids.ToArray(); }
        }

        /// <summary>
        /// Indicates if the auction has ended yet.
        /// This is a property with a private setter.
        /// </summary>
        public bool HasEnded { get; private set; }

        protected void EndAuction()
        {
            Console.WriteLine("The auction is over!");
            this.HasEnded = true;
        }

        /// <summary>
        /// Places a Bid on the Auction
        /// </summary>
        /// <param name="offeredBid">The bid to place.</param>
        /// <returns>True if the new bid is the current winning bid</returns>
        public virtual bool PlaceBid(Bid offeredBid)
        {
            if (this.HasEnded)
            {
                Console.WriteLine("The auction is currently closed");
                return false;
            }

            // Print out the bid details.
            Console.WriteLine($"{offeredBid.Bidder} bid {offeredBid.BidAmount.ToString("C")}");

            // Record it as a bid by adding it to allBids
            this.allBids.Add(offeredBid);

            // Check to see IF the offered bid is higher than the current bid amount
            if (offeredBid.BidAmount > this.CurrentHighBid.BidAmount)
            {
                // if yes, set offered bid as the current high bid
                this.CurrentHighBid = offeredBid;
            }

            // Output the current high bid
            Console.WriteLine("The current high bid is " + CurrentHighBid.BidAmount.ToString("C") + " by " + CurrentHighBid.Bidder);

            // Return if this is the new highest bid
            return this.CurrentHighBid == offeredBid;
        }                
    }
}
