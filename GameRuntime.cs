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
            timer.Interval = 400;
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
            this.gameHelper.points_bank = 0;
            this.gameHelper.points_bank_hidden = 0;
            this.gameHelper.points_player = 0;

            deleteOldCards();
            firstCards();
            renderPoints();
        }

        public void newRound()
        {
            this.cardIndexBank = 0;
            this.cardIndexPlayer = 0;
            this.gameHelper.points_bank = 0;
            this.gameHelper.points_bank_hidden = 0;
            this.gameHelper.points_player = 0;

            gameHelper.count_aces_bank = 0;
            gameHelper.count_aces_player = 0;
            deleteOldCards();
            firstCards();
            renderPoints();
        }

        private void removeTopcard()
        {
            // to remove topcard
            foreach (Control item in form.Controls)
            {
                if (item.Name == "top_card")
                {
                    form.Controls.Remove(item);
                    break; //important step
                }
            }
        }
        public void bankStep()
        {
            removeTopcard();
            timer.Start();
        }

        private void bankStepTick(Object sender, EventArgs e)
        {
            if (getPointsBank() > getPointsPlayer() && getPointsBank() <= 21)
            {
                timer.Stop();
                renderPoints();
                showWinMessage("Ooops", "You Loose!");
                return;
            }
            else if (getPointsBank() <= getPointsPlayer())
            {
                nextCard(false);
                renderPoints();
                return;
            }
            else if (getPointsBank() == 21 && getPointsBank() == getPointsPlayer())
            {
                timer.Stop();
                renderPoints();
                showWinMessage("Tie", "It's a Tie!");
                return;
            }
            renderPoints();
            timer.Stop();
            showWinMessage("Winner!", "You Won!");
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
            gameHelper.points_bank_hidden = gameHelper.getPointsOfCard(c3,false);
            gameHelper.points_bank -= gameHelper.points_bank_hidden;
            drawPictureBackcard(c3, false, cardIndexBank-1);
            addNewCard(c4, true);
        }

        private void addNewCard(Card c, bool player)
        {
            gameHelper.calcPoints(c, player);
            drawPicture(c, player, (player ? cardIndexPlayer++ : cardIndexBank++));
            renderPoints();
            if (player)
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

        private void drawPictureBackcard(Card c, bool player, int index)
        {
            PictureBox pic = new MyPictureBox(player, index, true);
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
        public void recalcBankPoints()
        {
            gameHelper.points_bank += gameHelper.points_bank_hidden;
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
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, title, buttons);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (gameHelper.isNewGamePossible())
                {
                    Console.WriteLine(gameHelper.total_points);
                    this.newRound();
                }
                else
                {
                    buttons = MessageBoxButtons.OKCancel;
                    result = MessageBox.Show("The game is over! The cards are drawn", "New Game?", buttons);

                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        this.initStep();
                    }
                    else
                    {
                        Application.Exit();
                    }                        
                }
            }
        }
    }
}
