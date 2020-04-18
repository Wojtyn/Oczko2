using System.Collections.Generic;
using System.Drawing;

namespace Oczko2
{
    public class Player
    {
        private int points;
        private int money;
        private List<Card> hand;

        public Player()
        {
            points = 0;
            money = 100;
        }

        public virtual void DrawCard(Deck d) {}

        public virtual void Pass() {}

        public virtual void DoubleDown() {}

        public virtual void Split() {}


    }
}