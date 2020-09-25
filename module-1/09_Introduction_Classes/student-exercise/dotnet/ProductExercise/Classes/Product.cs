using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Product
    {
        // Class Code Goes Here
        /// <summary>
        /// The name of the product;
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The price of the product;
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// The weight (in ounces) of the product.
        /// </summary>
        public double WeightInOunces { get; set; }
    }
}
