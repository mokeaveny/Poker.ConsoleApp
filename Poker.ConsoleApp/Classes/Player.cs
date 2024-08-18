using Poker.ConsoleApp.Interfaces;

namespace Poker.ConsoleApp.Classes
{
    public class Player : IPlayer
    {
        private List<Card> Hand = new List<Card>();
        private List<Chip> Chips = new List<Chip>();

        public void AddCardToHand(Card card)
        {
            this.Hand.Add(card);
        }

        public List<Card> GetHand()
        {
            return this.Hand;
        }

        public List<Chip> GetChips()
        {
            return this.Chips;
        }

        public void AddChip(Chip chip)
        {
            this.Chips.Add(chip);
        }

        public int GetTotalChipsValue()
        {
            int total = 0;

            foreach (Chip chip in this.Chips)
            {
                total += chip.Value;
            }

            return total;
        }
    }
}
