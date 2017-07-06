using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreyhoundRace
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            /*MyRadioButton.Text = Name + " ma " + Cash + " zł";
             if (Guy.PlaceBet() == true)
            {
                MyLabel.Text = Name + " stawia " + Amount + " zł na charta nr " DogToWin;
            }
            else
            {
                MyLabel.Text = Name + " nie zawarł zakładu";
            }*/
        }

        public void ClearBet()
        {

        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            MyBet = new Bet() { Amount = BetAmount, Dog = DogToWin, Bettor = this };

            if (BetAmount <= Cash)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Collect(int Winner)
        {

        }
    }
}
