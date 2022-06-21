namespace P_Demomot.Views
{
    partial class FtGameView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPLayerTwo = new System.Windows.Forms.Label();
            this.pgbTimer = new System.Windows.Forms.ProgressBar();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pnlTeamOneFighterOne = new System.Windows.Forms.Panel();
            this.pnlTeamOneFighterTwo = new System.Windows.Forms.Panel();
            this.pnlTeamOneFighterThree = new System.Windows.Forms.Panel();
            this.pnlTeamTwoFighterThree = new System.Windows.Forms.Panel();
            this.pnlTeamTwoFighterTwo = new System.Windows.Forms.Panel();
            this.pnlTeamTwoFighterOne = new System.Windows.Forms.Panel();
            this.pnlTeamOneRemplacerTwo = new System.Windows.Forms.Panel();
            this.pnlTeamOneRemplacerOne = new System.Windows.Forms.Panel();
            this.lblRemplacerTeamOne = new System.Windows.Forms.Label();
            this.lblRemplacerTeamTwo = new System.Windows.Forms.Label();
            this.pnlTeamTwoRemplacerTwo = new System.Windows.Forms.Panel();
            this.pnlTeamTwoRemplacerOne = new System.Windows.Forms.Panel();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnForfait = new System.Windows.Forms.Button();
            this.pnlGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.ForeColor = System.Drawing.Color.White;
            this.lblPlayerOne.Location = new System.Drawing.Point(38, 35);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(148, 37);
            this.lblPlayerOne.TabIndex = 3;
            this.lblPlayerOne.Text = "Joueur 1";
            // 
            // lblPLayerTwo
            // 
            this.lblPLayerTwo.AutoSize = true;
            this.lblPLayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLayerTwo.ForeColor = System.Drawing.Color.White;
            this.lblPLayerTwo.Location = new System.Drawing.Point(1723, 35);
            this.lblPLayerTwo.Name = "lblPLayerTwo";
            this.lblPLayerTwo.Size = new System.Drawing.Size(150, 37);
            this.lblPLayerTwo.TabIndex = 4;
            this.lblPLayerTwo.Text = "Joueur 2";
            // 
            // pgbTimer
            // 
            this.pgbTimer.Location = new System.Drawing.Point(228, 71);
            this.pgbTimer.Name = "pgbTimer";
            this.pgbTimer.Size = new System.Drawing.Size(1455, 40);
            this.pgbTimer.TabIndex = 5;
            this.pgbTimer.Value = 100;
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.pnlGame.Controls.Add(this.pnlTeamTwoFighterThree);
            this.pnlGame.Controls.Add(this.pnlTeamOneFighterThree);
            this.pnlGame.Controls.Add(this.pnlTeamTwoFighterTwo);
            this.pnlGame.Controls.Add(this.pnlTeamOneFighterTwo);
            this.pnlGame.Controls.Add(this.pnlTeamTwoFighterOne);
            this.pnlGame.Controls.Add(this.pnlTeamOneFighterOne);
            this.pnlGame.Location = new System.Drawing.Point(228, 235);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(1455, 726);
            this.pnlGame.TabIndex = 6;
            // 
            // pnlTeamOneFighterOne
            // 
            this.pnlTeamOneFighterOne.BackColor = System.Drawing.Color.White;
            this.pnlTeamOneFighterOne.Location = new System.Drawing.Point(21, 21);
            this.pnlTeamOneFighterOne.Name = "pnlTeamOneFighterOne";
            this.pnlTeamOneFighterOne.Size = new System.Drawing.Size(200, 200);
            this.pnlTeamOneFighterOne.TabIndex = 0;
            // 
            // pnlTeamOneFighterTwo
            // 
            this.pnlTeamOneFighterTwo.BackColor = System.Drawing.Color.White;
            this.pnlTeamOneFighterTwo.Location = new System.Drawing.Point(273, 261);
            this.pnlTeamOneFighterTwo.Name = "pnlTeamOneFighterTwo";
            this.pnlTeamOneFighterTwo.Size = new System.Drawing.Size(200, 200);
            this.pnlTeamOneFighterTwo.TabIndex = 1;
            // 
            // pnlTeamOneFighterThree
            // 
            this.pnlTeamOneFighterThree.BackColor = System.Drawing.Color.White;
            this.pnlTeamOneFighterThree.Location = new System.Drawing.Point(21, 511);
            this.pnlTeamOneFighterThree.Name = "pnlTeamOneFighterThree";
            this.pnlTeamOneFighterThree.Size = new System.Drawing.Size(200, 200);
            this.pnlTeamOneFighterThree.TabIndex = 1;
            // 
            // pnlTeamTwoFighterThree
            // 
            this.pnlTeamTwoFighterThree.BackColor = System.Drawing.Color.White;
            this.pnlTeamTwoFighterThree.Location = new System.Drawing.Point(1237, 511);
            this.pnlTeamTwoFighterThree.Name = "pnlTeamTwoFighterThree";
            this.pnlTeamTwoFighterThree.Size = new System.Drawing.Size(200, 200);
            this.pnlTeamTwoFighterThree.TabIndex = 4;
            // 
            // pnlTeamTwoFighterTwo
            // 
            this.pnlTeamTwoFighterTwo.BackColor = System.Drawing.Color.White;
            this.pnlTeamTwoFighterTwo.Location = new System.Drawing.Point(981, 261);
            this.pnlTeamTwoFighterTwo.Name = "pnlTeamTwoFighterTwo";
            this.pnlTeamTwoFighterTwo.Size = new System.Drawing.Size(200, 200);
            this.pnlTeamTwoFighterTwo.TabIndex = 3;
            // 
            // pnlTeamTwoFighterOne
            // 
            this.pnlTeamTwoFighterOne.BackColor = System.Drawing.Color.White;
            this.pnlTeamTwoFighterOne.Location = new System.Drawing.Point(1237, 21);
            this.pnlTeamTwoFighterOne.Name = "pnlTeamTwoFighterOne";
            this.pnlTeamTwoFighterOne.Size = new System.Drawing.Size(200, 200);
            this.pnlTeamTwoFighterOne.TabIndex = 2;
            // 
            // pnlTeamOneRemplacerTwo
            // 
            this.pnlTeamOneRemplacerTwo.BackColor = System.Drawing.Color.White;
            this.pnlTeamOneRemplacerTwo.Location = new System.Drawing.Point(12, 638);
            this.pnlTeamOneRemplacerTwo.Name = "pnlTeamOneRemplacerTwo";
            this.pnlTeamOneRemplacerTwo.Size = new System.Drawing.Size(200, 200);
            this.pnlTeamOneRemplacerTwo.TabIndex = 3;
            // 
            // pnlTeamOneRemplacerOne
            // 
            this.pnlTeamOneRemplacerOne.BackColor = System.Drawing.Color.White;
            this.pnlTeamOneRemplacerOne.Location = new System.Drawing.Point(12, 356);
            this.pnlTeamOneRemplacerOne.Name = "pnlTeamOneRemplacerOne";
            this.pnlTeamOneRemplacerOne.Size = new System.Drawing.Size(200, 200);
            this.pnlTeamOneRemplacerOne.TabIndex = 2;
            // 
            // lblRemplacerTeamOne
            // 
            this.lblRemplacerTeamOne.AutoSize = true;
            this.lblRemplacerTeamOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemplacerTeamOne.ForeColor = System.Drawing.Color.White;
            this.lblRemplacerTeamOne.Location = new System.Drawing.Point(8, 283);
            this.lblRemplacerTeamOne.Name = "lblRemplacerTeamOne";
            this.lblRemplacerTeamOne.Size = new System.Drawing.Size(214, 37);
            this.lblRemplacerTeamOne.TabIndex = 7;
            this.lblRemplacerTeamOne.Text = "Remplaçants";
            // 
            // lblRemplacerTeamTwo
            // 
            this.lblRemplacerTeamTwo.AutoSize = true;
            this.lblRemplacerTeamTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemplacerTeamTwo.ForeColor = System.Drawing.Color.White;
            this.lblRemplacerTeamTwo.Location = new System.Drawing.Point(1694, 283);
            this.lblRemplacerTeamTwo.Name = "lblRemplacerTeamTwo";
            this.lblRemplacerTeamTwo.Size = new System.Drawing.Size(214, 37);
            this.lblRemplacerTeamTwo.TabIndex = 8;
            this.lblRemplacerTeamTwo.Text = "Remplaçants";
            // 
            // pnlTeamTwoRemplacerTwo
            // 
            this.pnlTeamTwoRemplacerTwo.BackColor = System.Drawing.Color.White;
            this.pnlTeamTwoRemplacerTwo.Location = new System.Drawing.Point(1701, 638);
            this.pnlTeamTwoRemplacerTwo.Name = "pnlTeamTwoRemplacerTwo";
            this.pnlTeamTwoRemplacerTwo.Size = new System.Drawing.Size(200, 200);
            this.pnlTeamTwoRemplacerTwo.TabIndex = 5;
            // 
            // pnlTeamTwoRemplacerOne
            // 
            this.pnlTeamTwoRemplacerOne.BackColor = System.Drawing.Color.White;
            this.pnlTeamTwoRemplacerOne.Location = new System.Drawing.Point(1701, 356);
            this.pnlTeamTwoRemplacerOne.Name = "pnlTeamTwoRemplacerOne";
            this.pnlTeamTwoRemplacerOne.Size = new System.Drawing.Size(200, 200);
            this.pnlTeamTwoRemplacerOne.TabIndex = 4;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(834, 150);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(165, 37);
            this.lblTurn.TabIndex = 9;
            this.lblTurn.Text = "Tour de : ";
            // 
            // btnForfait
            // 
            this.btnForfait.Location = new System.Drawing.Point(45, 985);
            this.btnForfait.Name = "btnForfait";
            this.btnForfait.Size = new System.Drawing.Size(64, 63);
            this.btnForfait.TabIndex = 10;
            this.btnForfait.UseVisualStyleBackColor = true;
            // 
            // FtGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnForfait);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pnlTeamTwoRemplacerTwo);
            this.Controls.Add(this.lblRemplacerTeamTwo);
            this.Controls.Add(this.lblRemplacerTeamOne);
            this.Controls.Add(this.pnlTeamTwoRemplacerOne);
            this.Controls.Add(this.pnlTeamOneRemplacerTwo);
            this.Controls.Add(this.pnlTeamOneRemplacerOne);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pgbTimer);
            this.Controls.Add(this.lblPLayerTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FtGameView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FtGameView_Load);
            this.pnlGame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPLayerTwo;
        private System.Windows.Forms.ProgressBar pgbTimer;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Panel pnlTeamTwoFighterThree;
        private System.Windows.Forms.Panel pnlTeamOneFighterThree;
        private System.Windows.Forms.Panel pnlTeamTwoFighterTwo;
        private System.Windows.Forms.Panel pnlTeamOneFighterTwo;
        private System.Windows.Forms.Panel pnlTeamTwoFighterOne;
        private System.Windows.Forms.Panel pnlTeamOneFighterOne;
        private System.Windows.Forms.Panel pnlTeamOneRemplacerTwo;
        private System.Windows.Forms.Panel pnlTeamOneRemplacerOne;
        private System.Windows.Forms.Label lblRemplacerTeamOne;
        private System.Windows.Forms.Label lblRemplacerTeamTwo;
        private System.Windows.Forms.Panel pnlTeamTwoRemplacerTwo;
        private System.Windows.Forms.Panel pnlTeamTwoRemplacerOne;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnForfait;
    }
}