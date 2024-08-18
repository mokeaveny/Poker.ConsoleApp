using Poker.ConsoleApp.Interfaces;

namespace Poker.ConsoleApp.Classes
{
    public class Card : ICard
    {
        public int Value { get; set; }
        public Suits Suit { get; set; }
        public Card(int value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public string NamedValue()
        {
            string name = string.Empty;
            switch (Value)
            {
                case 11:
                    name = "Jack";
                    break;
                case 12:
                    name = "Queen";
                    break;
                case 13:
                    name = "King";
                    break;
                case 14:
                    name = "Ace";
                    break;
                default:
                    name = Value.ToString();
                    break;
            }
            return name;
        }

        public string DisplayName()
        {
            return NamedValue() + " of " + Suit.ToString();
        }
    }
}
