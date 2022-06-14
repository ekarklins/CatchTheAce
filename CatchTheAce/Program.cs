// See https://aka.ms/new-console-template for more information
using System;

namespace CatchTheAce
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> deck = new List<int>();


            for (int i = 0; i < 10; i++)
            {
                int random = new Random().Next(0, 52);
                while (!deck.Contains(random))
                {
                    deck.Add(random);
                }
            }

            foreach (int d in deck)
            {
                Console.WriteLine(d);
            }
        }
    }

}

