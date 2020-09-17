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
        16. Return "Big Even Number" when number is even, larger than 100, and a multiple of 5.
            Return "Big Number" if the number is just larger than 100.
            Return empty string for everything else.
            TOPIC: Complex Expression
        */
        public string ReturnBigEvenNumber(int number)
        {
            bool isLargeNumber = number > 100;
            bool isEven = number % 2 == 0;
            bool isDivisibleBy5 = number % 5 == 0;
            //TODO: return "big even number" when even, 100, and multiple of 5
            //if (number>100 && number % 2 == 0 && % 5 == 0)
           /* if (number >100 && number % 2 ==0 && number % 5 ==0)
            {
                return "Big even number";
            }*/

            if (isLargeNumber && isEven && isDivisibleBy5)
            {
                return "Big Even Number";
            }
                if (number > 100)
            {
                return "Big Number";
            }
            return "";
        }
        


    }
}
