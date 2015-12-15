using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class CardLogic
    {

        private List<int> deck = new List<int>();
        private int deckNum;

        public CardLogic()
        {
            deck = Shuffle();
            deckNum = 6;
        }

        /*
        * Method        :Deal
        * Returns       :Takes two cards off the top of the deck
        * Parameters    :void
        * Description   :Demoes dealing cards
        */
        public int[] Deal()
        {
            int[] cards = new int[2];
            cards[0] = deck.First();
            deck.RemoveAt(0);
            cards[1] = deck.First();
            deck.RemoveAt(0);
            return cards;
        }

        public int Hit()
        {
            int card;
            card = deck.First();
            deck.RemoveAt(0);
            return card;
        }
        /*
       * Method        :Shuffle
       * Returns       :int array of the shuffled deck
       * Parameters    :void
       * Description   :Shuffles a number of decks together
       ************* Warning does not seed properly in IIS **********
       */
        public List<int> Shuffle()
        {
            for (int decks = 0; decks < deckNum; decks++)
            {
                for (int shuffle = 1; shuffle <= 52; shuffle++)
                {
                    int insert;
                    Random rand = new Random();
                    insert = rand.Next(0, deck.Count);

                    deck.Insert(insert, shuffle);
                }
            }

            return deck;
        }

        /*
       * Method        :Card
       * Description   :Accessor for the card being drawn
       */
        public List<int> Deck
        {
            get { return deck; }
            set { deck = value; }
        }


    }
}
