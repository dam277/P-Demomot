namespace P_Demomot.Views
{
    partial class ChestsView
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblChests = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(328, 572);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(354, 77);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // lblChests
            // 
            this.lblChests.AutoSize = true;
            this.lblChests.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChests.ForeColor = System.Drawing.Color.White;
            this.lblChests.Location = new System.Drawing.Point(445, 9);
            this.lblChests.Name = "lblChests";
            this.lblChests.Size = new System.Drawing.Size(127, 37);
            this.lblChests.TabIndex = 15;
            this.lblChests.Text = "Coffres";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGold.ForeColor = System.Drawing.Color.White;
            this.lblGold.Location = new System.Drawing.Point(12, 9);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(55, 26);
            this.lblGold.TabIndex = 16;
            this.lblGold.Text = "OR : ";
            // 
            // ChestsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblChests);
            this.Controls.Add(this.btnReturn);
            this.Name = "ChestsView";
            this.Text = "Coffres";
            this.Load += new System.EventHandler(this.ChestsView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblChests;
        private System.Windows.Forms.Label lblGold;
    }
}