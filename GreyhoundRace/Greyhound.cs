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
            MyPictureBox.Left += MyRandom.Next(1, 5);
            //Location += MyRandom.Next(1, 5);
            //StartingPosition += Location;
            //MyPictureBox.Left += Location;
            if (MyPictureBox.Left >= RacetrackLenght - 45)
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
            MyPictureBox.Left = StartingPosition;
        }
    }
}
