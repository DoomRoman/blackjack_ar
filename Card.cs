using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    class Card
    {
        public int Color
        {
            get; set;
        }

        public int Number
        {
            get; set;
        }

        public Card(int color, int number)
        {
            this.Color = color;
            this.Number = number;
        }
    }
}
