namespace P_Demomot_Winforms_Damloup
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.pnlBorderPage = new System.Windows.Forms.Panel();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnChest = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNickname2 = new System.Windows.Forms.Label();
            this.txbNicknameTwo = new System.Windows.Forms.TextBox();
            this.lblNickname1 = new System.Windows.Forms.Label();
            this.txbNicknameOne = new System.Windows.Forms.TextBox();
            this.lblGoldTitle = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlBorderPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
            this.pnlBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorder.Location = new System.Drawing.Point(10, 74);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(660, 660);
            this.pnlBorder.TabIndex = 0;
            // 
            // pnlBorderPage
            // 
            this.pnlBorderPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorderPage.Controls.Add(this.btnNextPage);
            this.pnlBorderPage.Controls.Add(this.btnBackPage);
            this.pnlBorderPage.Location = new System.Drawing.Point(680, 567);
            this.pnlBorderPage.Name = "pnlBorderPage";
            this.pnlBorderPage.Size = new System.Drawing.Size(200, 100);
            this.pnlBorderPage.TabIndex = 5;
            this.pnlBorderPage.Visible = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.Location = new System.Drawing.Point(111, 14);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(80, 80);
            this.btnNextPage.TabIndex = 1;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // btnBackPage
            // 
            this.btnBackPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackPage.Location = new System.Drawing.Point(7, 14);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(80, 80);
            this.btnBackPage.TabIndex = 0;
            this.btnBackPage.Text = "Back";
            this.btnBackPage.UseVisualStyleBackColor = true;
            this.btnBackPage.Click += new System.EventHandler(this.BtnBackPage_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(746, 557);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(74, 22);
            this.lblPage.TabIndex = 6;
            this.lblPage.Text = "Page : *";
            this.lblPage.Visible = false;
            // 
            // btnChest
            // 
            this.btnChest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChest.Image = global::P_Demomot_Winforms_Damloup.Properties.Resources.chestButton;
            this.btnChest.Location = new System.Drawing.Point(704, 335);
            this.btnChest.Name = "btnChest";
            this.btnChest.Size = new System.Drawing.Size(260, 80);
            this.btnChest.TabIndex = 4;
            this.btnChest.UseVisualStyleBackColor = true;
            this.btnChest.Click += new System.EventHandler(this.BtnChest_Click);
            // 
            // btnShop
            // 
            this.btnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShop.Image = global::P_Demomot_Winforms_Damloup.Properties.Resources.shopButton;
            this.btnShop.Location = new System.Drawing.Point(704, 234);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(260, 80);
            this.btnShop.TabIndex = 3;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.BtnShop_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Image = global::P_Demomot_Winforms_Damloup.Properties.Resources.inventoryButton;
            this.btnInventory.Location = new System.Drawing.Point(704, 131);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(260, 80);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Image = global::P_Demomot_Winforms_Damloup.Properties.Resources.playButton;
            this.btnPlay.Location = new System.Drawing.Point(704, 31);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(260, 80);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNickname2);
            this.panel1.Controls.Add(this.txbNicknameTwo);
            this.panel1.Controls.Add(this.lblNickname1);
            this.panel1.Controls.Add(this.txbNicknameOne);
            this.panel1.Controls.Add(this.lblGoldTitle);
            this.panel1.Controls.Add(this.lblGold);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 57);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(249, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pseudonymes à confirmer \r\ndans le mode JOUER";
            // 
            // lblNickname2
            // 
            this.lblNickname2.AutoSize = true;
            this.lblNickname2.BackColor = System.Drawing.Color.Red;
            this.lblNickname2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNickname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname2.ForeColor = System.Drawing.Color.White;
            this.lblNickname2.Location = new System.Drawing.Point(566, 14);
            this.lblNickname2.Name = "lblNickname2";
            this.lblNickname2.Size = new System.Drawing.Size(68, 20);
            this.lblNickname2.TabIndex = 0;
            this.lblNickname2.Text = "Joueur 2";
            // 
            // txbNicknameTwo
            // 
            this.txbNicknameTwo.Location = new System.Drawing.Point(550, 30);
            this.txbNicknameTwo.Name = "txbNicknameTwo";
            this.txbNicknameTwo.Size = new System.Drawing.Size(100, 20);
            this.txbNicknameTwo.TabIndex = 4;
            // 
            // lblNickname1
            // 
            this.lblNickname1.AutoSize = true;
            this.lblNickname1.BackColor = System.Drawing.Color.Blue;
            this.lblNickname1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNickname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickname1.ForeColor = System.Drawing.Color.White;
            this.lblNickname1.Location = new System.Drawing.Point(439, 13);
            this.lblNickname1.Name = "lblNickname1";
            this.lblNickname1.Size = new System.Drawing.Size(68, 20);
            this.lblNickname1.TabIndex = 3;
            this.lblNickname1.Text = "Joueur 1";
            // 
            // txbNicknameOne
            // 
            this.txbNicknameOne.Location = new System.Drawing.Point(422, 30);
            this.txbNicknameOne.Name = "txbNicknameOne";
            this.txbNicknameOne.Size = new System.Drawing.Size(100, 20);
            this.txbNicknameOne.TabIndex = 2;
            // 
            // lblGoldTitle
            // 
            this.lblGoldTitle.AutoSize = true;
            this.lblGoldTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGoldTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoldTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGoldTitle.Location = new System.Drawing.Point(14, 18);
            this.lblGoldTitle.Name = "lblGoldTitle";
            this.lblGoldTitle.Size = new System.Drawing.Size(40, 22);
            this.lblGoldTitle.TabIndex = 0;
            this.lblGoldTitle.Text = "Or :";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGold.Location = new System.Drawing.Point(49, 13);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(31, 33);
            this.lblGold.TabIndex = 1;
            this.lblGold.Text = "0";
            // 
            // btnHelp
            // 
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.Location = new System.Drawing.Point(913, -1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(73, 25);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Aide";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(58)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(985, 744);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.pnlBorderPage);
            this.Controls.Add(this.btnChest);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBorderPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnChest;
        private System.Windows.Forms.Panel pnlBorderPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnBackPage;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGoldTitle;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblNickname2;
        private System.Windows.Forms.TextBox txbNicknameTwo;
        private System.Windows.Forms.Label lblNickname1;
        private System.Windows.Forms.TextBox txbNicknameOne;
        private System.Windows.Forms.Label label1;
    }
}

