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
        public void ShufflesAllDecks_DeckCollection_ShuffledDecksWithinDeckCollection()
        {
            var deckBuilder = new DeckBuilder();
            var orderedDeck = deckBuilder.InitializeDeck(3);
            var anotherOrderedDeck = deckBuilder.InitializeDeck(3);
            var testdeck = deckBuilder.InitializeDeck(3);
            deckBuilder.ShufflesAllDecks(testdeck);
            Assert.True(orderedDeck != testdeck);
            Assert.Equal(orderedDeck, anotherOrderedDeck);

        }


        [Fact]
        public void ShuffleDeck_ValidCardDeck_ValidShuffledDeck()
        {
            //checks if a deck of 52 cards is shuffled
            var deckBuilder = new DeckBuilder();
            var orderedDeck = deckBuilder.InitializeDeck(1);
            var testDeck = deckBuilder.InitializeDeck(1);
            var shuffleDeck = deckBuilder.ShuffleDeck(testDeck[0]);
            Assert.Equal(orderedDeck, testDeck);
            Assert.NotEqual(orderedDeck[0], shuffleDeck);
        }


        [Fact]
        public void InitializeDeck_OneYear_ReturnsOneDeckWith52CardsWithinADeck()
        {
            //Checks if the deck length is 52
            var deckBuilder = new DeckBuilder();
            var result = deckBuilder.InitializeDeck(1);
            var expected = 52;
            Assert.Equal(expected, result[0].Count);

        }

        [Fact]
        public void InitializeDeck_s_Something()
        {
            //Checks if there is no repeating numbers
            //Is this test needed?
        }

    }
}