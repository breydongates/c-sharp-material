using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {/// <summary>
     /// current calculated value
     /// </summary>
        public int Result { get; private set; }
        /// <summary>
        /// adds to result 
        /// </summary>
        /// <param name="addened"></param>
        /// <returns></returns>
        public int Add(int addened)
        { Result = Result + addened;
            return Result;
        }
        public int Multiply(int multiplier)
        { 
            Result = Result * multiplier;
            return Result;
        }
        public int Power(int exponent)
        {
            Result = Result * Result;//Math.Abs(exponent);
            return Result;
        }
        public void Reset()
        { 
            
            Result= 0;
            
        }
        public int Subtract(int subtrahend)
        {
            Result = Result - subtrahend;
            return Result;
        }
    }
}
