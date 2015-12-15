using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLogic
{
    public class Bets
    {
        float bet;

        public static double Win(double bet)
        {
            return bet * 2;
        }

        public static double Lose(double bet)
        {
            return -bet;
        }

    }
}
