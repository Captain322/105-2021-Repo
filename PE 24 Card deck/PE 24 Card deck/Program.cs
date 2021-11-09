using System;
// Yaroslav Mikhnevych
// 11/08/2021
// PE 24 Card deck

namespace PE_24_Card_deck
{
    class Program
    {
        static void Main(string[] args)
        {
            int deal;
            bool success;

            // Initializing two variables that will be needed for my solution

            Deck myDeck = new Deck();

            // New deck object was created up top and then the print method was called below

            myDeck.PrintDeck();

            do
            {
                Console.WriteLine("\nEnter a number between 1 and 52: ");
                success = int.TryParse(Console.ReadLine(), out deal);
            }
            while (success == false);

            // While loop to ensure the user enters a valid number + method call

            myDeck.Deal(deal);


        }
    }
}
