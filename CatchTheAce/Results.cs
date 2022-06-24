namespace CatchTheAce;

public class Results
{
    /// <summary>
    /// Goes through a deck collection and finds the Ace of Spades and its index.
    /// The Ace of Spades is represented by the value 52.
    /// The index variable represents the week.
    /// Adds the indexes to a new list that is used to display results.
    /// </summary>
    /// <param name="collectionOfShuffledDecks"></param>
    /// <returns>A list of week numbers that 52(Ace of Spades) was found</returns>
    public (int aceInTheLastWeekCount, List<int> weeksWhereAceWasFound) GoThroughResults(List<List<int>> collectionOfShuffledDecks)
    {
        var aceInTheLastWeekCount = 0;
        var weeksWhereAceWasFound = new List<int>();

        for (var i = 0; i < collectionOfShuffledDecks.Count; i++)
        {
            for (var j = 0; j < collectionOfShuffledDecks[i].Count; j++)
            {
                var index = collectionOfShuffledDecks[i].IndexOf(DeckConstants.AceOfSpadesValue);
                if(collectionOfShuffledDecks[i][j] == DeckConstants.AceOfSpadesValue)
                {
                    if (index == 51)
                    {
                        aceInTheLastWeekCount++;
                        weeksWhereAceWasFound.Add(index);
                    }
                    else
                    {
                        weeksWhereAceWasFound.Add(index);
                    }
                }
            }
        }

        return (aceInTheLastWeekCount, weeksWhereAceWasFound);
    }
}