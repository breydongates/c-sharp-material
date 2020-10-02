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

            if (inputNumbers % 3 == 0 && inputNumbers <= 100)
            {
                return "Fizz";
            }
            else if (inputNumbers % 5 == 0 && inputNumbers <= 100)
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
