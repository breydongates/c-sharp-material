using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class RefactorMe
    {
        public string FrontTimes(string input, int timesToRepeat)
        {
            string result = "";

            // Maximum number of characters to repeat
            int maxCharacters = 3;

            for (int i = 0; i < timesToRepeat; i++)
            {
                // We need to worry about IndexOutOfRange with strings < maxCharacters long
                if (input.Length < maxCharacters)
                {
                    result += input;
                }
                else
                {
                    result += input.Substring(0, maxCharacters);
                }
            }

            return result;
        }
    }
}