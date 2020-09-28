
namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        private int earnedMarks;
        private int possibleMarks;

        public HomeworkAssignment(int possibleMarks, string submitterName)
        {

            this.PossibleMarks = possibleMarks;

            this.SubmitterName = submitterName;
        }
        
        public int EarnedMarks { get; set; }
      

        public int PossibleMarks { get; }
   

        public string SubmitterName { get; }

        public string LetterGrade
        {
            get { return LetterGrade; }
            set
            {
         double grade = earnedMarks / possibleMarks;


                if (grade  >= 0.90)
                {
                    LetterGrade= "A";
                }
                if (grade>= 0.80 && grade <= 0.89)
                {
                   LetterGrade= "B";
                }
                if (grade>= 0.70 && grade <= 0.79)
                {
                    LetterGrade= "C";
                }
                if (grade >= 0.60 && grade <= 0.69)
                {
                    LetterGrade= "D";
                }
                else if (grade < 0.60)
                {
                    LetterGrade= "F";
                }

            }


        }
        
    }
}
