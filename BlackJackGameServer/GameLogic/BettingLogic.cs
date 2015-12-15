/*************
*Programmers    : Connor McQuade & Brandon Erb
*Professor      : Ed Barsalou
*Date           : 13/12/2015
*Description    : The logic for a better
*FILE           : BettingLogic.cs
**************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLogic
{
    public class Bets
    {
        float bet;

        /*
        * Method        : Win
        * Returns       : The change in account balance
        * Parameters    : The bet
        * Description   : Calculates your change in account balance after a winning hand
        */
        public static double Win(double bet)
        {
            return bet * 2;
        }

        /*
        * Method        : Lose
        * Returns       : The change in account balance
        * Parameters    : The bet
        * Description   : Calculates your change in account balance after a losing hand
        */
        public static double Lose(double bet)
        {
            return -bet;
        }

    }
}
