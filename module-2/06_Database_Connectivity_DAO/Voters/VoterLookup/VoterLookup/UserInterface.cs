using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using VoterLookup.Models;

namespace VoterLookup
{
    public class UserInterface
    {
        public void Run()
        {

            int userInput = 0;

            ShowMainMenu();

            Console.WriteLine("What would you like to do?");
            int.TryParse(Console.ReadLine(), out userInput);

            while (userInput != 9)
            {
                switch (userInput)
                {
                    case 1:
                        SearchVoterByName();
                        break;

                    case 2:
                        SearchVoterByStateId();
                        break;

                    case 3:
                        SearchVotersWhoMayNotVote();
                        break;

                    case 9:
                        continue;

                    default:
                        Console.WriteLine("Not a valid choice.");
                        break;
                }

                ShowMainMenu();
                Console.WriteLine("What would you like to do?");
                int.TryParse(Console.ReadLine(), out userInput);
            }

            Console.WriteLine("THanks. Come again soon.");

        }

        private void ShowMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Main Menu");
            Console.WriteLine("---------");
            Console.WriteLine("1 - Search for voters by name");
            Console.WriteLine("2 - Search for voter by state id");
            Console.WriteLine("3 - Search for voters who may not vote");
            Console.WriteLine("9 - Exit");
        }

        private void SearchVoterByName()
        {
            Console.WriteLine("Enter a voter last name:");
            string searchString = Console.ReadLine();

            // debug - replace this secion with a call to a DAO

            List<Voter> voters = new List<Voter>
            {
                new Voter("OH12345","FR1234", "10/18/2020","Fulton", "John"),
                new Voter("OH12346","FR1235", "10/18/2020","Bruegge", "Lisa"),
                new Voter("OH12347","FR1236", "10/18/2020","Bruegge", "Chris")
            };

            // end of debug

            if (voters.Count == 0)
            {
                Console.WriteLine("No voters were found.");
            }
            else
            {
                Console.WriteLine($"Found {voters.Count} voters.");
            }

            foreach (Voter voter in voters)
            {
                Console.WriteLine(voter.StateId + " " + voter.FirstName + " " + voter.LastName);
            }

            return;
        }



        private void SearchVoterByStateId()
        {
            Console.WriteLine("Enter a state Id:");
            string stateId = Console.ReadLine();

            // debug - replace this secion with a call to a DAO

            List<Voter> voters = new List<Voter>
            {
                new Voter("OH12345","FR1234", "10/18/2020","Fulton", "John"),
                new Voter("OH12346","FR1235", "10/18/2020","Bruegge", "Lisa"),
                new Voter("OH12347","FR1236", "10/18/2020","Bruegge", "Chris")
            };

            // end of debug

            if (voters.Count == 0)
            {
                Console.WriteLine("No voters were found.");
            }
            else
            {
                Console.WriteLine($"Found {voters.Count} voters.");
                Console.WriteLine("State Id".PadRight(20) + "First Name".PadRight(20) + "Last Name".PadRight(20));
            }

            foreach (Voter voter in voters)
            {
                Console.WriteLine(voter.StateId.PadRight(20)+  voter.FirstName.PadRight(20) + voter.LastName.PadRight(20));
            }

            return;
        }

        private void SearchVotersWhoMayNotVote()
        {

            // debug - replace this secion with a call to a DAO

            List<Voter> voters = new List<Voter>
            {
                new Voter("OH12345","FR1234", "10/18/2020","Fulton", "John"),
                new Voter("OH12346","FR1235", "10/18/2020","Bruegge", "Lisa"),
                new Voter("OH12347","FR1236", "10/18/2020","Bruegge", "Chris")
            };

            // end of debug

            if (voters.Count == 0)
            {
                Console.WriteLine("No voters were found.");
            }
            else
            {
                Console.WriteLine($"Found {voters.Count} voters.");
                Console.WriteLine("State Id".PadRight(20) + "First Name".PadRight(20) + "Last Name".PadRight(20));
            }

            foreach (Voter voter in voters)
            {
                Console.WriteLine(voter.StateId.PadRight(20) + voter.FirstName.PadRight(20) + voter.LastName.PadRight(20));
            }

            return;
        }

    }
}
