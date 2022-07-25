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
        public void ShufflesAllDecks_ValidDeckCollection_ShuffledDeckCollection()
        {
            //checks to see if all decks are shuffled in the deck collection
            //use assert.notequal to check that the decks have been shuffle
        }


        [Fact]
        public void ShufflesAllDecks_InvalidDeckCollection_ReturnsSomething()
        {
            var deckBuilder = new DeckBuilder();
        }


        [Fact]
        public void ShuffleDeck_ValidCardDeck_ValidShuffledDeck()
        {
            //checks if a deck of 52 cards is shuffled
        }

        [Fact]
        public void ShuffleDeck_InvalidCardDeckSize_ThrowsException() 
        {
            //returns something if the deck size is not 52?
            //throws an exception?
            var deckBuilder = new DeckBuilder();
            var orderedDeck = deckBuilder.InitializeDeck(1);
            var testDeck = deckBuilder.InitializeDeck(1);
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