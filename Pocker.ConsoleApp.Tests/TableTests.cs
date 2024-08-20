using Moq;
using Poker.ConsoleApp.Classes;
using Poker.ConsoleApp.Interfaces;

namespace Pocker.ConsoleApp.Tests
{
    [TestClass]
    public class TableTests
    {
        [TestMethod]
        public void TableHasValidNumberOfPlayers()
        {
            // Arrange
            Deck deck = new Deck();
            deck.Fill();
            Mock<ILogger> logger = new Mock<ILogger>();
            Table table = new Table(deck, logger.Object);

            // Act
            Player player1 = new Player();
            table.AddPlayer(player1);
            Player player2 = new Player();
            table.AddPlayer(player2);
            Player player3 = new Player();
            table.AddPlayer(player3);

            // Assert
            logger.Verify(l => l.Log("Failed to add player. Maximum number of players exist."),
                Times.Never());
        }

        [TestMethod]
        public void TableAddMoreThanMaximumNumberOfPlayers()
        {
            // Arrange
            Deck deck = new Deck();
            deck.Fill();
            Mock<ILogger> logger = new Mock<ILogger>();
            Table table = new Table(deck, logger.Object);

            for (int i = 0; i <= 9; i++)
            {
                Player player = new Player();
                table.AddPlayer(player);
            }

            // Act
            Player player11 = new Player();
            table.AddPlayer(player11);

            // Assert
            logger.Verify(l => l.Log("Failed to add player. Maximum number of players exist."), 
                Times.Once());
        }

        [TestMethod]
        public void CommunityCardsFlopDealt()
        {
            // Arrange
            Deck deck = new Deck();
            deck.Fill();
            Mock<ILogger> logger = new Mock<ILogger>();
            Table table = new Table(deck, logger.Object);

            // Act
            table.DealFlop();

            // Assert
            Assert.AreEqual(3, table.GetCommunityCards().Count);
        }

        [TestMethod]
        public void CommunityCardsTurnDealt()
        {
            // Arrange
            Deck deck = new Deck();
            deck.Fill();
            Mock<ILogger> logger = new Mock<ILogger>();
            Table table = new Table(deck, logger.Object);

            // Act
            table.DealFlop();
            table.DealTurn();

            // Assert
            Assert.AreEqual(4, table.GetCommunityCards().Count);
        }

        [TestMethod]
        public void CommunityCardsRiverDealt()
        {
            // Arrange
            Deck deck = new Deck();
            deck.Fill();
            Mock<ILogger> logger = new Mock<ILogger>();
            Table table = new Table(deck, logger.Object);

            // Act
            table.DealFlop();
            table.DealTurn();
            table.DealRiver();

            // Assert
            Assert.AreEqual(5, table.GetCommunityCards().Count);
        }
    }
}
