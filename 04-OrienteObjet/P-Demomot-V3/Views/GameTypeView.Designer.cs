namespace P_Demomot.Views
{
    partial class GameTypeView
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
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.lblGameType = new System.Windows.Forms.Label();
            this.btnVsIa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(333, 536);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(354, 77);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.btnMulti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.Color.White;
            this.btnMulti.Location = new System.Drawing.Point(333, 207);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(354, 77);
            this.btnMulti.TabIndex = 16;
            this.btnMulti.Text = "Multijoueur";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.btnLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocal.ForeColor = System.Drawing.Color.White;
            this.btnLocal.Location = new System.Drawing.Point(333, 94);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(354, 77);
            this.btnLocal.TabIndex = 15;
            this.btnLocal.Text = "Local";
            this.btnLocal.UseVisualStyleBackColor = false;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // lblGameType
            // 
            this.lblGameType.AutoSize = true;
            this.lblGameType.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameType.ForeColor = System.Drawing.Color.White;
            this.lblGameType.Location = new System.Drawing.Point(401, 9);
            this.lblGameType.Name = "lblGameType";
            this.lblGameType.Size = new System.Drawing.Size(234, 37);
            this.lblGameType.TabIndex = 14;
            this.lblGameType.Text = "Type de partie";
            // 
            // btnVsIa
            // 
            this.btnVsIa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(46)))), ((int)(((byte)(165)))));
            this.btnVsIa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVsIa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVsIa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVsIa.ForeColor = System.Drawing.Color.White;
            this.btnVsIa.Location = new System.Drawing.Point(333, 324);
            this.btnVsIa.Name = "btnVsIa";
            this.btnVsIa.Size = new System.Drawing.Size(354, 77);
            this.btnVsIa.TabIndex = 18;
            this.btnVsIa.Text = "Contre l\'ordinateur";
            this.btnVsIa.UseVisualStyleBackColor = false;
            this.btnVsIa.Click += new System.EventHandler(this.btnVsIa_Click);
            // 
            // GameTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnVsIa);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.lblGameType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameTypeView";
            this.Text = "Type de partie";
            this.Load += new System.EventHandler(this.GameTypeView_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Label lblGameType;
        private System.Windows.Forms.Button btnVsIa;
    }
}