namespace CatchTheAce;

public class DeckBuilder
{
    public void ShufflesAllDecks(List<List<int>> decksByYear)
    {
        for (var index = 0; index < decksByYear.Count; index++)
        {
            var currentDeck = decksByYear[index];
            decksByYear[index] = this.ShuffleDeck(currentDeck);
        }
    }

    public List<int> ShuffleDeck(List<int> deck)
    {
        var random = new Random();
        var randomizedDeck = deck.OrderBy(_ => random.Next());
        return randomizedDeck.ToList();
    }

    public List<List<int>> InitializeDeck(int yearsToSimulate)
    {
        var decksForYears = new List<List<int>>();
        for (int year = 0; year < yearsToSimulate; year++)
        {
            var deck = new List<int>();
            for (int cardNum = 1; cardNum <= DeckConstants.CardsInDeck; cardNum++)
            {
                deck.Add(cardNum);
            }

            decksForYears.Add(deck);
        }

        return decksForYears;
    }
}