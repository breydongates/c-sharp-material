using System;
using System.Collections.Generic;
using System.Text;

namespace EmporiumClient.Data
{
    /// <summary>
    /// This is a client-side representation of a costume.
    /// It should contain the parts of the server-side object the client application needs to care about.
    /// </summary>
    public class Costume
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quanity { get; set; }
        public decimal PriceInDollars { get; set; }
        public string Theme { get; set; }

        public override string ToString()
        {
            return $"{Id}: {ProductName.PadRight(35)}Quantity: {Quanity}\tPrice: {PriceInDollars:C}\tTheme: {Theme}";
        }
    }
}
