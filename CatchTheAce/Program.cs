// See https://aka.ms/new-console-template for more information

namespace CatchTheAce
{

    public class Deck 
    {
        public static int Years;
        public static int Counter;

    }
    public class DeckBuilder : Deck
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
        //public List<List<int>> Collection = new List<List<int>>();
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
                //ClearDeck();
                //continue;
            }
            return Collection;
        }
        public void ClearDeck()
        {
            
        }
    }

    public class Results : UI
    {      
        public static List<int> Weeks = new List<int>();
        /// <summary>
        /// Go through a deck collection and finds the Ace of Spades and its index.
        /// The Ace of Spades is represented by the value 52.
        /// The index represents the week.
        /// </summary>
        /// <param name="collection"></param>
        /// <returns>A list of week numbers that 52(Ace of Spades) was found</returns>
        public List<int> GoThroughResults(List<List<int>> collection)
        {
            //DeckBuilder.Collection = collection;
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
        public float PercentageCalculator(int years, int counter)
        {
            Deck.Counter = counter;
            Deck.Years = years;
            return ((float)counter / (float)years) * 100;
        }
    }
    public class UI 
    {
        /// <summary>
        /// Outputs a prompt on the console and retrieves user input.
        /// The input represents how many years the user wants to calculate.
        /// </summary>
        /// <returns>an integer representing the user input</returns>
        public int GetUserInput() 
        {
            var prompt = "How many years? ";
            while (true)
            {
                Console.WriteLine(prompt);
                string input = "";
                if ((input = Console.ReadLine()) == null || !int.TryParse(input, out int i) || i < 1)
                {
                    Console.WriteLine("Please enter an integer greater than 0");
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
        /// <returns>a string of the results</returns>
        public void DisplayResults() 
        {
            //Deck.Counter = counter;
            //Deck.Years = years;
            //Results.Weeks = weeks;
            for (int i = 0; i < Results.Weeks.Count; i++) 
            { 
                if(Results.Weeks[i] == 51)
                {
                    Console.WriteLine("ACE OF SPADES FOUND IN THE LAST WEEK!", Console.ForegroundColor = ConsoleColor.Green);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"Ace of Spades found on week {Results.Weeks[i] + 1}", Console.ForegroundColor = ConsoleColor.Red);
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

            Deck deck = new Deck();
            DeckBuilder deckbuilder = new DeckBuilder();
            Results results = new Results();
            UI ui = new UI();
            results.GoThroughResults(deckbuilder.CreateCollection(ui.GetUserInput()));
            results.DisplayResults();

            //var sampletext1 = "GREEN SAMPLE TEXT";
            //var sampletext2 = "RED SAMPLE TEXT";
            //Console.WriteLine(sampletext1, Console.ForegroundColor = ConsoleColor.Green);
            //Console.WriteLine(sampletext2, Console.ForegroundColor = ConsoleColor.Red);



        }
    }

}

