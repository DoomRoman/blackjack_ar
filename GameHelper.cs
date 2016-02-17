using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hearts
{
    class GameHelper
    {
        private CardHelper cardHelper;
        private ArrayList cards;

        public GameHelper(int numberOfDecks)
        {
            this.cardHelper = new CardHelper();
            this.cards = new ArrayList();

            //Durchlaufe Array und erstelle für jedes Deck Kartenfarben
            for(int deck = 0; deck < numberOfDecks; deck++)
            {
                //Druchlaufe Farben und erstelle für jede Farbe Kartenwerte
                for(int cardColor = 0; cardColor  <4; cardColor++)
                {
                    for(int cardNumber = 0; cardNumber < 13; cardNumber++)
                    {
                        cards.Add(new Card(cardColor, cardNumber));
                    }
                }
            }
        }

        public Card getRandomCard()
        {
            Random rand = new Random();
            int index = rand.Next(0, this.cards.ToArray().Length);
            Card result = (Card)this.cards[index];
            this.cards.RemoveAt(index);
            return result;
        }
    }
}
