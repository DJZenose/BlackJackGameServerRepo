/*************
*Programmers    : Connor McQuade & Brandon Erb
*Professor      : Ed Barsalou
*Date           : 13/12/2015
*Description    : The game logic for the application and the server
*FILE           : Game.cs
**************/
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
        public GameLogic.CardLogic newGame = new GameLogic.CardLogic();

        /*
        * Method        : TrackCards
        * Parameters    : A card represent by a number
        * Description   : adds the card to the list containing someones hand
        */
        public void TrackCards (int card)
        {
            player1.playerCards.Insert(0,card)
        }

        /*
        * Method        : FinalTotal
        * Returns       : void
        * Parameters    : A card represent by a number
        * Description   : Adds total that is your hands
        */
        public void FinalTotal(int card)
        {
            player1.cardTotal += GameLogic.CardValue.FindCardValue(card);
        }

        /*
        * Method        : FinalTotal
        * Returns       : void
        * Parameters    : A card represent by a number
        * Description   : Adds total that is your hands
        */
        public void StartGame()
        {
            dealer.playerCards.Insert(0, newGame.Deal()[0]);
            dealer.playerCards.Insert(1, newGame.Deal()[1]);

            player1.playerCards.Insert(0, newGame.Deal()[0]);
            player1.playerCards.Insert(1, newGame.Deal()[1]);
        }

        /*
        * Method        : SendCards
        * Returns       : int of the card
        * Parameters    : N/A
        * Description   : Sends a card to the client
        */
        public int SendCards()
        {
            return newGame.Hit();
        }

        /*
        * Method        : SendTotals
        * Returns       : total of your hand
        * Parameters    : N/A
        * Description   : Sends the total of your hand
        */
        public int SendTotal()
        {
            return player1.cardTotal;
        }

        /*
        * Method        : SendBalance
        * Returns       : double that is your account balance
        * Parameters    : N/A
        * Description   : Sends the balance to the client
        */
        public double SendBalance()
        {
            return player1.balance;
        }

        /*
        * Method        : CompareResult
        * Returns       : string the result status
        * Parameters    : N/A
        * Description   : Checks which player won
        */
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
