using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;


namespace WordSearch
{
    public class WordSearchApp
    {


        public void Run()
        {
            //1. Ask the user for the search string
            Console.WriteLine("What search word are you looking for?");
            string searchWord = Console.ReadLine();
            //2. Ask the user for the file path
            Console.WriteLine();
            Console.WriteLine("What is the fully qualified name of the file that should be searched?");
            string fileLocater = Console.ReadLine();

            Console.WriteLine("Should the search be case sensitive? (Y/N)");
           string caseSensitive = Console.ReadLine();
            if (caseSensitive == "Y")

            //3. Open the file
            {

                using (StreamReader read = new StreamReader(fileLocater))
                {
                    //4. Loop through each line in the file

                    int counter = 1;
                    while (!read.EndOfStream)
                    {

                        string line = counter++ + ") " + read.ReadLine();

                        //5. If the line contains the search string, print it out along with its line number

                        {
                            if (!line.Contains(searchWord))
                            {
                                continue;
                            }
                        }
                        Console.WriteLine(line);
                    }


                }
            }
            else if (caseSensitive == "N")
            {
                searchWord = searchWord.ToLower();
                using (StreamReader read = new StreamReader(fileLocater))
                {
                    //4. Loop through each line in the file

                    int counter = 1;
                    while (!read.EndOfStream)
                    {

                        string line = counter++ + ") " + read.ReadLine();

                        //5. If the line contains the search string, print it out along with its line number

                        {
                            if (!line.Contains(searchWord))
                            {
                                continue;
                            }
                        }
                        Console.WriteLine(line);
                    }


                }
            }

        }


        // See Part 2 in the Readme.md file for additional changes
    }
}


