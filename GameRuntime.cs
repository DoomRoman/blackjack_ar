using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hearts
{
    class GameRuntime
    {
        private GameHelper gameHelper;
        private Form form;
        private Label lbPointsPlayer;
        private Label lbPointsBank;

        private Timer timer;

        private int numberOfDecks;
        private int cardIndexPlayer = 0;
        private int cardIndexBank = 0;


        public GameRuntime(int numberOfDecks, Form form)
        {
            this.numberOfDecks = numberOfDecks;
            this.form = form;
            getLabelsForPoints(form);

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += new EventHandler(bankStepTick);
        }

        private void getLabelsForPoints(Form form)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl.Name == "points_player")
                {
                    this.lbPointsPlayer = (Label)ctrl;
                }
                else if (ctrl.Name == "points_bank")
                {
                    this.lbPointsBank = (Label)ctrl;
                }
            }
        }

        public void initStep()
        {
            this.gameHelper = new GameHelper(numberOfDecks);
            this.cardIndexBank = 0;
            this.cardIndexPlayer = 0;

            deleteOldCards();
            firstCards();
        }

        public void newRound()
        {
            this.cardIndexBank = 0;
            this.cardIndexPlayer = 0;
            this.gameHelper.points_bank = 0;
            this.gameHelper.points_player = 0;

            deleteOldCards();
            firstCards();
        }

        public void bankStep()
        {
            timer.Start();
        }

        private void bankStepTick(Object sender, EventArgs e)
        {
            if (getPointsBank() > getPointsPlayer() && getPointsBank() <= 21)
            {
                showWinMessage("Ooops", "You Loose!");
                timer.Stop();
                return;
            }
            else if (getPointsBank() < getPointsPlayer())
            {
                nextCard(false);
            }
            else if (getPointsBank() == 21 && getPointsBank() == getPointsPlayer())
            {
                showWinMessage("Tie", "It's a Tie!");
                timer.Stop();
                return;
            }
            showWinMessage("Winner!", "You Won!");
            timer.Stop();
        }

        public void nextCard(bool player)
        {
            Card c = gameHelper.getRandomCard();
            addNewCard(c, player);
        }

        public int getPointsBank()
        {
            return gameHelper.points_bank;
        }

        public int getPointsPlayer()
        {
            return gameHelper.points_player;
        }

        public void renderPoints()
        {
            if (this.lbPointsBank != null)
            {
                lbPointsBank.Text = "Punkte: " + getPointsBank();
            }
            if (this.lbPointsPlayer != null)
            {
                lbPointsPlayer.Text = "Punkte: " + getPointsPlayer();
            }
        }

        private void firstCards()
        {
            Card c1 = this.gameHelper.getRandomCard();
            Card c2 = this.gameHelper.getRandomCard();
            Card c3 = this.gameHelper.getRandomCard();
            Card c4 = this.gameHelper.getRandomCard();

            addNewCard(c1, false);
            addNewCard(c2, true);
            addNewCard(c3, false);
            addNewCard(c4, true);
        }

        private void addNewCard(Card c, bool player)
        {
            gameHelper.calcPoints(c, player);
            drawPicture(c, player, (player ? cardIndexPlayer++ : cardIndexBank++));
            if(player)
            {
                if(gameHelper.points_player == 21)
                {
                    bankStep();
                }
                else if(gameHelper.points_player > 21)
                {
                    showWinMessage("Oops!", "You Loose! You're over 21 points :-(");
                }
            }
        }

        private void drawPicture(Card c, bool player, int index)
        {
            PictureBox pic = new MyPictureBox(c, player, index);
            form.Controls.Add(pic);
            pic.BringToFront();
        }

        private void deleteOldCards()
        {
            do
            {
                clearMyPictureBoxes();
            }
            while (formContainsMyPictureBoxes());
        }

        private void clearMyPictureBoxes()
        {
            foreach (Control ctrl in this.form.Controls)
            {
                if (ctrl.GetType() == new MyPictureBox().GetType())
                {
                    form.Controls.Remove(ctrl);
                }
            }
        }

        private bool formContainsMyPictureBoxes()
        {
            foreach (Control ctrl in this.form.Controls)
            {
                if (ctrl.GetType() == new MyPictureBox().GetType())
                {
                    return true;
                }
            }
            return false;
        }

        public void showWinMessage(string title, string message)
        {
            //todo show win message
            Console.WriteLine(title + ": " + message);
        }
    }
}
