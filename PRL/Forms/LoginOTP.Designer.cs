﻿namespace PRL.Forms
{
    partial class LoginOTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginOTP));
            label1 = new Label();
            txtEmail = new TextBox();
            txtOTP = new TextBox();
            btnLogin = new Button();
            btnOTP = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(251, 32);
            label1.Name = "label1";
            label1.Size = new Size(182, 81);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(184, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(318, 38);
            txtEmail.TabIndex = 1;
            // 
            // txtOTP
            // 
            txtOTP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtOTP.Location = new Point(184, 201);
            txtOTP.Name = "txtOTP";
            txtOTP.PlaceholderText = "OTP";
            txtOTP.Size = new Size(216, 38);
            txtOTP.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Red;
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(184, 317);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(155, 48);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnOTP
            // 
            btnOTP.AutoSize = true;
            btnOTP.BackColor = Color.Aqua;
            btnOTP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOTP.Location = new Point(406, 199);
            btnOTP.Name = "btnOTP";
            btnOTP.Size = new Size(94, 41);
            btnOTP.TabIndex = 9;
            btnOTP.Text = "OTP";
            btnOTP.UseVisualStyleBackColor = false;
            btnOTP.Click += btnOTP_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(347, 317);
            button1.Name = "button1";
            button1.Size = new Size(155, 48);
            button1.TabIndex = 10;
            button1.Text = "Quay lại";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginOTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 403);
            Controls.Add(button1);
            Controls.Add(btnOTP);
            Controls.Add(btnLogin);
            Controls.Add(txtOTP);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "LoginOTP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private TextBox txtOTP;
        private Button btnLogin;
        private Button btnOTP;
        private Button button1;
    }
}