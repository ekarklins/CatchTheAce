// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace CatchTheAce
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            DeckBuilder deckBuilder = new DeckBuilder();
            Results results = new Results();
            UI ui = new UI();

            var yearsToSim = ui.GetUserInput();
            var decksByYear = deckBuilder.InitializeDeck(yearsToSim);
            deckBuilder.ShufflesAllDecks(decksByYear);

            var (aceInTheLastWeekCount, weeksWhereAceWasFound) = results.GoThroughResults(decksByYear);
            ui.DisplayResults(yearsToSim, aceInTheLastWeekCount, weeksWhereAceWasFound);

            stopwatch.Stop();
            Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}