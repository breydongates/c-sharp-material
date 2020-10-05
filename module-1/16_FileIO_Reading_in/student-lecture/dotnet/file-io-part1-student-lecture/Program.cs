using System;
using System.IO;

namespace FileInputLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // First we'll want to catch exceptions from this operation
            Calculator calculator = new Calculator();
            int result = calculator.Divide(42, 0);
            Console.WriteLine("42 / 0 = " + result);

            // For practice, we'll take a look at Directory, Environment, Path, and File

            // Next we're going to demonstrate working with reading files
            CensoredFileReader censor = new CensoredFileReader("Cat", "Doggo");

            string filePath = ""; // TODO: Set this to the correct path

            // We'll want to practice working with reading files by uncommenting this line
            // censor.CensorFile(filePath);

            // Allow the user to press a key
            Console.ReadLine();
        }
    }
}
