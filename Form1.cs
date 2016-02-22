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
            this.btHit.Visible = true;
            this.btShowPoints.Visible = true;
            this.btStand.Visible = true;
            Game.runtime = new GameRuntime(4, this);
            Game.runtime.initStep();
            Game.runtime.renderPoints();
        }

        private void btCloseGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btShowPoints_Click(object sender, EventArgs e)
        {
            if (this.points_bank.Visible == true)
            {
                this.points_bank.Visible = false;
                this.points_player.Visible = false;
            }
            else
            {
                this.points_bank.Visible = true;
                this.points_player.Visible = true;
            }
        }

        private void btHit_Click(object sender, EventArgs e)
        {
            Game.runtime.nextCard(true);
            Game.runtime.renderPoints();
        }

        private void btStand_Click(object sender, EventArgs e)
        {
            Game.runtime.bankStep();
        }
    }
}
