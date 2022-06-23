// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace CatchTheAce
{
    public static class Deck
    {
        public const int NumOfCards = 52;
        public static int Years;
        public static int Counter;
    }

    public class DeckBuilder
    {
        private List<int> CreateShuffledDeck()
        {
            List<int> deck = new List<int>();
            for (int i = 0; i < 52; i++)
            {
                deck.Add(i + 1);
            }

            var rndm = new Random();
            var randomized = deck.OrderBy(_ => rndm.Next());
            return randomized.ToList();
        }

        /// <summary>
        /// Creates a 2D list containing multiple sets of shuffle decks.
        /// </summary>
        /// <param name="years">the number of shuffled decks to add to the 2D list</param>
        /// <returns>a 2D list containing a number of deck sets determined by the years parameter.</returns>

        public int years;
        public List<List<int>> CreateCollection(int years)
        {
            Deck.Years = years;
            var collection = new List<List<int>>();
            for (int i = 0; i < years; i++)
            {
                var createdeck = new DeckBuilder().CreateShuffledDeck();
                collection.Add(createdeck);
            }
            return collection;
        }
    }

    public class Results
    {
        public static List<int> weeks = new List<int>();

        /// <summary>
        /// Goes through a deck collection and finds the Ace of Spades and its index.
        /// The Ace of Spades is represented by the value 52.
        /// The index variable represents the week.
        /// Adds the indexes to a new list that is used to display results.
        /// </summary>
        /// <param name="collection"></param>
        /// <returns>A list of week numbers that 52(Ace of Spades) was found</returns>
        public List<int> GoThroughResults(List<List<int>> collection)
        {
            for (var i = 0; i < collection.Count; i++)
            {
                for (var j = 0; j < collection[i].Count; j++)
                {
                    var index = collection[i].IndexOf(52);
                    if (collection[i][j] == 52)
                    {
                        if (index == 51)
                        {
                            Deck.Counter++;
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

    public class UI
    {
        /// <summary>
        /// Outputs a prompt on the console and retrieves user input.
        /// The input represents how many years the user wants to calculate.
        /// </summary>
        /// <returns>an integer representing the user input for the number of years</returns>
        public int GetUserInput()
        {
            var prompt = "How many years would you like to simulate? ";
            Console.WriteLine("CATCH THE ACE PROGRAM");
            while (true)
            {
                Console.WriteLine(prompt);
                string? input;
                if ((input = Console.ReadLine()) == null || !int.TryParse(input, out int i) || i < 1)
                {
                    Console.WriteLine("\nPlease enter an integer greater than 0 \n", Console.ForegroundColor = ConsoleColor.DarkYellow);
                    Console.ResetColor();
                }
                else
                {
                    return Deck.Years = i;
                }
            }



        }

        /// <summary>
        /// Displays the results for each year (which week the Ace of Spades was found).
        /// After displaying each years results, the percentage of Ace of Spades found in the last week over the years is displayed.
        /// </summary>
        /// <returns>Outputs the results on the console</returns>
        public void DisplayResults()
        {
            for (int i = 0; i < Results.weeks.Count; i++)
            {
                if (Results.weeks[i] == 51)
                {
                    Console.WriteLine($"Year {i + 1}: ACE OF SPADES FOUND IN THE LAST WEEK!", Console.ForegroundColor = ConsoleColor.Green);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"Year {i + 1}: Ace of Spades found on Week: {Results.weeks[i] + 1}", Console.ForegroundColor = ConsoleColor.DarkCyan);
                    Console.ResetColor();
                }
            }
            Console.WriteLine($"\nIn {Deck.Years} years, the Ace of Spades was found on the last week {Deck.Counter} times. Percentage: {((float)Deck.Counter / (float)Deck.Years) * 100}%");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            DeckBuilder deckbuilder = new DeckBuilder();
            Results results = new Results();
            UI ui = new UI();
            results.GoThroughResults(deckbuilder.CreateCollection(ui.GetUserInput()));
            //results.DisplayResults();
            ui.DisplayResults();
            stopwatch.Stop();
            Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}