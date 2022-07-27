using CatchTheAce;
using Xunit.Abstractions;

namespace CatchTheAceTests
{
    public class DeckBuilderTests
    {
        private ITestOutputHelper _testOutputHelper;

        public DeckBuilderTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void InitializeDeck_OneYear_ReturnsOneDeckWith52CardsWithinADeck()
        {
            var deckBuilder = new DeckBuilder();
            var resultDeck = deckBuilder.InitializeDeck(1).First();
            var expected = DeckConstants.CardsInDeck;

            Assert.Equal(expected, resultDeck.Count);

            var counter = 1;
            resultDeck.ForEach(card =>
            {
                Assert.Equal(counter, card);
                counter++;
            });

            _testOutputHelper.WriteLine(string.Join(",", resultDeck));
        }

        [Fact]
        public void ShuffleDeck_ValidCardDeck_ValidShuffledDeck()
        {
            var deckBuilder = new DeckBuilder();
            var resultDeck = deckBuilder.InitializeDeck(1).First();
            var resultDeckShuffled = deckBuilder.ShuffleDeck(resultDeck);

            Assert.Equal(DeckConstants.CardsInDeck, resultDeckShuffled.Count);

            _testOutputHelper.WriteLine(string.Join(",", resultDeckShuffled));

        }

        [Fact]
        public void ShufflesAllDecks_DeckCollection_ShuffledValidDecksWithinDeckCollection()
        {
            var deckBuilder = new DeckBuilder();
            var testdeck = deckBuilder.InitializeDeck(3);
            deckBuilder.ShufflesAllDecks(testdeck);

            testdeck.ForEach(deck =>
            {
                Assert.Equal(DeckConstants.CardsInDeck, deck.Count);
                _testOutputHelper.WriteLine(string.Join(",", deck));
            });

            
        }


        


    }
}