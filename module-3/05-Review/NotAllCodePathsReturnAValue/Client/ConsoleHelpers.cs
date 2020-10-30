using EmporiumClient.Data;
using System;
using System.Collections.Generic;

namespace EmporiumClient
{
    public class ConsoleHelpers
    {
        public void PrintCostumes(List<Costume> costumes)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Costumes");
            Console.WriteLine("--------------------------------------------");
            foreach (Costume costume in costumes)
            {
                Console.WriteLine(costume); // Calls .ToString()
            }
        }

        public int PromptForCostumeId(List<Costume> costumes, string action)
        {
            PrintCostumes(costumes);
            Console.WriteLine("");
            Console.Write("Please enter a costume ID to " + action + ": ");
            if (!int.TryParse(Console.ReadLine(), out int reservationId))
            {
                Console.WriteLine("Invalid input. Only input a number.");
                return 0;
            }
            else
            {
                return reservationId;
            }
        }

    }
}
