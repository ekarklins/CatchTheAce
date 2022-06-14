// See https://aka.ms/new-console-template for more information
using System;

namespace CatchTheAce
{
    internal class Program
    {

        public class Deck
        {
            private static int count;
            public Deck()
            {
                List<int> deck = new List<int>();


                for (int i = 0; i < 10; i++)
                {
                    int random = new Random().Next(0, 10);
                    if (!deck.Contains(random))
                    {
                        deck.Add(random);
                    }
                    else
                    {
                        i--;
                    }
                }

            }
            public void GoThroughDeck(Deck deck)
            {
                //go through deck
                //return the week that ace of spades is drawn(#52)
 
            }
            public int GetUserInput()
            {
                // parse user input to string
                Console.WriteLine("how many years:");
                string input = Console.ReadLine();
                int input2 = int.Parse(input);
                return input2;

                
            }
            public int NumOfDecks()
            {
                //return years * deck
            }

            public void CalculatePercentage()
            {
                //return years / amount of times ace of spades was drawn
            }
            
        }
        static void Main(string[] args)
        {


        }
    }

}

