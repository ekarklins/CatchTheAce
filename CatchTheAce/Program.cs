// See https://aka.ms/new-console-template for more information

namespace CatchTheAce
{

    public class Deck : DeckBuilder
    {
        public static int Years;
        public static int Counter;
    }
    public class DeckBuilder 
    {
        public static List<int> deck = new List<int>();
        /// <summary>
        /// Creates a shuffled list of number 1 to 52(deck of 52 cards).
        /// </summary>
        /// <returns>A shuffled list with numbers 1 to 52</returns>
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
        public static List<List<int>> Collection = new List<List<int>>();
        /// <summary>
        /// Creates a 2D list containing multiple sets of shuffle decks.
        /// </summary>
        /// <param name="years">the number of shuffled decks to add to the 2D list</param>
        /// <returns>a 2D list containing a number of deck sets determined by the years parameter.</returns>
        public List<List<int>> CreateCollection(int years)
        {
            Deck.Years = years;
            for(int i = 0; i < years; i++)
            {
                Collection.Add(CreateDeck());
            }
            return Collection;
        }
    }
    public class Results : DeckCollection
    {      
        public static List<int> Weeks = new List<int>();
        /// <summary>
        /// Go through a deck collection and finds the Ace of Spades and its index.
        /// The Ace of Spades is represented by the value 52.
        /// The index represents the week.
        /// </summary>
        /// <param name="collection"></param>
        /// <returns>A list of week numbers that 52(Ace of Spades) was found</returns>
        public static List<int> GoThroughResults(List<List<int>> collection)
        {
            DeckCollection.Collection = collection;
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
    public class UI : Results
    {
        /// <summary>
        /// Outputs a prompt on the console and retrieves user input.
        /// The input represents how many years the user wants to calculate.
        /// </summary>
        /// <returns>an integer representing the user input</returns>
        public int GetUserInput() 
        {
            //Console.WriteLine("How many years? ");
            //var input = Console.ReadLine();
            //int years = int.Parse(input);
            //return Deck.Years = years;

            Console.WriteLine("How many years? ");
            while (true)
            {
                string input;
                if((input = Console.ReadLine()) != null && int.TryParse(input, out int i) && i >= 1)
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
        public string DisplayResults(List<int> weeks, int years, int counter)
        {
            Deck.Counter = counter;
            Deck.Years = years;
            Results.Weeks = weeks;
            for (int i = 0; i < weeks.Count; i++)
            {
                return ($"Ace of Spades found on week{weeks[i]+1}");
            }
            return ($"Ace of Spades was found on the last week {counter} times. Percentage: {((float)counter / (float)years)*100}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
           
        }
    }

}

