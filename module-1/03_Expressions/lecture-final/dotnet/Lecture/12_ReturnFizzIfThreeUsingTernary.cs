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
        12. Now write the above using the Ternary operator ?:
        */
        public string ReturnFizzIfThreeUsingTernary(int number)
        {
            return (number == 3) ? "Fizz" : ""; // Do not use this or we will frown

            /*
            if (number == 3)
            {
                return "Fizz";
            }
            else
            {
                return ""; // "" is an empty string
            }
            */
        }
    }
}
