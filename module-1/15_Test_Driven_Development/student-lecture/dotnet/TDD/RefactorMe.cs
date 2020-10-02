using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class RefactorMe
    {
        public string FrontTimes(string str, int n)
        {
            string myEpicString = "";

            if (str.Length <= 3)
            {
                for (int i = 0; i < n; i++)
                {
                    myEpicString += str;
                }
                return myEpicString;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    myEpicString += str.Substring(0, 3);
                }
                return myEpicString;
            }
        }
    }
}