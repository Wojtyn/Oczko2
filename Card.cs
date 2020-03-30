using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oczko2
{
    public class Card
    {
        int value;
        int color;
        int name;
        string picture;

        public Card()
        {
        }

        public Card(int name, int col)
        {
            this.name = name;
            color = col;
            if (name < 11)
                value = name;
            else
                value = 10;
            picture = name.ToString() + color.ToString();
        }

    }
}
