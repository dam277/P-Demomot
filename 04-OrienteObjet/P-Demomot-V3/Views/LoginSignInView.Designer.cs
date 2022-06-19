namespace P_Demomot.Views
{
    partial class LoginSignInView
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
            this.txtInscriptionNickname = new System.Windows.Forms.TextBox();
            this.lblInscriptionNickname = new System.Windows.Forms.Label();
            this.lblInscriptionPassword = new System.Windows.Forms.Label();
            this.txtInscriptionPassword = new System.Windows.Forms.TextBox();
            this.lblInscriptionConfirmPassword = new System.Windows.Forms.Label();
            this.txtInscriptionConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnInscriptionValidate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConnectionPassword = new System.Windows.Forms.Label();
            this.txtConnectionPassword = new System.Windows.Forms.TextBox();
            this.lblConnectionNickname = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.txtConnectionNickname = new System.Windows.Forms.TextBox();
            this.btnConnectionValidate = new System.Windows.Forms.Button();
            this.lblInscription = new System.Windows.Forms.Label();
            this.lblConnectionErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInscriptionNickname
            // 
            this.txtInscriptionNickname.Location = new System.Drawing.Point(78, 119);
            this.txtInscriptionNickname.Name = "txtInscriptionNickname";
            this.txtInscriptionNickname.Size = new System.Drawing.Size(235, 20);
            this.txtInscriptionNickname.TabIndex = 0;
            // 
            // lblInscriptionNickname
            // 
            this.lblInscriptionNickname.AutoSize = true;
            this.lblInscriptionNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscriptionNickname.ForeColor = System.Drawing.Color.White;
            this.lblInscriptionNickname.Location = new System.Drawing.Point(151, 91);
            this.lblInscriptionNickname.Name = "lblInscriptionNickname";
            this.lblInscriptionNickname.Size = new System.Drawing.Size(85, 25);
            this.lblInscriptionNickname.TabIndex = 2;
            this.lblInscriptionNickname.Text = "Pseudo";
            // 
            // lblInscriptionPassword
            // 
            this.lblInscriptionPassword.AutoSize = true;
            this.lblInscriptionPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscriptionPassword.ForeColor = System.Drawing.Color.White;
            this.lblInscriptionPassword.Location = new System.Drawing.Point(426, 91);
            this.lblInscriptionPassword.Name = "lblInscriptionPassword";
            this.lblInscriptionPassword.Size = new System.Drawing.Size(142, 25);
            this.lblInscriptionPassword.TabIndex = 4;
            this.lblInscriptionPassword.Text = "Mot de passe";
            // 
            // txtInscriptionPassword
            // 
            this.txtInscriptionPassword.Location = new System.Drawing.Point(382, 119);
            this.txtInscriptionPassword.Name = "txtInscriptionPassword";
            this.txtInscriptionPassword.Size = new System.Drawing.Size(235, 20);
            this.txtInscriptionPassword.TabIndex = 3;
            // 
            // lblInscriptionConfirmPassword
            // 
            this.lblInscriptionConfirmPassword.AutoSize = true;
            this.lblInscriptionConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscriptionConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblInscriptionConfirmPassword.Location = new System.Drawing.Point(681, 91);
            this.lblInscriptionConfirmPassword.Name = "lblInscriptionConfirmPassword";
            this.lblInscriptionConfirmPassword.Size = new System.Drawing.Size(246, 25);
            this.lblInscriptionConfirmPassword.TabIndex = 6;
            this.lblInscriptionConfirmPassword.Text = "Répéter le mot de passe";
            // 
            // txtInscriptionConfirmPassword
            // 
            this.txtInscriptionConfirmPassword.Location = new System.Drawing.Point(686, 119);
            this.txtInscriptionConfirmPassword.Name = "txtInscriptionConfirmPassword";
            this.txtInscriptionConfirmPassword.Size = new System.Drawing.Size(235, 20);
            this.txtInscriptionConfirmPassword.TabIndex = 5;
            // 
            // btnInscriptionValidate
            // 
            this.btnInscriptionValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.btnInscriptionValidate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscriptionValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscriptionValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscriptionValidate.ForeColor = System.Drawing.Color.White;
            this.btnInscriptionValidate.Location = new System.Drawing.Point(382, 222);
            this.btnInscriptionValidate.Name = "btnInscriptionValidate";
            this.btnInscriptionValidate.Size = new System.Drawing.Size(235, 56);
            this.btnInscriptionValidate.TabIndex = 7;
            this.btnInscriptionValidate.Text = "Valider";
            this.btnInscriptionValidate.UseVisualStyleBackColor = false;
            this.btnInscriptionValidate.Click += new System.EventHandler(this.btnInscriptionValidate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 334);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 10);
            this.panel1.TabIndex = 8;
            // 
            // lblConnectionPassword
            // 
            this.lblConnectionPassword.AutoSize = true;
            this.lblConnectionPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionPassword.ForeColor = System.Drawing.Color.White;
            this.lblConnectionPassword.Location = new System.Drawing.Point(678, 424);
            this.lblConnectionPassword.Name = "lblConnectionPassword";
            this.lblConnectionPassword.Size = new System.Drawing.Size(142, 25);
            this.lblConnectionPassword.TabIndex = 13;
            this.lblConnectionPassword.Text = "Mot de passe";
            // 
            // txtConnectionPassword
            // 
            this.txtConnectionPassword.Location = new System.Drawing.Point(634, 452);
            this.txtConnectionPassword.Name = "txtConnectionPassword";
            this.txtConnectionPassword.Size = new System.Drawing.Size(235, 20);
            this.txtConnectionPassword.TabIndex = 12;
            // 
            // lblConnectionNickname
            // 
            this.lblConnectionNickname.AutoSize = true;
            this.lblConnectionNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionNickname.ForeColor = System.Drawing.Color.White;
            this.lblConnectionNickname.Location = new System.Drawing.Point(192, 424);
            this.lblConnectionNickname.Name = "lblConnectionNickname";
            this.lblConnectionNickname.Size = new System.Drawing.Size(85, 25);
            this.lblConnectionNickname.TabIndex = 11;
            this.lblConnectionNickname.Text = "Pseudo";
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.White;
            this.lblConnection.Location = new System.Drawing.Point(408, 361);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(178, 37);
            this.lblConnection.TabIndex = 10;
            this.lblConnection.Text = "Connexion";
            // 
            // txtConnectionNickname
            // 
            this.txtConnectionNickname.Location = new System.Drawing.Point(119, 452);
            this.txtConnectionNickname.Name = "txtConnectionNickname";
            this.txtConnectionNickname.Size = new System.Drawing.Size(235, 20);
            this.txtConnectionNickname.TabIndex = 9;
            // 
            // btnConnectionValidate
            // 
            this.btnConnectionValidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.btnConnectionValidate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnectionValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectionValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectionValidate.ForeColor = System.Drawing.Color.White;
            this.btnConnectionValidate.Location = new System.Drawing.Point(382, 534);
            this.btnConnectionValidate.Name = "btnConnectionValidate";
            this.btnConnectionValidate.Size = new System.Drawing.Size(235, 56);
            this.btnConnectionValidate.TabIndex = 14;
            this.btnConnectionValidate.Text = "Valider";
            this.btnConnectionValidate.UseVisualStyleBackColor = false;
            this.btnConnectionValidate.Click += new System.EventHandler(this.btnConnectionValidate_Click);
            // 
            // lblInscription
            // 
            this.lblInscription.AutoSize = true;
            this.lblInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscription.ForeColor = System.Drawing.Color.White;
            this.lblInscription.Location = new System.Drawing.Point(408, 9);
            this.lblInscription.Name = "lblInscription";
            this.lblInscription.Size = new System.Drawing.Size(174, 37);
            this.lblInscription.TabIndex = 1;
            this.lblInscription.Text = "Inscription";
            // 
            // lblConnectionErrors
            // 
            this.lblConnectionErrors.AutoSize = true;
            this.lblConnectionErrors.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionErrors.Location = new System.Drawing.Point(363, 492);
            this.lblConnectionErrors.Name = "lblConnectionErrors";
            this.lblConnectionErrors.Size = new System.Drawing.Size(0, 13);
            this.lblConnectionErrors.TabIndex = 15;
            // 
            // LoginSignInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.lblConnectionErrors);
            this.Controls.Add(this.btnConnectionValidate);
            this.Controls.Add(this.lblConnectionPassword);
            this.Controls.Add(this.txtConnectionPassword);
            this.Controls.Add(this.lblConnectionNickname);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.txtConnectionNickname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInscriptionValidate);
            this.Controls.Add(this.lblInscriptionConfirmPassword);
            this.Controls.Add(this.txtInscriptionConfirmPassword);
            this.Controls.Add(this.lblInscriptionPassword);
            this.Controls.Add(this.txtInscriptionPassword);
            this.Controls.Add(this.lblInscriptionNickname);
            this.Controls.Add(this.lblInscription);
            this.Controls.Add(this.txtInscriptionNickname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginSignInView";
            this.Text = "Inscription - Connexion";
            this.Load += new System.EventHandler(this.LoginSignInView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInscriptionNickname;
        private System.Windows.Forms.Label lblInscriptionNickname;
        private System.Windows.Forms.Label lblInscriptionPassword;
        private System.Windows.Forms.TextBox txtInscriptionPassword;
        private System.Windows.Forms.Label lblInscriptionConfirmPassword;
        private System.Windows.Forms.TextBox txtInscriptionConfirmPassword;
        private System.Windows.Forms.Button btnInscriptionValidate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConnectionPassword;
        private System.Windows.Forms.TextBox txtConnectionPassword;
        private System.Windows.Forms.Label lblConnectionNickname;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.TextBox txtConnectionNickname;
        private System.Windows.Forms.Button btnConnectionValidate;
        private System.Windows.Forms.Label lblInscription;
        private System.Windows.Forms.Label lblConnectionErrors;
    }
}