using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class RefactorMe
    {
        public string FrontTimes(string input, int timesToRepeat)
        {
            string resultString = "";
            //Maximum number of characters to repeat
            const int MaxCharacters = 3;
            //if (input.Length <= MaxCharacters)
            //{
            //    for (int i = 0; i < timesToRepeat; i++)
            //    {
            //        resultString += input;
            //    }
            //    return resultString;
            //}
            //else
            //{
            for (int i = 0; i < timesToRepeat; i++)
            {
                if (input.Length < MaxCharacters)
                {
                    resultString += input;
                }
                else
                {
                    resultString += input.Substring(0, MaxCharacters);
                }
            }
                return resultString;
        }
    }
}
