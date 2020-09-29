namespace Individual.Exercises.Classes
{
    public class Elevator
    {
       public Elevator (int numberOfLevels)
        { this.NumberOfLevels = numberOfLevels; }

        public int CurrentLevel { get; private set; } = 1;

        public int NumberOfLevels { get; }

        public bool DoorIsOpen { get; private set; }
        public void OpenDoor()
        {
            if (DoorIsOpen == false)
                DoorIsOpen = true;
        }
        

        public void CloseDoor()
        {
            if (DoorIsOpen == true)
                DoorIsOpen = false;

        }

        public void GoUp(int desiredFloor)
        {
            if (DoorIsOpen == false && CurrentLevel < NumberOfLevels)
                CurrentLevel = desiredFloor;

        }

        public void GoDown(int desiredFloor)
        {
            if (DoorIsOpen == false && CurrentLevel > 1)
                CurrentLevel = desiredFloor;
        }

    }

}
