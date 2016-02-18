using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Hearts
{
    class CardHelper
    {
        public enum CardColors { Kreuz = 0, Pik, Herz, Karo};
        public enum CardNumbers { Zwei = 2, Drei, Vier, Fünf, Sechs, Sieben, Acht, Neun, Zehn, Bube, Dame, Koenig, Ass};

        const int cards_cols = 13, cards_rows = 4;
        Bitmap[,] cards = new Bitmap[cards_cols, cards_rows];


        public CardHelper()
        {
            Bitmap bmpOrig = new Bitmap("../../Cards/classic-cards-gray.gif");

            int sz_x = bmpOrig.Width / cards_cols;
            int sz_y = bmpOrig.Height / cards_rows;

            for (int iy = 0; iy < 4; ++iy)
            {
                int y = ((iy & 1) != 0) ? 4 - iy : iy; // Tausche Reihe 1 und 3
                for (int x = 0; x < 13; ++x)
                {
                    Rectangle rect = new Rectangle(x * sz_x, iy * sz_y, sz_x, sz_y);
                    cards[x, y] = Copy(bmpOrig, rect);
                }
            }
        }

        private Bitmap Copy(Bitmap srcBitmap, Rectangle section)
        {
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
            g.Dispose();
            return bmp;
        }

        public Bitmap drawCard(int color, int number)
        {
            return this.cards[number, color];
        }
    }
}
