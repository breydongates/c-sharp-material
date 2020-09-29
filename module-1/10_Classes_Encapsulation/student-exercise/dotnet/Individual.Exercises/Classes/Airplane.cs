namespace Individual.Exercises.Classes
{
    public class Airplane
    {

        public Airplane(string planeNmber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.PlaneNumber = planeNmber;
            this.TotalFirstClassSeats = totalFirstClassSeats;
            this.TotalCoachSeats = totalCoachSeats;

        }
        public string PlaneNumber { get; }

        public int TotalFirstClassSeats { get; }

        public int BookedFirstClassSeats { get; private set; }

        public int AvailableFirstClassSeats
        {
            get
            { return TotalFirstClassSeats - BookedFirstClassSeats; }
        }

        public int TotalCoachSeats { get; }

        public int BookedCoachSeats { get; private set; }

        public int AvailableCoachSeats
        {
            get
            { return TotalCoachSeats - BookedCoachSeats; }

        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            {
                if (forFirstClass == true && totalNumberOfSeats <= AvailableFirstClassSeats)
                {
                    this.BookedFirstClassSeats += totalNumberOfSeats;
                    return true;
                }
                if (forFirstClass == false && totalNumberOfSeats <= AvailableCoachSeats)
                { this.BookedCoachSeats += totalNumberOfSeats;
                    return true;
                }
                return false;
            }
        
            


        }

    }
}
