using System;
/*************
*Programmers    : Connor McQuade & Brandon Erb
*Professor      : Ed Barsalou
*Date           : 13/12/2015
*Description    : The class that holds all the nessary data for a player
*FILE           : Player.cs
**************/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Player
    {
        public List<int> playerCards = new List<int> ();
        public string clieantID;
        public double bet;
        public int cardTotal;
        public double balance;
    }
}
