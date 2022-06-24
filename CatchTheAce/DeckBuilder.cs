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

        var random = new Random();
        var randomized = deck.OrderBy(_ => random.Next());
        return randomized.ToList();


    }

    public List<List<int>> CreateCollection(int yearsToSim)
    {
        Program.YearsToSimulate = yearsToSim;
        var collectionOfShuffledDecks = new List<List<int>>();
        for (int i = 0; i < yearsToSim; i++)
        {
            var shuffledDeck = new DeckBuilder().CreateShuffledDeck();
            collectionOfShuffledDecks.Add(shuffledDeck);
        }
        return collectionOfShuffledDecks;
    }
}