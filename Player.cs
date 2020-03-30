using System.Drawing;

namespace Oczko2
{
    public class Player
    {
        private int points;
        private int money;

        public Player()
        {
            points = 0;
            money = 100;
        }

        public virtual void DrawCard() {}
        public virtual void MoneyBet() {}

        
    }
}