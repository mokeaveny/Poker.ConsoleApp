using Poker.ConsoleApp.Interfaces;

namespace Poker.ConsoleApp.Classes
{
    public class Deck : IDeck
    {
        private List<Card> Cards = new List<Card>();

        public void Fill()
        {
            for (int i = 0; i < 52; i++)
            {
                Suits suit = (Suits)(Math.Floor((decimal)i / 13));
                int value = i % 13 + 2;
                Card newCard = new Card(value, suit);

                this.Cards.Add(newCard);
            }
        }

        public void Shuffle()
        {
            Random r = new Random();

            for (int n = this.Cards.Count - 1; n > 0; --n)
            {
                int randomNumber = r.Next(n + 1);
                Card temp = this.Cards[n];
                this.Cards[n] = this.Cards[randomNumber];
                this.Cards[randomNumber] = temp;
            }
        }

        public List<Card> GetAllCards()
        {
            return this.Cards;
        }
    }
}
