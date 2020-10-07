using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class InterviewQuestion
    {
        public InterviewQuestion(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        // This class should contain the definition for each piece of data in the CSV: ID and Text
        public string Name { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return this.Id + ") " + this.Name;
        }
    }
}
