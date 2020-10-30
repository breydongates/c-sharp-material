using EmporiumClient.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmporiumClient
{
    public class UserInterface
    {
        private readonly CostumeApi apiService = new CostumeApi();
        private readonly ConsoleHelpers console = new ConsoleHelpers();

        public void ShowMainMenu()
        {
            Console.WriteLine("Welcome to Ben & Vinny's Halloween Costume Emporium!");

            int menuSelection = -1;
            while (menuSelection != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1: List Costumes");
                Console.WriteLine("2: Add Costume");
                Console.WriteLine("3: Update Existing Costume");
                Console.WriteLine("4: Delete Costume");
                Console.WriteLine("0: Exit");
                Console.WriteLine("---------");
                Console.Write("Please choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out menuSelection))
                {
                    Console.WriteLine("Invalid input. Only input a number.");
                }
                else
                {
                    switch (menuSelection)
                    {
                        case 1: // List costumes
                            DisplayCostumes();
                            break;

                        case 2: // Add costumes
                            HandleAddCostume();
                            break;

                        case 3: // Update costumes
                            HandleUpdateExistingCostume();
                            break;

                        case 4: // Delete costume
                            HandleDeleteCostume();
                            break;

                        case 0:
                            Console.WriteLine("See you all later, you cool cats and kittens");
                            break;

                        default:
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                    }
                }
            }
        }

        private void HandleDeleteCostume()
        {
            List<Costume> costumes = apiService.GetCostumes();
            if (costumes != null)
            {
                int id = console.PromptForCostumeId(costumes, "delete");
                apiService.DeleteCostume(id);
            }
        }

        private void HandleUpdateExistingCostume()
        {
            // Update an existing costume
            List<Costume> costumes = apiService.GetCostumes();
            if (costumes == null)
            {
                return;
            }

            int id = console.PromptForCostumeId(costumes, "update");
            Costume costume = apiService.GetCostume(id);

            if (costume == null)
            {
                return;
            }

            Console.WriteLine("What's the name of the costume? Current: " + costume.ProductName);
            costume.ProductName = Console.ReadLine();

            Console.WriteLine("What's the theme of the costume? Current: " + costume.Theme);
            costume.Theme = Console.ReadLine();

            Console.WriteLine("What's the price of the costume? Current: " + costume.PriceInDollars.ToString("C"));
            costume.PriceInDollars = decimal.Parse(Console.ReadLine()); // Note: Feel free to improve this code

            Console.WriteLine("What quantity is currently in stock? Current: " + costume.Quanity);
            costume.Quanity = int.Parse(Console.ReadLine()); // Note: Feel free to improve this code

            Costume updatedCostume = apiService.UpdateCostume(costume);
            if (updatedCostume != null)
            {
                Console.WriteLine("Costume successfully updated.");
            }
            else
            {
                Console.WriteLine("Costume not updated.");
            }
        }

        private void HandleAddCostume()
        {
            // Create new costume
            Costume costume = new Costume();

            Console.WriteLine("What's the name of the costume?");
            costume.ProductName = Console.ReadLine();

            Console.WriteLine("What's the theme of the costume?");
            costume.Theme = Console.ReadLine();

            Console.WriteLine("What's the price of the costume?");
            costume.PriceInDollars = decimal.Parse(Console.ReadLine()); // Note: Feel free to improve this code

            Console.WriteLine("What quantity is currently in stock?");
            costume.Quanity = int.Parse(Console.ReadLine()); // Note: Feel free to improve this code

            Costume added = apiService.AddCostume(costume);
            if (added != null)
            {
                Console.WriteLine("Costume successfully added.");
            }
            else
            {
                Console.WriteLine("Costume not added.");
            }
        }

        private void DisplayCostumes()
        {
            List<Costume> costumes = apiService.GetCostumes();

            if (costumes != null && costumes.Count > 0)
            {
                console.PrintCostumes(costumes);
            }
        }
    }
}
