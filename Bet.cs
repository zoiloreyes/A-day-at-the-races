﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_at_the_races
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if(Amount != 0)
            {
                return Bettor.Name + " bets " + Amount + " on dog #" + Dog;
            }else
            {
                return Bettor.Name + " hasn't placed a bet";
            }
        }

        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                return Amount;
            }
            else
            {
                return Amount * -1;
            }
        }

    }
}
