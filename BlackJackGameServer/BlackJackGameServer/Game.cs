using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BlackJackGameServer
{

    class Game
    {
        public GameLogic.Player dealer = new GameLogic.Player();
        public GameLogic.Player player1 = new GameLogic.Player();

        public void TrackCards (int card)
        {
            player1.playerCards.Insert(0,card)
        }

        public void FinalTotal(int card)
        {
            player1.cardTotal += GameLogic.CardValue.FindCardValue(card);
        }

        public void StartGame()
        {
            GameLogic.CardLogic newGame = new GameLogic.CardLogic();
            dealer.playerCards.Insert(0, newGame.Deal()[0]);
            dealer.playerCards.Insert(1, newGame.Deal()[1]);

            player1.playerCards.Insert(0, newGame.Deal()[0]);
            player1.playerCards.Insert(1, newGame.Deal()[1]);
        }

        public void SendCards()
        {
            //Send cards to UI
        }

        public void SendTotal()
        {
            //Send Total
        }

        public void SendBalance()
        {
           //Show Balance
        }

        public string CompareResult()
        {
            bool winLose = false;
            string result;

            if (player1.cardTotal > 21 && dealer.cardTotal > 21)
            {
                result = "Draw";
            }
            else if (player1.cardTotal > 21)
            {
                player1.balance = GameLogic.Bets.Lose(player1.bet);
                result = "Loss";
                winLose = false;
            }
            else if (dealer.cardTotal > 21)
            {
                player1.balance = GameLogic.Bets.Win(player1.bet);
                result = "Win";
                winLose = true;
            }
            else if (player1.cardTotal > dealer.cardTotal)
            {
                player1.balance = GameLogic.Bets.Win(player1.bet);
                result = "Win";
                winLose = true;
            }
            else
            {
                result = "Draw";
            }

            return result;
        }
    }
}
