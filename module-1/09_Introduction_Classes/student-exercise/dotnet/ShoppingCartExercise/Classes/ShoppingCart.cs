using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {/// <summary>
    /// number of items in cart
    /// </summary>
        public int TotalNumberOfItems { get; private set; }
        /// <summary>
        /// total for the shopping cart
        /// </summary>
        public decimal TotalAmountOwed { get; private set; }

        public decimal GetAveragePricePerItem()
        {
            if (TotalNumberOfItems > 0)
            {
                return TotalAmountOwed / TotalNumberOfItems;
            }
            else return 0;

}

public void AddItems(int numberOfItems, decimal pricePerItem)
        { TotalNumberOfItems = TotalNumberOfItems  + numberOfItems;
            TotalAmountOwed = pricePerItem * numberOfItems;
        }
        public void Empty()
        {
            TotalNumberOfItems = 0;
            TotalAmountOwed = 0;
        }

    }
}
