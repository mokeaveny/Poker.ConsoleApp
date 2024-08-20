using Poker.ConsoleApp.Interfaces;

namespace Poker.ConsoleApp.Classes
{
    public class Table : ITable
    {
        private List<Player> Players = new List<Player>();
        private List<Card> CommunityCards = new List<Card>();
        private IDeck Deck;
        private int MaximumNumberOfPlayers = 10;
        private ILogger logger;

        public Table(IDeck deck, ILogger logger)
        {
            this.Deck = deck;
            this.logger = logger;
        }

        public void AddPlayer(Player player)
        {
            if (Players.Count != MaximumNumberOfPlayers)
            {
                this.Players.Add(player);
            }
            else
            {   
                this.logger.Log("Failed to add player. Maximum number of players exist.");
            }
        }

        public List<Player> GetPlayers()
        {
            return this.Players;
        }

        public List<Card> GetCommunityCards()
        {
            return this.CommunityCards;
        }

        public void DealFlop()
        {
            Card card1 = this.Deck.DealCard();
            Card card2 = this.Deck.DealCard();
            Card card3 = this.Deck.DealCard();
            this.CommunityCards.Add(card1);
            this.CommunityCards.Add(card2);
            this.CommunityCards.Add(card3);
        }

        public void DealTurn()
        {
            Card card = this.Deck.DealCard();
            this.CommunityCards.Add(card);
        }

        public void DealRiver()
        {
            Card card = this.Deck.DealCard();
            this.CommunityCards.Add(card);
        }
    }
}
