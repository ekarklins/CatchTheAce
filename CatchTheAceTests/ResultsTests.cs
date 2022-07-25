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

        [Fact]
        public void GoThroughResults_ValidInput_ValidResults()
        {
            var deckBuilder = new DeckBuilder();
            var validDeck = deckBuilder.InitializeDeck(5);
            deckBuilder.ShufflesAllDecks(validDeck);
            var resultsbuilder = new Results();
            var (count, listOfWeeks) = resultsbuilder.GoThroughResults(validDeck);
            Assert.IsType<int>(count);
            Assert.IsType<List<int>>(listOfWeeks);
        }



    }
}
