using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureProblem
    {

        /*
        6. How can we write a for loop that sums up the values in this array?
           TOPIC: For Loops
        */
        public int ReturnSumArray()
        {
            int[] arrayToLoopThrough = { 3, 4, 2, 9 };
            int sum = 0;
           
            for (int index = 0; index <= arrayToLoopThrough.Length ; index++ )
                //     ^ starts loop at beginning  ^is this the end of array? ^ go on to next, increase by 1 until end
            {
              sum += arrayToLoopThrough[index];
                // will grab 3, then add to sum. will grab 4, then add to sum, etc.
                // could also use sum += arrayToLoopThrough[index];

            }

            return sum; // sum of 3+4+2+9
        }
    }
}
