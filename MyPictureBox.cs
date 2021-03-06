﻿using System;
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
        public MyPictureBox()
        {

        }

        public MyPictureBox(Card c, bool player, int index) : base()
        {
            this.Image = Game.cardHelper.drawCard(c.Color, c.Number);
            this.Location = new Point(105 + index*40, player ? 344 : 124);
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Name = "romanalex_card_" + player + "_" + index;

            Size tempSize = this.Size;
            tempSize.Height = 137;
            this.Size = tempSize;
        }

        public MyPictureBox(bool player, int index, bool backcard) : base()
        {
            this.Image = Game.cardHelper.drawBackcard();
            this.Location = new Point(105 + index * 40, player ? 344 : 124);
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Name = "top_card";

            Size tempSize = this.Size;
            tempSize.Height = 137;
            this.Size = tempSize;
        }

    }
}
