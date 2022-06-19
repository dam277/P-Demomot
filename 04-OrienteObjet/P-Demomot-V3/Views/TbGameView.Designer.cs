namespace P_Demomot.Views
{
    partial class TbGameView
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
            this.lblRemplacerTeamTwo = new System.Windows.Forms.Label();
            this.lblRemplacerTeamOne = new System.Windows.Forms.Label();
            this.pgbTimer = new System.Windows.Forms.ProgressBar();
            this.lblPLayerTwo = new System.Windows.Forms.Label();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.btnForfait = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRemplacerTeamTwo
            // 
            this.lblRemplacerTeamTwo.AutoSize = true;
            this.lblRemplacerTeamTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemplacerTeamTwo.ForeColor = System.Drawing.Color.White;
            this.lblRemplacerTeamTwo.Location = new System.Drawing.Point(1696, 277);
            this.lblRemplacerTeamTwo.Name = "lblRemplacerTeamTwo";
            this.lblRemplacerTeamTwo.Size = new System.Drawing.Size(214, 37);
            this.lblRemplacerTeamTwo.TabIndex = 13;
            this.lblRemplacerTeamTwo.Text = "Remplaçants";
            // 
            // lblRemplacerTeamOne
            // 
            this.lblRemplacerTeamOne.AutoSize = true;
            this.lblRemplacerTeamOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemplacerTeamOne.ForeColor = System.Drawing.Color.White;
            this.lblRemplacerTeamOne.Location = new System.Drawing.Point(10, 277);
            this.lblRemplacerTeamOne.Name = "lblRemplacerTeamOne";
            this.lblRemplacerTeamOne.Size = new System.Drawing.Size(214, 37);
            this.lblRemplacerTeamOne.TabIndex = 12;
            this.lblRemplacerTeamOne.Text = "Remplaçants";
            // 
            // pgbTimer
            // 
            this.pgbTimer.Location = new System.Drawing.Point(230, 65);
            this.pgbTimer.Name = "pgbTimer";
            this.pgbTimer.Size = new System.Drawing.Size(1455, 40);
            this.pgbTimer.TabIndex = 11;
            this.pgbTimer.Value = 100;
            // 
            // lblPLayerTwo
            // 
            this.lblPLayerTwo.AutoSize = true;
            this.lblPLayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLayerTwo.ForeColor = System.Drawing.Color.White;
            this.lblPLayerTwo.Location = new System.Drawing.Point(1725, 29);
            this.lblPLayerTwo.Name = "lblPLayerTwo";
            this.lblPLayerTwo.Size = new System.Drawing.Size(150, 37);
            this.lblPLayerTwo.TabIndex = 10;
            this.lblPLayerTwo.Text = "Joueur 2";
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.AutoSize = true;
            this.lblPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.ForeColor = System.Drawing.Color.White;
            this.lblPlayerOne.Location = new System.Drawing.Point(40, 29);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(148, 37);
            this.lblPlayerOne.TabIndex = 9;
            this.lblPlayerOne.Text = "Joueur 1";
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.pnlGame.Location = new System.Drawing.Point(230, 133);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(1452, 935);
            this.pnlGame.TabIndex = 14;
            // 
            // btnForfait
            // 
            this.btnForfait.Image = global::P_Demomot.Properties.Resources.whiteFlag;
            this.btnForfait.Location = new System.Drawing.Point(30, 993);
            this.btnForfait.Name = "btnForfait";
            this.btnForfait.Size = new System.Drawing.Size(64, 63);
            this.btnForfait.TabIndex = 15;
            this.btnForfait.UseVisualStyleBackColor = true;
            // 
            // TbGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnForfait);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.lblRemplacerTeamTwo);
            this.Controls.Add(this.lblRemplacerTeamOne);
            this.Controls.Add(this.pgbTimer);
            this.Controls.Add(this.lblPLayerTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TbGameView";
            this.Text = "TbGameView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TbGameView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemplacerTeamTwo;
        private System.Windows.Forms.Label lblRemplacerTeamOne;
        private System.Windows.Forms.ProgressBar pgbTimer;
        private System.Windows.Forms.Label lblPLayerTwo;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Button btnForfait;
    }
}