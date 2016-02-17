﻿using System;
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

        public int points_bank
        {
            get; set;
        }
        public int points_player
        {
            get; set;
        }
        public int total_points
        {
            get; set;
        }

        public int max_points
        {
            get; set;
        }

        public int count_aces_player
        {
            get; set;
        }

        public int count_aces_bank
        {
            get; set;
        }


        public GameHelper(int numberOfDecks)
        {
            this.cardHelper = new CardHelper();
            this.cards = new ArrayList();

            this.points_bank = 0;
            this.points_player = 0;
            this.total_points = 0;
            this.max_points = 380 * numberOfDecks;

            //Durchlaufe Array und erstelle für jedes Deck Kartenfarben
            for (int deck = 0; deck < numberOfDecks; deck++)
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

        public void calcPoints(Card c, bool player)
        {
            if(player)
            {
                this.points_player += c.Number;
                if((this.points_player >21) && (this.count_aces_player > 0))
                {
                    this.points_player -= 10;
                    this.count_aces_player--;
                 }
            }
            else
            {
                this.points_bank += c.Number;
                if ((this.points_bank > 21) && (this.count_aces_bank > 0))
                {
                    this.points_bank -= 10;
                    this.count_aces_bank--;
                }
            }
            this.total_points += c.Number;
        }

        public bool isNewGamePossible()
        {
            return ((this.max_points - this.total_points) >= 42);
        }
    }
}
