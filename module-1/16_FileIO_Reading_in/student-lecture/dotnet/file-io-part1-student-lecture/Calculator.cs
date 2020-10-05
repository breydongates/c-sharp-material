using System;
using System.Collections.Generic;
using System.Text;

namespace FileInputLecture
{
    /// <summary>
    /// This class is responsible for generating division by zero exceptions for lecture purposes
    /// </summary>
    public class Calculator
    {
        public int Divide(int x, int y)
        {
            // TODO: Throw an argument exception here instead of allowing 0 for y

            return x / y;
        }
    }
}
