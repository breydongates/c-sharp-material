using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureExample
    {
        /*
        16. Return "Big Even Number" when number is even, larger than 100, 
            and a multiple of 5.

            Return "Big Number" if the number is just larger than 100.

            Return empty string for everything else.
            TOPIC: Complex Expression
        */
        public string ReturnBigEvenNumber(int number)
        {
            bool isLargeNumber = number > 100;
            bool isEven = number % 2 == 0;
            bool isDivisibleBy5 = number % 5 == 0;

            // return "Big Even Number" when even, > 100, and multiple of 5
            if (isLargeNumber && isEven && isDivisibleBy5)
            {
                return "Big Even Number";
            }

            // return "Big Number" if > 100
            if (isLargeNumber)
            {
                return "Big Number";
            }

            return "";
        }
        


    }
}
