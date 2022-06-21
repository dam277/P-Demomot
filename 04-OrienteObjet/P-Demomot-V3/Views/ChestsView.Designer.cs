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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChestsView));
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblChests = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlChest3 = new System.Windows.Forms.Panel();
            this.pnlChest1 = new System.Windows.Forms.Panel();
            this.pctNext = new System.Windows.Forms.PictureBox();
            this.pctBack = new System.Windows.Forms.PictureBox();
            this.pnlChest2 = new System.Windows.Forms.Panel();
            this.lblNbrChests = new System.Windows.Forms.Label();
            this.pnlBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBack)).BeginInit();
            this.pnlChest2.SuspendLayout();
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
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            // pnlBorder
            // 
            this.pnlBorder.Controls.Add(this.pnlChest3);
            this.pnlBorder.Controls.Add(this.pnlChest1);
            this.pnlBorder.Controls.Add(this.pctNext);
            this.pnlBorder.Controls.Add(this.pctBack);
            this.pnlBorder.Controls.Add(this.pnlChest2);
            this.pnlBorder.Location = new System.Drawing.Point(-4, 90);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(993, 451);
            this.pnlBorder.TabIndex = 17;
            // 
            // pnlChest3
            // 
            this.pnlChest3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChest3.BackgroundImage")));
            this.pnlChest3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChest3.Location = new System.Drawing.Point(864, 98);
            this.pnlChest3.Name = "pnlChest3";
            this.pnlChest3.Size = new System.Drawing.Size(255, 255);
            this.pnlChest3.TabIndex = 1;
            // 
            // pnlChest1
            // 
            this.pnlChest1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChest1.BackgroundImage")));
            this.pnlChest1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChest1.Location = new System.Drawing.Point(-127, 98);
            this.pnlChest1.Name = "pnlChest1";
            this.pnlChest1.Size = new System.Drawing.Size(255, 255);
            this.pnlChest1.TabIndex = 1;
            // 
            // pctNext
            // 
            this.pctNext.ErrorImage = null;
            this.pctNext.Image = ((System.Drawing.Image)(resources.GetObject("pctNext.Image")));
            this.pctNext.Location = new System.Drawing.Point(722, 183);
            this.pctNext.Name = "pctNext";
            this.pctNext.Size = new System.Drawing.Size(73, 70);
            this.pctNext.TabIndex = 3;
            this.pctNext.TabStop = false;
            this.pctNext.Click += new System.EventHandler(this.pctNext_Click);
            // 
            // pctBack
            // 
            this.pctBack.ErrorImage = null;
            this.pctBack.Image = ((System.Drawing.Image)(resources.GetObject("pctBack.Image")));
            this.pctBack.Location = new System.Drawing.Point(213, 183);
            this.pctBack.Name = "pctBack";
            this.pctBack.Size = new System.Drawing.Size(73, 70);
            this.pctBack.TabIndex = 2;
            this.pctBack.TabStop = false;
            this.pctBack.Click += new System.EventHandler(this.pctBack_Click);
            // 
            // pnlChest2
            // 
            this.pnlChest2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChest2.BackgroundImage")));
            this.pnlChest2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChest2.Controls.Add(this.lblNbrChests);
            this.pnlChest2.Location = new System.Drawing.Point(391, 98);
            this.pnlChest2.Name = "pnlChest2";
            this.pnlChest2.Size = new System.Drawing.Size(255, 255);
            this.pnlChest2.TabIndex = 0;
            this.pnlChest2.Click += new System.EventHandler(this.pnlChest2_Click);
            // 
            // lblNbrChests
            // 
            this.lblNbrChests.AutoSize = true;
            this.lblNbrChests.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNbrChests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNbrChests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbrChests.ForeColor = System.Drawing.Color.White;
            this.lblNbrChests.Location = new System.Drawing.Point(214, 0);
            this.lblNbrChests.Name = "lblNbrChests";
            this.lblNbrChests.Size = new System.Drawing.Size(2, 22);
            this.lblNbrChests.TabIndex = 0;
            // 
            // ChestsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlBorder);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblChests);
            this.Controls.Add(this.btnReturn);
            this.Name = "ChestsView";
            this.Text = "Coffres";
            this.Load += new System.EventHandler(this.ChestsView_Load);
            this.pnlBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBack)).EndInit();
            this.pnlChest2.ResumeLayout(false);
            this.pnlChest2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblChests;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.PictureBox pctNext;
        private System.Windows.Forms.PictureBox pctBack;
        private System.Windows.Forms.Panel pnlChest2;
        private System.Windows.Forms.Panel pnlChest3;
        private System.Windows.Forms.Panel pnlChest1;
        private System.Windows.Forms.Label lblNbrChests;
    }
}