using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackGameServer
{
    class Program
    {
        private int suit;
        private int card;
        private List<int> deck = new List<int>();
        private int deckNum = 6;
        private Random rnd = new Random();
        static void Main(string[] args)
        {
            Random rand1 = new Random();
            suit = Random.Next(1, 4);

            Random rand2 = new Random();
            card = Random.Next(1, 13);

            //give the client
            (card * suit - 1);
        }
    }
}
