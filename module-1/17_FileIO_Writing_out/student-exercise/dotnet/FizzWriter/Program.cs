using System;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
}
