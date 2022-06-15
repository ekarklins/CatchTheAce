// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace CatchTheAce
{
    public class Deck { 
        // a method that creates an empty list
        // a method that fills an empty list
    }

    public class DeckBuilder { }
   

    public class DeckCollection { }
    // a method that adds a deck to the deck collection (2d list/ 2d array)?
    // if array, set size as number of years?
    //make a recursive call until collection reaches max capacity?

    public class Results {
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
            int years1 = 10;
            int count1 = 3;

            Console.WriteLine(((float)count1 / (float)years1)*100);


        }
    }

}

