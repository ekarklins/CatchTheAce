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

            public Deck(int years)
            {
                Years = years;
                
            }
            public static List<int> CreateDeck()
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

            public static List<List<int>> AddDeckToCollection()
            {
                List<List<int>> DeckCollection = new List<List<int>>(Years);
                DeckCollection.Add(CreateDeck());
                return DeckCollection;
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
            List<List<int>> list = new List<List<int>>() {new List<int> { 1, 2, 3 }, new List<int>{ 4,5,6} };
            Console.WriteLine(list[0][2]);
            List<int> list2 = new List<int>() { 7,8,9};
            list.Add(list2);
            Console.WriteLine(list[2][2]);
            Deck deck2 = new Deck(5);
            deck2.CreateDeck();
            
            
          


        }
    }

}

