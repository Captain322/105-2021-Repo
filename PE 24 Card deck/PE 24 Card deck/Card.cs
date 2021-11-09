using System;
using System.Collections.Generic;
using System.Text;

namespace PE_24_Card_deck
{
    public class Card
    {
        private int value;
        private string suit;

        public Card(int value, string suit)
        {
            this.value = value;
            this.suit = suit;
        }
            
        // Check to see that the card's value represents if its an Ace, Jack etc.
        public void PrintCard()
        {
            switch(value)
            {
                case 1:
                    Console.WriteLine("Ace of " + suit);
                    break;
                case 11:
                    Console.WriteLine("Jack of " + suit);
                    break;
                case 12:
                    Console.WriteLine("Queen of " + suit);
                    break;
                case 13:
                    Console.WriteLine("King of " + suit);
                    break;
                default:
                    Console.WriteLine("{0} of {1}", value, suit);
                    break;
            }

        }
    }
}
