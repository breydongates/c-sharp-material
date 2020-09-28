namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// This class represents a single bid in an auction.
    /// </summary>
    public class Bid // : object
    {
        /// <summary>
        /// Constructor for Bid object. Each Bid requires a bidder and bidAmount
        /// </summary>
        /// <param name="bidder">Who is bidding</param>
        /// <param name="bidAmount">How much bid is for</param>
        public Bid(string bidder, int bidAmount)
        {
            this.Bidder = bidder;
            this.BidAmount = bidAmount;
        }

        /// <summary>
        /// The bidder name.
        /// This is a readonly property
        /// </summary>
        public string Bidder { get; }

        /// <summary>
        /// The bid amount.
        /// This is a readonly property
        /// </summary>
        public int BidAmount { get; }

        public override string ToString()
        {
            return this.Bidder + " bid " + this.BidAmount;
        }

    }
}
