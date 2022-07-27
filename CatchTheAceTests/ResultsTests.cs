using Xunit.Abstractions;
using CatchTheAce;

namespace CatchTheAceTests
{
    public class ResultsTests
    {
        private ITestOutputHelper _testOutputHelper;

        public ResultsTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(50)]
        public void GoThroughResults_ValidInput_ValidResults(int numOfYears)
        {
            var deckBuilder = new DeckBuilder();
            var validDeck = deckBuilder.InitializeDeck(numOfYears);
            deckBuilder.ShufflesAllDecks(validDeck);
            var resultsbuilder = new Results();
            var (count, listOfWeeks) = resultsbuilder.GoThroughResults(validDeck);

            _testOutputHelper.WriteLine("Number of times the Ace was found in the last week: " + count.ToString());
            _testOutputHelper.WriteLine("List of weeks where ace was found: " + string.Join(",", listOfWeeks));
            Assert.IsType<int>(count);
            Assert.IsType<List<int>>(listOfWeeks);

        }



    }
}
