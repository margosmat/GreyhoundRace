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
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] GuyArray = new Guy[3];
        Random Randomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLenght = raceTrack.Width - pictureBox1.Width,
                MyRandom = Randomizer
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLenght = raceTrack.Width - pictureBox2.Width,
                MyRandom = Randomizer
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLenght = raceTrack.Width - pictureBox3.Width,
                MyRandom = Randomizer
            };
            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLenght = raceTrack.Width - pictureBox4.Width,
                MyRandom = Randomizer
            };

            GuyArray[0] = new Guy()
            {
                Name = "Janek",
                Cash = 10,
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

            for (int i = 0; i <= 2; i++)
            {
                GuyArray[i].UpdateLabels();
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            groupBox1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (GreyhoundArray[i].Run() == true)
                {
                    timer1.Stop();
                    for (int j = 0; j <=3 ; j++)
                    {
                        GreyhoundArray[j].TakeStartingPosition();
                    }
                    for (int k = 0; k <=2 ; k++)
                    {
                        GuyArray[k].UpdateLabels();
                    }
                    groupBox1.Enabled = true;
                } else
                {
                    GreyhoundArray[i].Run();
                }
            }
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (GuyArray[i].MyRadioButton.Checked == true)
                {
                    GuyArray[i].PlaceBet((int)betAmount.Value, ((int)houndNumeric.Value - 1));
                    GuyArray[i].MyBet.GetDescription();
                }

            }
        }

        private void janekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (janekRadioButton.Checked == true)
            {
                nameLabel.Text = "Janek";
            }
        }

        private void bartekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (bartekRadioButton.Checked == true)
            {
                nameLabel.Text = "Bartek";
            }
        }

        private void arekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (arekRadioButton.Checked == true)
            {
                nameLabel.Text = "Arek";
            }
        }
    }
}
