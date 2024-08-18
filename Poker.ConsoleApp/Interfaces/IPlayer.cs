using Poker.ConsoleApp.Classes;

namespace Poker.ConsoleApp.Interfaces
{
    public interface IPlayer
    {
        public void AddCardToHand(Card card);
        public List<Card> GetHand();
        public void AddChip(Chip chip);
        public int GetTotalChipsValue();
    }
}
