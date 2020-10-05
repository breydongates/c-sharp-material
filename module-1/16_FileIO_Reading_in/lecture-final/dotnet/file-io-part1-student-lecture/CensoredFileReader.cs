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

        public void CensorFile(string filePath)
        {
            // For practice, it might be nice to validate filepath

            Console.WriteLine("Censoring the contents of " + filePath);

            try
            {
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
                            // ... Censor the line as needed by replacing WordToCensor with CensoredText
                            line = line.Replace(this.WordToCensor, this.CensoredText);

                            // ... Print the censored line to the Console
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Could not find the file " + filePath);
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred trying to read from the file: " + ex.Message);
            }

            Console.WriteLine("Done Censoring");
        }
    }
}
