namespace P_Demomot.Views
{
    partial class PlayView
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
            this.lblPlay = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPlayFt = new System.Windows.Forms.Button();
            this.btnPlayTb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.White;
            this.lblPlay.Location = new System.Drawing.Point(450, 9);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(102, 37);
            this.lblPlay.TabIndex = 2;
            this.lblPlay.Text = "Jouer";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(330, 468);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(354, 77);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPlayFt
            // 
            this.btnPlayFt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.btnPlayFt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayFt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayFt.ForeColor = System.Drawing.Color.White;
            this.btnPlayFt.Location = new System.Drawing.Point(330, 295);
            this.btnPlayFt.Name = "btnPlayFt";
            this.btnPlayFt.Size = new System.Drawing.Size(354, 77);
            this.btnPlayFt.TabIndex = 12;
            this.btnPlayFt.Text = "Fight Tactics";
            this.btnPlayFt.UseVisualStyleBackColor = false;
            this.btnPlayFt.Click += new System.EventHandler(this.btnPlayFt_Click);
            // 
            // btnPlayTb
            // 
            this.btnPlayTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.btnPlayTb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayTb.ForeColor = System.Drawing.Color.White;
            this.btnPlayTb.Location = new System.Drawing.Point(330, 134);
            this.btnPlayTb.Name = "btnPlayTb";
            this.btnPlayTb.Size = new System.Drawing.Size(354, 77);
            this.btnPlayTb.TabIndex = 11;
            this.btnPlayTb.Text = "TankBattle";
            this.btnPlayTb.UseVisualStyleBackColor = false;
            this.btnPlayTb.Click += new System.EventHandler(this.btnPlayTb_Click);
            // 
            // PlayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPlayFt);
            this.Controls.Add(this.btnPlayTb);
            this.Controls.Add(this.lblPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PlayView";
            this.Text = "Jouer";
            this.Load += new System.EventHandler(this.PlayView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPlayFt;
        private System.Windows.Forms.Button btnPlayTb;
    }
}