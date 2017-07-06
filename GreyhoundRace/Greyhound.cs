using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreyhoundRace
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLenght;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;
        
        public bool Run()
        {
            StartingPosition += MyRandom.Next(1, 5);
            //StartingPosition = Location;
            if(StartingPosition >= RacetrackLenght - MyPictureBox.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            Location = 0;
        }
    }
}
