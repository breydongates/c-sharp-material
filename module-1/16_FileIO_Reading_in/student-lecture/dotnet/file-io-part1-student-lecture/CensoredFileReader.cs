using System;
using System.Collections.Generic;
using System.Text;

namespace FileInputLecture
{
    /// <summary>
    /// This class is responsible for reading data in from a specified file and printing out the text
    /// with a specific word redacted.
    /// </summary>
    public class CensoredFileReader
    {
        public CensoredFileReader(string wordToCensor, string censoredText)
        {
            this.WordToCensor = wordToCensor;
            this.CensoredText = censoredText;
        }

        public string WordToCensor { get; set; }
        public string CensoredText { get; set; }

        public void CensorFile(string filePath)
        {
            // For practice, it might be nice to validate filepath

            Console.WriteLine("Censoring the contents of " + filePath);

            // Add a using statement that creates a StreamReader pointing at the correct file

            // While we haven't reached the end of the file...

            // Read in the next line from the file

            // If the line needs censoring,
            // ... Censor the line as needed by replacing WordToCensor with CensoredText
            // ... Print the censored line to the Console

            Console.WriteLine("Done Censoring");
        }
    }
}
