using System;
using System.Collections.Generic;
using System.Text;

namespace TestableClasses.Classes
{
    public class StringHelper
    {
        public string MakeAbba(string a, string b)
        {
            return a + b + b + a;
        }

        public string GetFirstString(string[] strings)
        {
            return strings[0];
        }

        public string[] ConvertToUpperCase(string[] otherStrings)
        {
            string[] output = new string[otherStrings.Length];

            for (int i = 0; i < otherStrings.Length; i++)
            {
                output[i] = otherStrings[i].ToUpper();
            }

            return output;
        }

    }
}
