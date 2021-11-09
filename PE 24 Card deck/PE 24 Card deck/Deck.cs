using System;
using System.Collections.Generic;
using System.Text;

namespace PE_24_Card_deck
{
    public class Deck
    {
        private Random rng;
        private Card[] cards;

        public Deck()
        {
            rng = new Random();
            cards = new Card[52];

            for(int i = 0; i < 13; i++)
            {
                cards[i] = new Card(i + 1, "Hearts");
            }

            for (int i = 13; i < 26; i++)
            {
                cards[i] = new Card(i - 12, "Clubs");
            }

            for (int i = 26; i < 39; i++)
            {
                cards[i] = new Card(i - 25, "Diamonds");
            }

            for (int i = 39; i < 52; i++)
            {
                cards[i] = new Card(i - 38, "Spades");
            }
        }

        // Deck is created and assigned above
        // Deck is printed below

        public void PrintDeck()
        {
           foreach (Card Card in cards)
            {
                Card.PrintCard();
            }
        }

        // Deck is dealt according to user input

        public void Deal(int amount)
        {
            for(int i = 0; i < amount; i++)
            {
                cards[rng.Next(0,52)].PrintCard();
            }
        }

    }
}
