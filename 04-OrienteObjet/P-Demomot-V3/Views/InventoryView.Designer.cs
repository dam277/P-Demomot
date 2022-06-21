namespace P_Demomot.Views
{
    partial class InventoryView
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
            this.lblGold = new System.Windows.Forms.Label();
            this.cmbRarity = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.pnlGameChoice = new System.Windows.Forms.Panel();
            this.btnTb = new System.Windows.Forms.Button();
            this.btnFt = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlGameChoice.SuspendLayout();
            this.SuspendLayout();
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
            this.lblGold.TabIndex = 13;
            this.lblGold.Text = "OR : ";
            // 
            // cmbRarity
            // 
            this.cmbRarity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.cmbRarity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRarity.FormattingEnabled = true;
            this.cmbRarity.Location = new System.Drawing.Point(12, 68);
            this.cmbRarity.Name = "cmbRarity";
            this.cmbRarity.Size = new System.Drawing.Size(177, 21);
            this.cmbRarity.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(204, 68);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(571, 20);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.Text = "Rechercher ...";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = System.Drawing.Color.White;
            this.lblInventory.Location = new System.Drawing.Point(421, 9);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(165, 37);
            this.lblInventory.TabIndex = 16;
            this.lblInventory.Text = "Inventaire";
            // 
            // pnlGameChoice
            // 
            this.pnlGameChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.pnlGameChoice.Controls.Add(this.btnTb);
            this.pnlGameChoice.Controls.Add(this.btnFt);
            this.pnlGameChoice.Location = new System.Drawing.Point(843, 56);
            this.pnlGameChoice.Name = "pnlGameChoice";
            this.pnlGameChoice.Size = new System.Drawing.Size(115, 45);
            this.pnlGameChoice.TabIndex = 17;
            // 
            // btnTb
            // 
            this.btnTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(68)))), ((int)(((byte)(222)))));
            this.btnTb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTb.ForeColor = System.Drawing.Color.White;
            this.btnTb.Location = new System.Drawing.Point(66, 5);
            this.btnTb.Name = "btnTb";
            this.btnTb.Size = new System.Drawing.Size(35, 35);
            this.btnTb.TabIndex = 20;
            this.btnTb.Text = "TB";
            this.btnTb.UseVisualStyleBackColor = false;
            // 
            // btnFt
            // 
            this.btnFt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(35)))), ((int)(((byte)(128)))));
            this.btnFt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFt.ForeColor = System.Drawing.Color.White;
            this.btnFt.Location = new System.Drawing.Point(14, 5);
            this.btnFt.Name = "btnFt";
            this.btnFt.Size = new System.Drawing.Size(35, 35);
            this.btnFt.TabIndex = 19;
            this.btnFt.Text = "FT";
            this.btnFt.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = global::P_Demomot.Properties.Resources.magnifyingGlass;
            this.btnSearch.Location = new System.Drawing.Point(773, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // pnlInventory
            // 
            this.pnlInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.pnlInventory.Location = new System.Drawing.Point(21, 116);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(943, 738);
            this.pnlInventory.TabIndex = 19;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(843, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(115, 36);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // InventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(984, 866);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pnlInventory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlGameChoice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbRarity);
            this.Controls.Add(this.lblGold);
            this.Name = "InventoryView";
            this.Text = "Inventaire";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryView_FormClosed);
            this.Load += new System.EventHandler(this.InventoryView_Load);
            this.pnlGameChoice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.ComboBox cmbRarity;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Panel pnlGameChoice;
        private System.Windows.Forms.Button btnTb;
        private System.Windows.Forms.Button btnFt;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.Button btnReturn;
    }
}