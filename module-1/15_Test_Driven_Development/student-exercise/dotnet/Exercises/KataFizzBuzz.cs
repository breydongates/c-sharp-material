using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string NumsToString(int inputNumbers)
        {
            // return empty string if less than 0 or greater than 100
             if (inputNumbers <= 0 || inputNumbers >= 100)
            {
                return "";
            }
             
            
             // if divisible by 3 & 5, return FizzBuzz. If Contains 3 & 5, return FizzBuzz
            else if (inputNumbers % 5 == 0 && inputNumbers % 3 == 0 && inputNumbers <= 100 || inputNumbers.ToString().Contains("3") && inputNumbers.ToString().Contains("5") && inputNumbers <=100)
            {
                return "FizzBuzz";
            }
            // if divisible by 3, return Fizz. If Contains 3, return Fizz
            else if (inputNumbers % 3 == 0 && inputNumbers <= 100 || inputNumbers.ToString().Contains("3") && inputNumbers <= 100)
            {
                return "Fizz";
            }
            // if divisible by 5, return Buzz. If Contains 5, return Buzz
            else if (inputNumbers % 5 == 0 && inputNumbers <= 100 || inputNumbers.ToString().Contains("5") && inputNumbers <= 100)
            {
                return "Buzz";
            }
            else
            {
                return inputNumbers.ToString();
            }




        }


    }
}
