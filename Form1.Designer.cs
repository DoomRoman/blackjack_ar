namespace Hearts
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btNewGame = new System.Windows.Forms.Button();
            this.btCloseGame = new System.Windows.Forms.Button();
            this.btShowPoints = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btHit = new System.Windows.Forms.Button();
            this.btStand = new System.Windows.Forms.Button();
            this.points_bank = new System.Windows.Forms.Label();
            this.points_player = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // btNewGame
            // 
            this.btNewGame.BackColor = System.Drawing.Color.LightBlue;
            this.btNewGame.Location = new System.Drawing.Point(13, 13);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(86, 34);
            this.btNewGame.TabIndex = 0;
            this.btNewGame.Text = "NEW GAME";
            this.btNewGame.UseVisualStyleBackColor = false;
            this.btNewGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCloseGame
            // 
            this.btCloseGame.BackColor = System.Drawing.Color.LightCoral;
            this.btCloseGame.Location = new System.Drawing.Point(105, 13);
            this.btCloseGame.Name = "btCloseGame";
            this.btCloseGame.Size = new System.Drawing.Size(91, 34);
            this.btCloseGame.TabIndex = 1;
            this.btCloseGame.Text = "CLOSE GAME";
            this.btCloseGame.UseVisualStyleBackColor = false;
            this.btCloseGame.Click += new System.EventHandler(this.btCloseGame_Click);
            // 
            // btShowPoints
            // 
            this.btShowPoints.BackColor = System.Drawing.Color.OrangeRed;
            this.btShowPoints.Location = new System.Drawing.Point(202, 12);
            this.btShowPoints.Name = "btShowPoints";
            this.btShowPoints.Size = new System.Drawing.Size(107, 34);
            this.btShowPoints.TabIndex = 2;
            this.btShowPoints.Text = "SHOW POINTS";
            this.btShowPoints.UseVisualStyleBackColor = false;
            this.btShowPoints.Click += new System.EventHandler(this.btShowPoints_Click);
            // 
            // background
            // 
            this.background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.background.Image = global::Hearts.Properties.Resources.table_blackjack;
            this.background.Location = new System.Drawing.Point(13, 52);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1076, 532);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 3;
            this.background.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player";
            // 
            // btHit
            // 
            this.btHit.BackColor = System.Drawing.Color.LightBlue;
            this.btHit.Location = new System.Drawing.Point(105, 503);
            this.btHit.Name = "btHit";
            this.btHit.Size = new System.Drawing.Size(100, 57);
            this.btHit.TabIndex = 8;
            this.btHit.Text = "HIT";
            this.btHit.UseVisualStyleBackColor = false;
            this.btHit.Click += new System.EventHandler(this.btHit_Click);
            // 
            // btStand
            // 
            this.btStand.BackColor = System.Drawing.Color.LightCoral;
            this.btStand.Location = new System.Drawing.Point(227, 503);
            this.btStand.Name = "btStand";
            this.btStand.Size = new System.Drawing.Size(104, 57);
            this.btStand.TabIndex = 9;
            this.btStand.Text = "STAND";
            this.btStand.UseVisualStyleBackColor = false;
            // 
            // points_bank
            // 
            this.points_bank.AutoSize = true;
            this.points_bank.BackColor = System.Drawing.Color.Transparent;
            this.points_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_bank.Location = new System.Drawing.Point(187, 96);
            this.points_bank.Name = "points_bank";
            this.points_bank.Size = new System.Drawing.Size(95, 25);
            this.points_bank.TabIndex = 10;
            this.points_bank.Text = "Punkte: 0";
            // 
            // points_player
            // 
            this.points_player.AutoSize = true;
            this.points_player.BackColor = System.Drawing.Color.Transparent;
            this.points_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_player.Location = new System.Drawing.Point(202, 315);
            this.points_player.Name = "points_player";
            this.points_player.Size = new System.Drawing.Size(95, 25);
            this.points_player.TabIndex = 11;
            this.points_player.Text = "Punkte: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 596);
            this.Controls.Add(this.points_player);
            this.Controls.Add(this.points_bank);
            this.Controls.Add(this.btStand);
            this.Controls.Add(this.btHit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btShowPoints);
            this.Controls.Add(this.btCloseGame);
            this.Controls.Add(this.btNewGame);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNewGame;
        private System.Windows.Forms.Button btCloseGame;
        private System.Windows.Forms.Button btShowPoints;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btHit;
        private System.Windows.Forms.Button btStand;
        private System.Windows.Forms.Label points_bank;
        private System.Windows.Forms.Label points_player;
    }
}

