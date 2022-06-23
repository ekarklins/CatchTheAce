namespace CatchTheAce;

public class Results : UI
{      
    public static readonly List<int> weeks = new List<int>();
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
                if(collection[i][j] == 52)
                {
                    if (index == 51)
                    {
                        Counter++;
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