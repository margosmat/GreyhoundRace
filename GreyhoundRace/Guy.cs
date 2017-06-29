using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            MyRadioButton.Text = Name + " ma " + Cash + " zł";
             if (Bet.PlaceBet() == true)
            {
                MyLabel.Text = Name + " stawia " + Amount + " zł na charta nr " Dog;
            } else
            {
                MyLabel.Text = Name + " nie zawarł zakładu";
            }
        }
    }
}
