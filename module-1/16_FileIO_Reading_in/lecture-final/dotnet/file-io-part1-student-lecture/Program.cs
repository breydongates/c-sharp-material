using System;
using System.IO;

namespace FileInputLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // First we'll want to catch exceptions from this operation
                Calculator calculator = new Calculator();
                int result = calculator.Divide(42, 0);
                Console.WriteLine("42 / 0 = " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Oh noes! You divided by 0: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please give the calculator valid values: " + ex.Message);
            }
            /* - DO NOT do this. This makes Matt frown.
            catch (Exception ex)
            {
                // Don't care about errors
            }
            */

            // For practice, we'll take a look at Directory, Environment, Path, and File

            // Directory - Manipulate direcories and list contents
            // Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string basePath = "C:\\Users";
            //string myPath = Path.Combine(basePath, "Student");
            // File.

            string myPath = "C:\\Users\\Student\\code\\c-sharp-material\\module-1\\16_FileIO_Reading_in\\student-lecture\\dotnet";
            string[] files = Directory.GetFiles(myPath);

            // Next we're going to demonstrate working with reading files
            CensoredFileReader censor = new CensoredFileReader("Cat", "Doggo");

            string filePath = Path.Combine(myPath, "alicia.txt");

            // We'll want to practice working with reading files by uncommenting this line
            censor.CensorFile(filePath);

            // Allow the user to press a key
            Console.ReadLine();
        }
    }
}
