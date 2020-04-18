using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oczko2
{
    public class Deck : Card
    {
        List<Card> deck;


        void Fill()
        {
            for (int d = 0; d < 4; d++)
            {
                for (int i = 1; i < 5; i++)
                {
                    for (int j = 1; j < 14; j++)
                    {
                        Card help = new Card(i, j);
                        deck.Add(help);
                    }
                }
            }
        }

        void Scramble()
        {

        }
    }
}
