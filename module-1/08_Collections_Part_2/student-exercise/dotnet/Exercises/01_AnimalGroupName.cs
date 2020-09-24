using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> returnGroup = new Dictionary<string, string>();
            returnGroup.Add("rhino", "Crash");
            returnGroup.Add("giraffe", "Tower");
            returnGroup.Add("elephant", "Herd");
            returnGroup.Add("lion", "Pride");
            returnGroup.Add("crow", "Murder");
            returnGroup.Add("pigeon", "Kit");
            returnGroup.Add("flamingo", "Pat");
            returnGroup.Add("deer", "Herd");
            returnGroup.Add("dog", "Pack");
            returnGroup.Add("crocodile", "Float");


            if (animalName != null)
            {
                    animalName = animalName.ToLower();
                if (returnGroup.ContainsKey(animalName))
                {

                    return returnGroup[animalName];
                }

                else
                { return "unknown"; }

            }
            return "unknown";
        }
    }
}
    

