using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    /// <summary>
    /// this is an auction that can suddenly end when a Buyout amount is reached 
    /// </summary>
    public class BuyoutAuction : Auction
    {

        public int BuyoutAuction (string item) : base(item)
        {

        }
        public int BuyoutAmount { get; set; } = 100000;


        public override bool PlaceBid(Bid offeredBid)
        {
            bool isHighBid = base.PlaceBid(offeredBid);

            if (offeredBid.BidAmount >= this.BuyoutAmount )
            {
                this.EndAuction();
                
            }
            return base.PlaceBid(offeredBid);
        }
    }
}
