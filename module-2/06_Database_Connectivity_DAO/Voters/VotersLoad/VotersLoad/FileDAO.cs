using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VotersLoad
{
    public class FileDAO
    {
        public List<string> ReadFile(string pathname)
        {
            List<string> result = new List<string>();

            using (StreamReader reader = new StreamReader(pathname))
            {
                while (!reader.EndOfStream)
                {
                    result.Add(reader.ReadLine());
                }
            }

            return result;

        }
    }
}