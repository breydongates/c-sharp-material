namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        private string typeOfFruit;
        private int startingPiecesOfFruit;
        private int piecesOfFruitLeft;


        public FruitTree (string typeOfFruit, int startingPiecesOfFruit)
        {
            this.TypeOfFruit = typeOfFruit;
            this.StartingPiecesOfFruit = startingPiecesOfFruit;
        }

        public string TypeOfFruit { get; }
        public int StartingPiecesOfFruit { get; }
        public int PiecesOfFruitLeft { get; private set; }

        public bool PickFruit (int numberOfPiecesToRemove)
        { 
            
            if (PiecesOfFruitLeft > numberOfPiecesToRemove)

            {
                this.piecesOfFruitLeft = startingPiecesOfFruit - numberOfPiecesToRemove;
                return true;
            }
            else return false;
            
        }
 
    }
}
