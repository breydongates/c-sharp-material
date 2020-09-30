using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            Auction generalAuction = new Auction("Up");
            
            generalAuction.PlaceBid(new Bid("Matt", 1));
            generalAuction.PlaceBid(new Bid("John", 23));
            generalAuction.PlaceBid(new Bid("Rick Astley", 13));
            //....
            // This might go on until the auction runs out of time or hits a max # of bids

            // TODO: Add a reserve auction where bids don't count if they're below a threshhold
            ReserveAuction reserveAuction = new ReserveAuction(150);
            reserveAuction.PlaceBid(new Bid("Matt", 50));
            reserveAuction.PlaceBid(new Bid ("Katie", 50000));
            // TODO: Add a buyout auction where a high bid can win the auction outright
            BuyoutAuction buyAuction = new BuyoutAuction();
            buyAuction.PlaceBid(new Bid("Bruce wayne", 42));
            buyAuction.PlaceBid(new Bid("clark kent", 250));
            buyAuction.PlaceBid(new Bid("Bruce wayne", 300));
            buyAuction.PlaceBid(new Bid("clark kent", 400));
            buyAuction.PlaceBid(new Bid("Bruce wayne", 100000));
            buyAuction.PlaceBid(new Bid("clark kent", 100001));
            Console.ReadLine();
        }
    }
}
