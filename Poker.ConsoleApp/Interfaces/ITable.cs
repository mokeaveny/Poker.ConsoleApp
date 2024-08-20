using Poker.ConsoleApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.ConsoleApp.Interfaces
{
    public interface ITable
    {
        public void AddPlayer(Player player);
        public List<Player> GetPlayers();
        public List<Card> GetCommunityCards();
        public void DealFlop();
        public void DealTurn();
        public void DealRiver();
        public List<Player> GetAllActivePlayers();
        public void DealToAllPlayers();
        public void DealToPlayer(Player player);
    }
}
