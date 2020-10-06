using System;
using System.Collections.Generic;
using System.IO;
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

        public void CensorFile(string sourceFilePath, string destFilePath)
        {
            try
            {
                Console.WriteLine($"Censoring the contents of {sourceFilePath}");
                
                List<string> censoredStrings = BuildCensoredStrings(sourceFilePath);

                WriteCensoredStrings(censoredStrings, destFilePath);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Could not find the file {sourceFilePath}: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred trying to censor the file: {ex.Message}");
            }
            // TODO: This would be good to put in a finally
            Console.WriteLine("Done Censoring");
        }

        private void WriteCensoredStrings(List<string> contents, string destFilePath)
        {
            // Open a StreamWriter to overwrite the file with new contents

            // Loop over censored strings and write each one to the file
        }

        private List<string> BuildCensoredStrings(string filePath)
        {
            List<string> censoredStrings = new List<string>();

            // Add a using statement that creates a StreamReader pointing at the correct file
            using (StreamReader reader = new StreamReader(filePath))
            {
                // While we haven't reached the end of the file...
                while (!reader.EndOfStream)
                {
                    // Read in the next line from the file
                    string line = reader.ReadLine();

                    // If the line needs censoring,
                    if (line.Contains(this.WordToCensor))
                    {
                        // Censor the line as needed by replacing WordToCensor with CensoredText
                        line = line.Replace(this.WordToCensor, this.CensoredText);

                        // Add the censored string to a collection of strings
                        censoredStrings.Add(line);
                        Console.WriteLine(line);
                    }
                }
            }

            return censoredStrings;
        }
    }
}
