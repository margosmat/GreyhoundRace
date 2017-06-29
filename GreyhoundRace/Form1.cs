using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreyhoundRace
{
    public partial class Form1 : Form
    {
        Greyhound[] GreyhoundArray = new Greyhound[3];
        Guy[] GuyArray = new Guy[2];

        public Form1()
        {
            InitializeComponent();

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLenght = raceTrack.Width - pictureBox1.Width,
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLenght = raceTrack.Width - pictureBox2.Width,
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLenght = raceTrack.Width - pictureBox3.Width,
            };
            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLenght = raceTrack.Width - pictureBox4.Width,
            };

            GuyArray[0] = new Guy()
            {
                Name = "Janek",
                Cash = 50,
                MyRadioButton = janekRadioButton,
                MyLabel = janekBetLabel,
                MyBet = null
            };
            GuyArray[1] = new Guy()
            {
                Name = "Bartek",
                Cash = 75,
                MyRadioButton = bartekRadioButton,
                MyLabel = bartekBetLabel,
                MyBet = null
            };
            GuyArray[2] = new Guy()
            {
                Name = "Arek",
                Cash = 45,
                MyRadioButton = arekRadioButton,
                MyLabel = arekBetLabel,
                MyBet = null
            };
        }

    }
}
