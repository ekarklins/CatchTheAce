// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace CatchTheAce
{
    public static class Deck 
    {
        public const int numOfCards = 52;
        public static int Years;
        public static int Counter;
    }
    public class DeckBuilder 
    {
        /// <summary>
        /// Creates a shuffled list of number 1 to 52(deck of 52 cards).
        /// </summary>
        /// <returns>A shuffled list with numbers 1 to 52</returns>
        public List<int> CreateDeck()
        {
            List<int> deck = new List<int>();
            for (int i = 0; i<52; i++)
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
        /// <summary>
        /// Creates a 2D list containing multiple sets of shuffle decks.
        /// </summary>
        /// <param name="years">the number of shuffled decks to add to the 2D list</param>
        /// <returns>a 2D list containing a number of deck sets determined by the years parameter.</returns>
        public List<List<int>> CreateCollection(int years)
        {
            Deck.Years = years;
            var Collection = new List<List<int>>();
            for (int i = 0; i < years; i++)
            {
                var createdeck = new DeckBuilder().CreateDeck();
                Collection.Add(createdeck);
            }
            return Collection;
        }
    }
    public class Results : UI
    {      
        public static List<int> Weeks = new List<int>();
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
            for (int i = 0; i < collection.Count; i++)
            {
                for (int j = 0; j < collection[i].Count; j++)
                {
                    int index = collection[i].IndexOf(52);
                    if(collection[i][j] == 52)
                    {
                        if (index == 51)
                        {
                            Deck.Counter++;
                            Weeks.Add(index);
                        }
                        else
                        {
                            Weeks.Add(index);
                        }
                    }
                }
            }
            return Weeks;
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
                string input = "";
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
        /// <param name="weeks">a list of results from each week</param>
        /// <param name="years">used to calculate the percentage</param>
        /// <param name="counter"></param>
        /// <returns>Outputs the results on the console</returns>
        public void DisplayResults() 
        {
            for (int i = 0; i < Results.Weeks.Count; i++) 
            { 
                if(Results.Weeks[i] == 51)
                {
                    Console.WriteLine($"Year {i+1}: ACE OF SPADES FOUND IN THE LAST WEEK!", Console.ForegroundColor = ConsoleColor.Green);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"Year {i+1}: Ace of Spades found on Week: {Results.Weeks[i] + 1}", Console.ForegroundColor = ConsoleColor.DarkCyan);
                    Console.ResetColor();
                }
            }
            Console.WriteLine($"In {Deck.Years} years, the Ace of Spades was found on the last week {Deck.Counter} times. Percentage: {((float)Deck.Counter / (float)Deck.Years)*100}%");
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
            results.DisplayResults();
            stopwatch.Stop();
            Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}

