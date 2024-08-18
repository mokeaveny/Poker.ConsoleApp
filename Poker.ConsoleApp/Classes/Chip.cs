namespace Poker.ConsoleApp.Classes
{
    public class Chip
    {
        public string Colour { get; set; }
        public int Value { get; set; }
        public Chip(string colour, int value)
        {
            this.Colour = colour;
            this.Value = value;
        }
    }
}
