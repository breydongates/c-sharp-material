using System;
using System.IO;

namespace FileInputLecture
{
    class Program
    {
        static void Main(string[] args) // What can we do with these args?
        {
            // It'd be nice if we didn't have to escape this string...
            string myPath = "C:\\Users\\Student";
            
            string sourceFile = Path.Combine(myPath, "alice.txt");
            string destFile = Path.Combine(myPath, "redacted.txt");

            // Create a redacted copy of the modified lines from source file in redacted.txt
            CensoredFileReader censor = new CensoredFileReader("Alice", "[REDACTED]");
            censor.CensorFile(sourceFile, destFile);
        }
    }
}
