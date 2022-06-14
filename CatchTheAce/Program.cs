// See https://aka.ms/new-console-template for more information
using System;

namespace CatchTheAce
{
    class Deck
    {
        Deck()
        {

        }

        public static void Main(string[] args)
        {
            List<List<int>> DeckCollection = new List<List<int>>();
            for (int i = 0; i < 3; i++)
            {
                List<int> deck = new List<int>();
                for (int j = 0; j < 4; j++)
                {
                    deck.Add(j);
                }
            }
        }
    }

}

