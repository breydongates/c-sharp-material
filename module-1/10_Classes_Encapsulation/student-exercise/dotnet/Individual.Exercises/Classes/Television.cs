namespace Individual.Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; } = false;



        public int CurrentChannel
        { get; private set; } = 3;

        public int CurrentVolume { get; private set; } = 2;

        public void TurnOff()
        {
            if (IsOn == true)
                IsOn = false;
        }

        public void TurnOn()
        {
            if (IsOn == false)
                IsOn = true;
            
        }

        public void ChangeChannel (int newChannel)
        {
            if (IsOn == true)
                CurrentChannel = newChannel ;
            
            
        }


        public void ChannelUp ()
        {
            if (IsOn == true)
            
                CurrentChannel = CurrentChannel + 1;
            if (CurrentChannel  > 18)
                CurrentChannel = 3;
            
        }

        public void ChannelDown()
        {
            if (IsOn == true)
            CurrentChannel = CurrentChannel - 1; 
            if ( CurrentChannel  < 3)
            CurrentChannel = 18; 
        }

        public void RaiseVolume ()
        {
            if (IsOn == true)
                CurrentVolume = CurrentVolume + 1;
            if (CurrentVolume + 1 >= 10)
                CurrentVolume = 10;
        }

        public void LowerVolume()
        {
            if (IsOn == true)
            { CurrentVolume = CurrentVolume - 1; }
            if (CurrentVolume - 1 < 0)
            { CurrentVolume = 0; }
            

        }
    }
}
