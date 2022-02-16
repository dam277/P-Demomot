namespace P_Demomot.Views
{
    partial class LoginView
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pctGameImage = new System.Windows.Forms.PictureBox();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.cmbLang = new System.Windows.Forms.ComboBox();
            this.lblRegister = new System.Windows.Forms.Label();
            this.txtNickNameRegister = new System.Windows.Forms.TextBox();
            this.lblNickNameRegister = new System.Windows.Forms.Label();
            this.txtPasswordRegister = new System.Windows.Forms.TextBox();
            this.lblPasswordRegister = new System.Windows.Forms.Label();
            this.txtEmailRegister = new System.Windows.Forms.TextBox();
            this.lblEmailRegister = new System.Windows.Forms.Label();
            this.txtPasswordRepeatRegister = new System.Windows.Forms.TextBox();
            this.lblPasswordRepeatRegister = new System.Windows.Forms.Label();
            this.btnValidateRegister = new System.Windows.Forms.Button();
            this.btnValidateConnection = new System.Windows.Forms.Button();
            this.lblPasswordConnection = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.txtPasswordConnection = new System.Windows.Forms.TextBox();
            this.lblEmailConnection = new System.Windows.Forms.Label();
            this.txtEmailConnection = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctGameImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(122)))));
            this.pnlHeader.Controls.Add(this.pctGameImage);
            this.pnlHeader.Controls.Add(this.lblLoginTitle);
            this.pnlHeader.Controls.Add(this.cmbLang);
            this.pnlHeader.Location = new System.Drawing.Point(-2, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(484, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // pctGameImage
            // 
            this.pctGameImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctGameImage.Location = new System.Drawing.Point(3, 0);
            this.pctGameImage.Name = "pctGameImage";
            this.pctGameImage.Size = new System.Drawing.Size(91, 85);
            this.pctGameImage.TabIndex = 1;
            this.pctGameImage.TabStop = false;
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.White;
            this.lblLoginTitle.Location = new System.Drawing.Point(100, 25);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(290, 31);
            this.lblLoginTitle.TabIndex = 1;
            this.lblLoginTitle.Text = "Connection - Enregistrement";
            // 
            // cmbLang
            // 
            this.cmbLang.FormattingEnabled = true;
            this.cmbLang.Items.AddRange(new object[] {
            "FR",
            "EN",
            "IT",
            "DE"});
            this.cmbLang.Location = new System.Drawing.Point(407, 12);
            this.cmbLang.Name = "cmbLang";
            this.cmbLang.Size = new System.Drawing.Size(61, 21);
            this.cmbLang.TabIndex = 0;
            this.cmbLang.Text = "FR";
            this.cmbLang.SelectedIndexChanged += new System.EventHandler(this.cmbLang_SelectedIndexChanged);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(154, 308);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(161, 31);
            this.lblRegister.TabIndex = 9;
            this.lblRegister.Text = "Enregistrement";
            // 
            // txtNickNameRegister
            // 
            this.txtNickNameRegister.Location = new System.Drawing.Point(33, 385);
            this.txtNickNameRegister.Name = "txtNickNameRegister";
            this.txtNickNameRegister.Size = new System.Drawing.Size(172, 20);
            this.txtNickNameRegister.TabIndex = 10;
            // 
            // lblNickNameRegister
            // 
            this.lblNickNameRegister.AutoSize = true;
            this.lblNickNameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickNameRegister.ForeColor = System.Drawing.Color.White;
            this.lblNickNameRegister.Location = new System.Drawing.Point(29, 362);
            this.lblNickNameRegister.Name = "lblNickNameRegister";
            this.lblNickNameRegister.Size = new System.Drawing.Size(63, 20);
            this.lblNickNameRegister.TabIndex = 11;
            this.lblNickNameRegister.Text = "Pseudo";
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.Location = new System.Drawing.Point(33, 441);
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.Size = new System.Drawing.Size(172, 20);
            this.txtPasswordRegister.TabIndex = 12;
            // 
            // lblPasswordRegister
            // 
            this.lblPasswordRegister.AutoSize = true;
            this.lblPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRegister.ForeColor = System.Drawing.Color.White;
            this.lblPasswordRegister.Location = new System.Drawing.Point(29, 418);
            this.lblPasswordRegister.Name = "lblPasswordRegister";
            this.lblPasswordRegister.Size = new System.Drawing.Size(105, 20);
            this.lblPasswordRegister.TabIndex = 13;
            this.lblPasswordRegister.Text = "Mot de passe";
            // 
            // txtEmailRegister
            // 
            this.txtEmailRegister.Location = new System.Drawing.Point(271, 385);
            this.txtEmailRegister.Name = "txtEmailRegister";
            this.txtEmailRegister.Size = new System.Drawing.Size(172, 20);
            this.txtEmailRegister.TabIndex = 14;
            // 
            // lblEmailRegister
            // 
            this.lblEmailRegister.AutoSize = true;
            this.lblEmailRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailRegister.ForeColor = System.Drawing.Color.White;
            this.lblEmailRegister.Location = new System.Drawing.Point(267, 362);
            this.lblEmailRegister.Name = "lblEmailRegister";
            this.lblEmailRegister.Size = new System.Drawing.Size(48, 20);
            this.lblEmailRegister.TabIndex = 15;
            this.lblEmailRegister.Text = "Email";
            // 
            // txtPasswordRepeatRegister
            // 
            this.txtPasswordRepeatRegister.Location = new System.Drawing.Point(271, 441);
            this.txtPasswordRepeatRegister.Name = "txtPasswordRepeatRegister";
            this.txtPasswordRepeatRegister.Size = new System.Drawing.Size(172, 20);
            this.txtPasswordRepeatRegister.TabIndex = 16;
            // 
            // lblPasswordRepeatRegister
            // 
            this.lblPasswordRepeatRegister.AutoSize = true;
            this.lblPasswordRepeatRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRepeatRegister.ForeColor = System.Drawing.Color.White;
            this.lblPasswordRepeatRegister.Location = new System.Drawing.Point(267, 418);
            this.lblPasswordRepeatRegister.Name = "lblPasswordRepeatRegister";
            this.lblPasswordRepeatRegister.Size = new System.Drawing.Size(183, 20);
            this.lblPasswordRepeatRegister.TabIndex = 17;
            this.lblPasswordRepeatRegister.Text = "Répéter le mot de passe";
            // 
            // btnValidateRegister
            // 
            this.btnValidateRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(220)))));
            this.btnValidateRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateRegister.Location = new System.Drawing.Point(90, 476);
            this.btnValidateRegister.Name = "btnValidateRegister";
            this.btnValidateRegister.Size = new System.Drawing.Size(317, 49);
            this.btnValidateRegister.TabIndex = 24;
            this.btnValidateRegister.Text = "Valider";
            this.btnValidateRegister.UseVisualStyleBackColor = false;
            this.btnValidateRegister.Click += new System.EventHandler(this.btnValidateRegister_Click);
            // 
            // btnValidateConnection
            // 
            this.btnValidateConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(220)))));
            this.btnValidateConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateConnection.Location = new System.Drawing.Point(90, 244);
            this.btnValidateConnection.Name = "btnValidateConnection";
            this.btnValidateConnection.Size = new System.Drawing.Size(317, 49);
            this.btnValidateConnection.TabIndex = 30;
            this.btnValidateConnection.Text = "Valider";
            this.btnValidateConnection.UseVisualStyleBackColor = false;
            // 
            // lblPasswordConnection
            // 
            this.lblPasswordConnection.AutoSize = true;
            this.lblPasswordConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordConnection.ForeColor = System.Drawing.Color.White;
            this.lblPasswordConnection.Location = new System.Drawing.Point(57, 191);
            this.lblPasswordConnection.Name = "lblPasswordConnection";
            this.lblPasswordConnection.Size = new System.Drawing.Size(105, 20);
            this.lblPasswordConnection.TabIndex = 29;
            this.lblPasswordConnection.Text = "Mot de passe";
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.White;
            this.lblConnection.Location = new System.Drawing.Point(171, 95);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(124, 31);
            this.lblConnection.TabIndex = 25;
            this.lblConnection.Text = "Connection";
            // 
            // txtPasswordConnection
            // 
            this.txtPasswordConnection.Location = new System.Drawing.Point(61, 214);
            this.txtPasswordConnection.Name = "txtPasswordConnection";
            this.txtPasswordConnection.Size = new System.Drawing.Size(370, 20);
            this.txtPasswordConnection.TabIndex = 28;
            // 
            // lblEmailConnection
            // 
            this.lblEmailConnection.AutoSize = true;
            this.lblEmailConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailConnection.ForeColor = System.Drawing.Color.White;
            this.lblEmailConnection.Location = new System.Drawing.Point(57, 135);
            this.lblEmailConnection.Name = "lblEmailConnection";
            this.lblEmailConnection.Size = new System.Drawing.Size(48, 20);
            this.lblEmailConnection.TabIndex = 27;
            this.lblEmailConnection.Text = "Email";
            // 
            // txtEmailConnection
            // 
            this.txtEmailConnection.Location = new System.Drawing.Point(61, 158);
            this.txtEmailConnection.Name = "txtEmailConnection";
            this.txtEmailConnection.Size = new System.Drawing.Size(370, 20);
            this.txtEmailConnection.TabIndex = 26;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(478, 537);
            this.Controls.Add(this.btnValidateConnection);
            this.Controls.Add(this.lblPasswordConnection);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.txtPasswordConnection);
            this.Controls.Add(this.lblEmailConnection);
            this.Controls.Add(this.txtEmailConnection);
            this.Controls.Add(this.btnValidateRegister);
            this.Controls.Add(this.lblPasswordRepeatRegister);
            this.Controls.Add(this.txtPasswordRepeatRegister);
            this.Controls.Add(this.lblEmailRegister);
            this.Controls.Add(this.txtEmailRegister);
            this.Controls.Add(this.lblPasswordRegister);
            this.Controls.Add(this.txtPasswordRegister);
            this.Controls.Add(this.lblNickNameRegister);
            this.Controls.Add(this.txtNickNameRegister);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.pnlHeader);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Register | P-Demomot - Damien Loup";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctGameImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.ComboBox cmbLang;
        private System.Windows.Forms.PictureBox pctGameImage;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.TextBox txtNickNameRegister;
        private System.Windows.Forms.Label lblNickNameRegister;
        private System.Windows.Forms.TextBox txtPasswordRegister;
        private System.Windows.Forms.Label lblPasswordRegister;
        private System.Windows.Forms.TextBox txtEmailRegister;
        private System.Windows.Forms.Label lblEmailRegister;
        private System.Windows.Forms.TextBox txtPasswordRepeatRegister;
        private System.Windows.Forms.Label lblPasswordRepeatRegister;
        private System.Windows.Forms.Button btnValidateRegister;
        private System.Windows.Forms.Button btnValidateConnection;
        private System.Windows.Forms.Label lblPasswordConnection;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.TextBox txtPasswordConnection;
        private System.Windows.Forms.Label lblEmailConnection;
        private System.Windows.Forms.TextBox txtEmailConnection;
    }
}