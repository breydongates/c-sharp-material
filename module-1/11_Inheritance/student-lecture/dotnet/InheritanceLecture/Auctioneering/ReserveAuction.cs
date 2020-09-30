using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{/// <summary>
/// respresents an aucton that only acccepts bids over a specific amount (a reserve amount)
/// </summary>
    public class ReserveAuction : Auction //reserve auction inherits from auction
    {
        public ReserveAuction(int reserveAmount)
        {
            this.ReserveAmount = reserveAmount;
        }

        public int ReserveAmount { get; set; }

        public override bool PlaceBid(Bid offeredBid)
        {

            // only accept bids that meet the reserve amount
            if (offeredBid.BidAmount >= this.ReserveAmount)
            { return base.PlaceBid(offeredBid); }

            return false;
        }
    }
}
