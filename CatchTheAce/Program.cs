// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace CatchTheAce
{

    public class Deck 
    {
        public const int NumOfCards = 52;
    }


    public static class Program
    {
        public static int YearsToSimulate;
        public static int AceInTheLastWeekCount;


        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            DeckBuilder deckbuilder = new DeckBuilder();
            Results results = new Results();
            UI ui = new UI();
            results.GoThroughResults(deckbuilder.CreateCollection(ui.GetUserInput()));
            results.DisplayResults();
            stopwatch.Stop();
            Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds}ms");



        }
    }
}