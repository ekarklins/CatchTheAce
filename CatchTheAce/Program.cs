// See https://aka.ms/new-console-template for more information
using System;

namespace CatchTheAce
{
    internal class Program
    {
        public class Deck
        {
            public static int Years;
            public static int Count = 2;
            public static List<int> deck = new List<int>();

            public Deck()
            {
                
            }
            public List<int> CreateDeck()
            {
                for (int i = 0; i < 5; i++)
                {
                    int random = new Random().Next(1, 6);
                    if (!deck.Contains(random))
                    {
                        deck.Add(random);
                    }
                    else
                    {
                        i--;
                    }
                }
                return deck;
            }
            public int GoThroughDeck(List<int> deck)
            {
                //go through deck
                //return the week that ace of spades is drawn(#52)
                int index = deck.IndexOf(5);
                if (index == 0)
                {
                    return Count++;
                }
                else
                {
                    return index;
                }
            }
            //public int GetUserInput()
            //{
            //    // parse user input to string
            //    Console.WriteLine("how many years:");
            //    string input = Console.ReadLine();
            //    Years = int.Parse(input);
            //    return Years;
            //}
            //public int NumOfDecks()
            //{
            //    //return years * deck
            //}
            public string CalculatePercentage(int years)
            {
                Years = years;
                string weeknum = ("Ace of Spades was found on week: " + GoThroughDeck(deck));
                string percentage = "";
                if(Count != 0)
                {
                    percentage = percentage + ("Percentage: " + (float)(Count / Years) + "%");

                }
                else
                {
                    percentage = percentage + ("Percentage: 0%");
                }
                return weeknum + " " + percentage;
                //return years / amount of times ace of spades was drawn
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("how many years? ");
            //int NumOfYears = Console.Read();
            Deck deck = new Deck();
            deck.CreateDeck();
            string answer = deck.CalculatePercentage(3);
            Console.WriteLine(answer);


            //foreach(string r in results)
            //{
            //    Console.WriteLine(r);
            //}


        }
    }

}

