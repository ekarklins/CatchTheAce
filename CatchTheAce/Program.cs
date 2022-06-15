// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace CatchTheAce
{
    public class Deck { 
        // a method that creates an empty list
        // a method that fills an empty list
    }

    public class DeckBuilder 
    {
        public static List<int> deck = new List<int>();
        public List<int> CreateDeck()
        {
            for(int i = 0; i<52; i++)
            {
                int random = new Random().Next(1, 53);
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
    }
   

    public class DeckCollection : DeckBuilder
    {
        public static List<List<int>> collection = new List<List<int>>();
        public List<List<int>> CreateCollection(int years)
        {
            for(int i = 0; i < years; i++)
            {
                collection.Add(CreateDeck());
            }
            return collection;
        }
    }
    // a method that adds a deck to the deck collection (2d list/ 2d array)?
    // if array, set size as number of years?
    //make a recursive call until collection reaches max capacity?

    public class Results 
    {
        public static int count;
        public static List<int> weeks;
        public List<int> GoThroughResults(List<List<int>> collection)
        {
            //takes in a 2d list(collection)
            for (int i = 0; i < collection.Count; i++)
            {
                for (int j = 0; j < collection[i].Count; j++)
                {
                    int index = collection[i].IndexOf(52);
                    if(collection[i][j] == 52)
                    {
                        if (index == 51)
                        {
                            count++;
                            weeks.Add(index);
                            
                        }
                        else
                        {
                            weeks.Add(index);
                        }
                    }
                }
            }
            return weeks;
           
        }
        public float PercentageCalculator(int years, int count)
        {
            return ((float)count / (float)years) * 100;
        }



    }
    // a method that goes through the deck collection and logs the results in a list/array?
    // a method that calculates percentage
    // a method that formats the results so the UI class can use them?

    public class UI { }
    // a method that outputs the method to get user input
    // a method that displays the results


    internal class Program
    {
        public static void Main(string[] args)
        {
            List<List<int>> decks = new List<List<int>>(3);
            List<int> deck1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> deck2 = new List<int>() { 6, 7, 8, 9, 10 };
            List<int> deck3 = new List<int>() { 11, 12, 13, 14, 15 };
            List<int> deck4 = new List<int>() { 16, 17, 18, 19, 20 };

            decks.Add(deck1);
            decks.Add(deck2);
            decks.Add(deck3);
            for (int i = 0; i < decks.Count; i++)
            {
                for(int j = 0; j < decks[i].Count; j++)
                {
                    Console.WriteLine(decks[i][j]);
                }
            }
            decks.Add(deck4);
            for (int i = 0; i < decks.Count; i++)
            {
                for (int j = 0; j < decks[i].Count; j++)
                {
                    Console.WriteLine(decks[i][j]);
                }
            }




        }
    }

}

