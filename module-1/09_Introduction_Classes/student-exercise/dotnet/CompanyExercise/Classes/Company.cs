using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        /// <summary>
        /// The company name
        /// </summary>
    public string Name { get; set; }
        /// <summary>
        /// The number of employees at company
        /// </summary>
    public int NumberOfEmployees { get; set; }
        /// <summary>
        /// The annual revenue of the company 
        /// </summary>
    public decimal Revenue { get; set; }
    /// <summary>
    /// The annual expenses of the company
    /// </summary>
    public decimal Expenses { get; set; }

        public string GetCompanySize()
        {
            
            {
                // Returns "small" if less than 50 employees
                if(NumberOfEmployees < 50)
                {
                    return "small";
                }
                //returns "medium" if between 50 and 250 employees
                if (NumberOfEmployees >= 50 && NumberOfEmployees <= 250)
                {
                    return "medium";
                }
                //returns "large" if greater than 250 employees
                if(NumberOfEmployees >250)
                {
                    return "large";
                }
                else
                { return ""; }
            }
        }
        public decimal GetProfit()
        {
            return Revenue - Expenses;
        }
    }
}
