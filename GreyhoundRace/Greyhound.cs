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
        public Random MyRandom;
        
        public bool Run()
        {
            MyPictureBox.Left += MyRandom.Next(1, 5);
            if (MyPictureBox.Left >= RacetrackLenght - 45)  //45, bo przy ustawieniu szerokości obrazka psa,
            {                                               //psy kończą bieg przed linią mety
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
