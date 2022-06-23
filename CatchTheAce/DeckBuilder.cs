namespace CatchTheAce;

public class DeckBuilder 
{


    public List<int> CreateShuffledDeck()
    {
        List<int> deck = new List<int>();
        for (int i = 0; i < Deck.NumOfCards; i++)
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