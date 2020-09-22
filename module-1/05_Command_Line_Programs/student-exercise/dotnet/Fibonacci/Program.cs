using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // When you're working on your homework, get rid of the code below

            // We'll modify the line below to create a merge conflict together
            // int first = 0;
            // int second = 1;
            // int next = 0;
            // int max = 6; // this replaces the user would type

            // Console.WriteLine (first + " " + second + " ");
            // need to start at 0, then 1. start in [2]. make the first 2 0, 1
            //  while (next > max)
            // {
            //  Console.WriteLine(next + " ");
            //  next = first + second;

            //first = second;
            // second = next;

            int first = 0;
            int second = 1;
            int next = 0;
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the Fibonacci number: ");
                int enterNumber = int.Parse(Console.ReadLine());
                for (int i = 1; i < enterNumber; i++)
                    
                   {
                    
                   // while (next > enterNumber) 
                    {
                        
                        Console.Write(next );
                        next = first + second;
                        first = second;
                        second = next;
                    }
                    }
                
            }
          
            
          
            
            Console.WriteLine(); 
         //   }


        }
    }
}
