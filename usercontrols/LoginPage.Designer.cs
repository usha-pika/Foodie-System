﻿namespace FoodieSystem.usercontrols
{
    partial class LoginPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateAcct = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            this.UserNaam = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.loginhere = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(445, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 280);
            this.panel5.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CreateAcct);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.RememberMe);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.UserNaam);
            this.panel1.Controls.Add(this.pw);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.loginhere);
            this.panel1.Location = new System.Drawing.Point(476, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 404);
            this.panel1.TabIndex = 4;
            // 
            // gen
            // 
            this.gen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gen.FormattingEnabled = true;
            this.gen.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.gen.Location = new System.Drawing.Point(98, 205);
            this.gen.Name = "gen";
            this.gen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gen.Size = new System.Drawing.Size(121, 21);
            this.gen.TabIndex = 15;
            this.gen.Text = "---Choose---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Type";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(164, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 1);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(3, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 1);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "OR";
            // 
            // CreateAcct
            // 
            this.CreateAcct.AutoSize = true;
            this.CreateAcct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAcct.Location = new System.Drawing.Point(167, 348);
            this.CreateAcct.Name = "CreateAcct";
            this.CreateAcct.Size = new System.Drawing.Size(95, 17);
            this.CreateAcct.TabIndex = 8;
            this.CreateAcct.TabStop = true;
            this.CreateAcct.Text = "Create account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Don\'t have an account?";
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(140)))), ((int)(((byte)(6)))));
            this.btnLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(114, 289);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 28);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberMe.Location = new System.Drawing.Point(81, 246);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(108, 21);
            this.RememberMe.TabIndex = 5;
            this.RememberMe.Text = "Remember me";
            this.RememberMe.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(72, 148);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(147, 20);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            // 
            // UserNaam
            // 
            this.UserNaam.Location = new System.Drawing.Point(72, 82);
            this.UserNaam.Name = "UserNaam";
            this.UserNaam.Size = new System.Drawing.Size(147, 20);
            this.UserNaam.TabIndex = 3;
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw.Location = new System.Drawing.Point(114, 128);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(64, 17);
            this.pw.TabIndex = 2;
            this.pw.Text = "Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(111, 62);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(67, 17);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // loginhere
            // 
            this.loginhere.AutoSize = true;
            this.loginhere.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginhere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(4)))), ((int)(((byte)(15)))));
            this.loginhere.Location = new System.Drawing.Point(67, 10);
            this.loginhere.Name = "loginhere";
            this.loginhere.Size = new System.Drawing.Size(170, 25);
            this.loginhere.TabIndex = 0;
            this.loginhere.Text = "L O G I N    H E R E";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodieSystem.Properties.Resources.foodie_logo;
            this.pictureBox1.Location = new System.Drawing.Point(43, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 431);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 508);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(826, 508);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox gen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel CreateAcct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.CheckBox RememberMe;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox UserNaam;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label loginhere;
        private System.Windows.Forms.Panel panel2;
    }
}
