using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hearts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //New Game
        private void button1_Click(object sender, EventArgs e)
        {
            Game.gameHelper = new GameHelper(4);
            firstCards();
        }

        private void btCloseGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btShowPoints_Click(object sender, EventArgs e)
        {

        }


        private void firstCards()
        {
            Card c1 = Game.gameHelper.getRandomCard();
            Card c2 = Game.gameHelper.getRandomCard();
            Card c3 = Game.gameHelper.getRandomCard();
            Card c4 = Game.gameHelper.getRandomCard();

            addPicture(c1, false, 0);
            addPicture(c2, true, 0);
            addPicture(c3, false, 1);
            addPicture(c4, true, 1);

       
        }

        private void addPicture(Card c, bool player, int index)
        {
            PictureBox pic = new MyPictureBox(c, player, index);
            this.Controls.Add(pic);
            pic.BringToFront();
        }
    }
}
