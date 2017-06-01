using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_races
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
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = this.Name + " has " + Cash + " bucks";
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            if(BetAmount <= Cash)
            {
                MyBet = new Bet()
                {
                    Amount = BetAmount,
                    Dog = DogToWin,
                    Bettor = this

                };
                UpdateLabels();
                return true;
            }else
            {
                return false;
            }
            
        }

        public void Collect(int Winner)
        {

            this.Cash += MyBet.PayOut(Winner);
            this.ClearBet();
            this.UpdateLabels();
            
        }
    }
}
