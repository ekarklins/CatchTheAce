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


            List<List<int>> list2d = new List<List<int>>();
            List<int> listint1 = new List<int>() { 1, 2, 3 };
            List<int> listint2 = new List<int>() { 4, 5, 6 };

            list2d.Add(listint1);
            list2d.Add(listint2);

            for (int i = 0; i < list2d.Count; i++)
            {
                for(int j = 0; j < list2d[i].Count; j++)
                {
                    Console.WriteLine("j:" + j);
                    Console.WriteLine("value:" + list2d[i][j]);
                }
                Console.WriteLine("i:" + i);
            }

        }
    }

}

