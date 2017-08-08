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
            if (Bettor.PlaceBet(Bettor.MyBet.Amount, Bettor.MyBet.Dog) == true)
            {
                return  Bettor.Name + " stawia " + Amount + " zł na charta nr " + (Dog + 1);
            }
            else
            {
                Bettor.ClearBet();
                return  Bettor.Name + " nie zawarł zakładu";                
            }
        }
        
        public int PayOut(int Winner)
        {
            if(Bettor.MyBet.Dog == Winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
