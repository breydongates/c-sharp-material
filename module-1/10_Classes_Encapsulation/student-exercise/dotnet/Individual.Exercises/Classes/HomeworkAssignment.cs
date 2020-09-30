
namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        

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
            get 
            
            {
     double grade = EarnedMarks / (double)PossibleMarks;


                if (grade  >= 0.90)
                {
                    return "A";
                }
                if (grade>= 0.80 && grade <= 0.89)
                {
                   return "B";
                }
                if (grade>= 0.70 && grade <= 0.79)
                {
                    return "C";
                }
                if (grade >= 0.60 && grade <= 0.69)
                {
                    return "D";
                }
                return "F";

            }


        }
        
    }
}
