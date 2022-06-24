namespace CatchTheAce;

public class Results : UI
{      
    public static readonly List<int> WeeksWhereAceWasFound = new List<int>();
    private const int AceOfSpadesValue = 52;
    /// <summary>
    /// Goes through a deck collection and finds the Ace of Spades and its index.
    /// The Ace of Spades is represented by the value 52.
    /// The index variable represents the week.
    /// Adds the indexes to a new list that is used to display results.
    /// </summary>
    /// <param name="collectionOfShuffledDecks"></param>
    /// <returns>A list of week numbers that 52(Ace of Spades) was found</returns>
    public List<int> GoThroughResults(List<List<int>> collectionOfShuffledDecks)
    {
        for (var i = 0; i < collectionOfShuffledDecks.Count; i++)
        {
            for (var j = 0; j < collectionOfShuffledDecks[i].Count; j++)
            {
                var index = collectionOfShuffledDecks[i].IndexOf(AceOfSpadesValue);
                if(collectionOfShuffledDecks[i][j] == AceOfSpadesValue)
                {
                    if (index == 51)
                    {
                        Program.AceInTheLastWeekCount++;
                        WeeksWhereAceWasFound.Add(index);
                    }
                    else
                    {
                        WeeksWhereAceWasFound.Add(index);
                    }
                }
            }
        }
        return WeeksWhereAceWasFound;
    }
}