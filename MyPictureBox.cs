using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Hearts
{
    class MyPictureBox : PictureBox
    {
        public MyPictureBox(Card c, bool player, int index) : base()
        {
            this.Image = Game.cardHelper.drawCard(c.Color, c.Number);
            this.Location = new Point(105 + index*40, player ? 344 : 124);
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            Size tempSize = this.Size;
            tempSize.Height = 137;
            this.Size = tempSize;
        }
    }
}
