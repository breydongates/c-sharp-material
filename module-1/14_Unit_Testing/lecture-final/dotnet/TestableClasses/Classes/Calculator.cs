using System;
using System.Collections.Generic;
using System.Text;

namespace TestableClasses.Classes
{
    public class Calculator
    {
        public int GetAbsoluteValue(int number)
        {
            return number * -1;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Divide(int x, int y)
        {
            return x / y; // Divide(x, y);
        }

        public int GetLargestValue(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 0)
            {
                return 0;
            }

            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        public Dictionary<int, int> GetCountOfNumbers(IEnumerable<int> numbers)
        {
            Dictionary<int, int> results = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (results.ContainsKey(number))
                {
                    results[number] += 1;
                } 
                else
                {
                    results[number] = 1;
                }
            }

            return results;
        }
    }
}
