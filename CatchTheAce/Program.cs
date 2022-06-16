// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace CatchTheAce
{
    public class Deck : DeckBuilder
    {
        public static int Years;
        public static int Counter;

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
            Deck.Years = years;
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

    public class Results : DeckCollection
    {      
        public static List<int> weeks = new List<int>();
        public static List<int> GoThroughResults(List<List<int>> collection)
        {
            //takes in a 2d list(collection)
            for (int i = 0; i < collection.Count; i++)
            {
                for (int j = 0; j < collection[i].Count; j++)
                {
                    int index = collection[i].IndexOf(52);
                    if(collection[i][j] == 52)
                    {
                        if (index == 51)//change back to 51
                        {
                            Deck.Counter++;
                            //Console.WriteLine(index);
                            weeks.Add(index);
                        }
                        else
                        {
                            //Console.WriteLine(index);
                            weeks.Add(index);
                        }
                    }
                }
            }
            //Console.WriteLine(Counter);
            return weeks;
        }
        public float PercentageCalculator(int years, int counter)
        {
            Deck.Counter = counter;
            Deck.Years = years;
            return ((float)counter / (float)years) * 100;
        }
    }
    // a method that goes through the deck collection and logs the results in a list/array?
    // a method that calculates percentage
    // a method that formats the results so the UI class can use them?

    public class UI : Results
    {
        public int GetUserInput() 
        {
            Console.WriteLine("How many years? ");
            var input = Console.ReadLine();
            int years = int.Parse(input);
            return Deck.Years = years;
        }
        public string DisplayResults(List<int> weeks, int years, int counter)
        {
            Deck.Counter = counter;
            Deck.Years = years;
            for (int i = 0; i < weeks.Count; i++)
            {
                return ($"Ace of Spades found on week{weeks[i]+1}");
            }
            return ($"Ace of Spades was found on the last week {counter} times. Percentage: {((float)counter / (float)years)*100}");
        }

    }
    // a method that outputs the method to get user input
    // a method that displays the results


    internal class Program
    {
        public static void Main(string[] args)
        {
            List<List<int>> list = new List<List<int>>();
            List<int> deck1 = new List<int>() { 52, 2, 8, 5 };
            List<int> deck2 = new List<int>() { 12, 15, 52, 67 };
            List<int> deck3 = new List<int>() { 32, 43, 50, 52 };
            list.Add(deck1);
            list.Add(deck2);
            list.Add(deck3);
            Console.WriteLine(Results.GoThroughResults(list));
            
        }

         


    
    }

}

