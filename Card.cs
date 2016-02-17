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
            get { return this.Color; }
            set { this.Color = value; }
        }

        public int Number
        {
            get { return this.Number; }
            set { this.Number = value; }
        }

        public Card(int color, int number)
        {
            this.Color = color;
            this.Number = number;
        }
    }
}
