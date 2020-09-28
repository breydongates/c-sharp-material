using System;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }







    public class MattIsMean
    {


        public bool IsGreaterThan(int x, int y)
        {
            if (y < 0)
            {
                return false;
            }

            return x > y;
        }


        public void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                string output = "";

                if (i % 3 == 0)
                {
                    output += "Fizz";
                } 
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }

                if (output == "")
                {
                    output = i.ToString();
                }

                Console.WriteLine(output);
            }
        }


    }











}
