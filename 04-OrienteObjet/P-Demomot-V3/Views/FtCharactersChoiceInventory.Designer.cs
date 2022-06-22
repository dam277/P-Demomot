namespace P_Demomot.Views
{
    partial class FtCharactersChoiceInventory
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
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.lblCharacterChoice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorder.Location = new System.Drawing.Point(22, 47);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(943, 693);
            this.pnlBorder.TabIndex = 0;
            // 
            // lblCharacterChoice
            // 
            this.lblCharacterChoice.AutoSize = true;
            this.lblCharacterChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterChoice.ForeColor = System.Drawing.Color.White;
            this.lblCharacterChoice.Location = new System.Drawing.Point(290, 7);
            this.lblCharacterChoice.Name = "lblCharacterChoice";
            this.lblCharacterChoice.Size = new System.Drawing.Size(373, 37);
            this.lblCharacterChoice.TabIndex = 19;
            this.lblCharacterChoice.Text = "Choix des personnages";
            // 
            // FtCharactersChoiceInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(976, 749);
            this.Controls.Add(this.lblCharacterChoice);
            this.Controls.Add(this.pnlBorder);
            this.Name = "FtCharactersChoiceInventory";
            this.Text = "Choix des personnages";
            this.Load += new System.EventHandler(this.FtCharactersChoiceInventory_Load);
            this.VisibleChanged += new System.EventHandler(this.FtCharactersChoiceInventory_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblCharacterChoice;
    }
}