using System;
using System.Collections.Generic;
using System.IO;

namespace FizzWriter
{
   public  class Program
    {
        static void Main(string[] args)
        {
            string myPath = GetReadmeDir();
            string destFile = Path.Combine(myPath, "FizzBuzz.txt");
     
                bool exists = false;
                using (StreamWriter writer = new StreamWriter(destFile, exists))
                {


                    for (int i = 1; i <= 300; i++)
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            writer.WriteLine("FizzBuzz");
                        }
                        else if (i % 3 == 0)
                        {
                            writer.WriteLine("Fizz");
                        }
                        else if (i % 5 == 0)
                        {
                            writer.WriteLine("Buzz");
                        }
                        else
                        {
                            writer.WriteLine(i);
                        }

                }
            
        }
        /// <summary>
        /// Gets the full path to the directory with the readme file
        /// </summary>
        /// <returns>The full path to the directory with the readme file</returns>
        public static string GetReadmeDir()
        {
            string dir = Environment.CurrentDirectory;

            System.IO.DirectoryInfo netcoreappDir = System.IO.Directory.GetParent(dir);
            System.IO.DirectoryInfo binDir = System.IO.Directory.GetParent(netcoreappDir.FullName);
            System.IO.DirectoryInfo codeDir = System.IO.Directory.GetParent(binDir.FullName);
            System.IO.DirectoryInfo readmeDir = System.IO.Directory.GetParent(codeDir.FullName);

            return readmeDir.FullName;
        }

    }
}            //for (int i = 1; i <= 300; i++)
             //{
             //    if(i % 3 == 0 && i % 5 == 0)
             //    {
             //        Console.WriteLine("FizzBuzz");
             //    }
             //    else if (i % 3 == 0)
             //    {
             //        Console.WriteLine("Fizz");
             //    }
             //    else if (i % 5 == 0)
             //    {
             //        Console.WriteLine("Buzz");
             //    }
             //    else
             //    {
             //        Console.WriteLine(i);
             //    }
