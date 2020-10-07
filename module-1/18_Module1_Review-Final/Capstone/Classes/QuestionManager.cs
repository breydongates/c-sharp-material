using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    /// <summary>
    /// This class is responsible for holding interview questions and providing random questions to users
    /// </summary>
    public class QuestionManager
    {
        public QuestionManager()
        {
            // this.items.Add(new InterviewQuestion("What’s the difference between C# and .NET?", 1));
        }

        private List<InterviewQuestion> items = new List<InterviewQuestion>();

        public List<InterviewQuestion> AllQuestions
        {
            get
            {
                return this.items;
            }
        }
        // TODO: This class should provide a way to add an interview question

        public void Add(InterviewQuestion question)
        {
            this.items.Add(question);
        }

        public int NumCorrect { get; set; } = 8;
        public int NumGuessed { get; set; } = 10;

        // TODO: This class should provide a way to get all interview questions
        
        // TODO: This class should provide a way to get a random interview question
    }
}
