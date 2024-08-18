using Poker.ConsoleApp.Classes;

namespace Pocker.ConsoleApp.Tests
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void CreatesADeckOfFiftyTwoCorrectCards()
        {
            // Arrange
            Deck deck = new Deck();
            Dictionary<int, int> cardValueInstances = new Dictionary<int, int>();
            Dictionary<Suits, int> suitInstances = new Dictionary<Suits, int>();

            // Act
            deck.Fill();

            for (int i = 0; i < deck.GetAllCards().Count; i++)
            {
                Card currentCard = deck.GetAllCards()[i];
                
                if (cardValueInstances.ContainsKey(currentCard.Value) == false)
                {
                    cardValueInstances[currentCard.Value] = 1;
                }
                else
                {
                    cardValueInstances[currentCard.Value]++;
                }

                if (suitInstances.ContainsKey(currentCard.Suit) == false)
                {
                    suitInstances[currentCard.Suit] = 1;
                }
                else
                {
                    suitInstances[currentCard.Suit]++;
                }
            }

            // Assert

            // First check that there are 52 cards for a full deck
            Assert.AreEqual(52, deck.GetAllCards().Count);

            // Next check that there are 4 instances of each card value (2 - 14)
            Assert.AreEqual(4, cardValueInstances[2]);
            Assert.AreEqual(4, cardValueInstances[3]);
            Assert.AreEqual(4, cardValueInstances[4]);
            Assert.AreEqual(4, cardValueInstances[5]);
            Assert.AreEqual(4, cardValueInstances[6]);
            Assert.AreEqual(4, cardValueInstances[7]);
            Assert.AreEqual(4, cardValueInstances[8]);
            Assert.AreEqual(4, cardValueInstances[9]);
            Assert.AreEqual(4, cardValueInstances[10]);
            Assert.AreEqual(4, cardValueInstances[11]);
            Assert.AreEqual(4, cardValueInstances[12]);
            Assert.AreEqual(4, cardValueInstances[13]);
            Assert.AreEqual(4, cardValueInstances[14]);

            // Next check that there are 13 instances of each suit value (Diamonds, Hearts, Spades, Clubs)
            Assert.AreEqual(13, suitInstances[Suits.Hearts]);
            Assert.AreEqual(13, suitInstances[Suits.Diamonds]);
            Assert.AreEqual(13, suitInstances[Suits.Spades]);
            Assert.AreEqual(13, suitInstances[Suits.Clubs]);
        }
    }
}
