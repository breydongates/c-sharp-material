using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
// using FedEx.Magic;

namespace Capstone.Classes
{
    /// <summary>
    /// This class should contain any and all details of access to files, including 
    /// loading questions and outputting scores
    /// </summary>
    public class FileAccess
    {
        private string filePath = @"C:\Users\Student\questions.csv";
        private string scoresPath = @"C:\Users\Student\scores.txt";

        /*        public FileAccess(QuestionManager manager)
                {
                    this.Questions = manager;
                }

                public QuestionManager Questions { get; }*/

        // TODO: We'll need a way to load questions from a file and add them in to a QuestionManager
        public void LoadQuestions(QuestionManager manager)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    // Each line looks like "1,What’s the difference between C# and .NET?"

                    string[] parts = line.Split(","); // | tomorrow

                    int id = int.Parse(parts[0]);
                    string name = parts[1];

                    InterviewQuestion question = new InterviewQuestion(name, id);
                    manager.Add(question);
                }
            }
        }

        // TODO: We'll need a way of writing questions out to a file with a number of times answered correctly / incorrectly
        public void WriteScores(QuestionManager manager)
        {
            using (StreamWriter writer = new StreamWriter(this.scoresPath, true))
            {
                writer.Write("You scored a ");
                writer.Write(manager.NumCorrect);
                writer.Write(" out of ");
                writer.WriteLine(manager.NumGuessed);
            }
        }
    }
}
