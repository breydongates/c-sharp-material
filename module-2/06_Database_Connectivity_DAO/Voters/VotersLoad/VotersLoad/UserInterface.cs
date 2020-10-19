using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VotersLoad
{
    public class UserInterface
    {
        private string defaultPathname = @"C:\Users\Student\Downloads\CITY_OR_VILLAGE_BEXLEY.txt";
        private string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Voters;Integrated Security=True";

        FileDAO fileDAO;
        DatabaseDAO databaseDAO;

        public UserInterface()
        {
             fileDAO = new FileDAO();
             databaseDAO = new DatabaseDAO(connectionString);
        }

        public void Run()
        {
            Console.WriteLine("This program loads text file to Voters database.");
            Console.WriteLine($"Enter filename (Press Enter for {defaultPathname}): ");
            string pathname = Console.ReadLine();

            Console.WriteLine($"Empty tables first? (Y/n)");
            string empty = Console.ReadLine();

            if (String.IsNullOrEmpty(empty) || empty.ToLower().Substring(0, 1) == "y" )
            {
                bool ableToDelete = false;
                try
                {
                    ableToDelete = databaseDAO.DeleteData();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting table contents");
                    Console.WriteLine(ex.Message);
                }

                if (ableToDelete == false)
                {
                    Console.WriteLine("Tables already empty.");
                }
            }

            if (pathname == "")
            {
                pathname = defaultPathname;
            }

            Console.WriteLine("Reading file.");

            List<string> fileContents = new List<string>();
            try
            {
                fileContents = fileDAO.ReadFile(pathname);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file.");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Read {fileContents.Count} records.");
            Console.WriteLine("Writing to database. This will take a few seconds.");

            try
            {
                if (fileContents.Count > 0)
                {
                    databaseDAO.WriteData(fileContents);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing database.");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Done.");

            return;
       }
    }
}
