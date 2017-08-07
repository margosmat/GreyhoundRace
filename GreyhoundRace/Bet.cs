using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreyhoundRace
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            string description;
            if (Bettor.PlaceBet(Bettor.MyBet.Amount, Bettor.MyBet.Dog) == true)
            {
                description = Bettor.Name + " stawia " + Amount + " zł na charta nr " + (Dog + 1);
            }
            else
            {
                description = Bettor.Name + " nie zawarł zakładu";
                Bettor.MyBet.Amount = 0;
            }
            Bettor.MyLabel.Text = description;
            return description;
        }
        /*
        public int PayOut()
        {

        }*/
    }
}
