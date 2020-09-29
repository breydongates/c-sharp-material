using System;

namespace Lecture
{
    class Program
    {
        static void Main()
        {
            Farm farm = new Farm();

            farm.IsEvening = false; // We'll want to change this to see what happens

            farm.SingAbout();

            Console.ReadLine();
        }
    }
}