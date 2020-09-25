using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Person
    {
        //Class Code Goes Here
        /// <summary>
        /// The first name of the person.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The last name of the person.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The age of the person.
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Returns the first and last name of the person separated by a space. For instance, "Sonny Koufax".
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        /// <summary>
        /// Returns true if the person is 18 or older.
        /// </summary>
        /// <returns></returns>
        public bool IsAdult()
        {
            if (Age >= 18)
            {
                return true;
            }
            return false;
        }
    }
}
