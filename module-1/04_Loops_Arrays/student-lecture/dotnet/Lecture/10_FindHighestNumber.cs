﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureProblem
    {
        /*
         10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers)
        {
            int highestValue = 0;

            for ( int i = 0; i < randomNumbers.Length; i++)
            {
                int value = randomNumbers[i]; // pulls random number
                if( value > highestValue )
                {
                    highestValue = value;
                }
            }
            return highestValue ;
        }
    }
}