using Poker.ConsoleApp.Classes;

namespace Pocker.ConsoleApp.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void AceOfHeartsDisplaysCorrectly()
        {
            // Arrange
            Card aceOfHearts = new Card(14, Suits.Hearts);

            // Act 
            string result = aceOfHearts.DisplayName();

            // Assert
            Assert.AreEqual("Ace of Hearts", result);
        }

        [TestMethod]
        public void KingOfSpadesDisplaysCorrectly()
        {
            // Arrange
            Card kingOfSpades = new Card(13, Suits.Spades);

            // Act 
            string result = kingOfSpades.DisplayName();

            // Assert
            Assert.AreEqual("King of Spades", result);
        }

        [TestMethod]
        public void QueenOfClubsDisplaysCorrectly()
        {
            // Arrange
            Card queenOfClubs = new Card(12, Suits.Clubs);

            // Act
            string result = queenOfClubs.DisplayName();

            // Assert
            Assert.AreEqual("Queen of Clubs", result);
        }

        [TestMethod]
        public void JackOfDiamondsDisplaysCorrectly()
        {
            // Arrange
            Card jackOfDiamonds = new Card(11, Suits.Diamonds);

            // Act
            string result = jackOfDiamonds.DisplayName();

            // Assert
            Assert.AreEqual("Jack of Diamonds", result);
        }

        [TestMethod]
        public void FourOfHeartsDisplaysCorrectly()
        {
            // Arrange
            Card fourOfHearts = new Card(4, Suits.Hearts);

            // Act
            string result = fourOfHearts.DisplayName();

            // Assert
            Assert.AreEqual("4 of Hearts", result);
        }

        [TestMethod]
        public void TenOfDiamondsDisplaysCorrectly()
        {
            // Arrange
            Card tenOfDiamonds = new Card(10, Suits.Diamonds);

            // Act
            string result = tenOfDiamonds.DisplayName();

            // Assert
            Assert.AreEqual("10 of Diamonds", result);
        }
    }
}
