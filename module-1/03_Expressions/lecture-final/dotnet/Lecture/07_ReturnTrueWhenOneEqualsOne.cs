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
        7. This method uses an if to check to make sure that one is equal to one.
            Make sure it returns TRUE when one equals one.
            TOPIC: Boolean Expression & Conditional Logic
        */
        public bool ReturnTrueWhenOneEqualsOne()
        {
            int number = 1;

            if (number == 1)
            {
                return true; // The method stops executing here and returns true
            }

            return false;
        }

    }
}
