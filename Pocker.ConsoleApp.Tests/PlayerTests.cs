using Poker.ConsoleApp.Classes;

namespace Pocker.ConsoleApp.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void GetsHand()
        {
            // Arrange
            Player player = new Player();
            Card card1 = new Card(8, Suits.Diamonds);
            Card card2 = new Card(14, Suits.Hearts);

            player.AddCardToHand(card1);
            player.AddCardToHand(card2);

            // Act
            List<Card> result = player.GetHand();

            // Assert
            Assert.AreEqual(card1, result[0]);
            Assert.AreEqual(card2, result[1]);
        }

        [TestMethod]
        public void GetsCorrectTotalChipsValue()
        {
            // Arrange
            Player player = new Player();
            Chip whiteChip = new Chip("WHITE", 1);
            Chip redChip = new Chip("RED", 5);
            Chip blueChip = new Chip("BLUE", 10);
            Chip blackChip = new Chip("BLACK", 100);
            Chip purpleChip = new Chip("PURPLE", 500);

            player.AddChip(whiteChip);
            player.AddChip(redChip);
            player.AddChip(blueChip);
            player.AddChip(blackChip);
            player.AddChip(purpleChip);

            // Act
            int result = player.GetTotalChipsValue();

            // Assert
            Assert.AreEqual(616, result);
        }
    }
}
