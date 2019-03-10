namespace RecipeFormApp
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkRegister = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_Guest = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(270, 224);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(100, 20);
            this.txtLoginUsername.TabIndex = 1;
            this.txtLoginUsername.Text = "user";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(270, 259);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(100, 20);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "If you are a new user, click to ";
            // 
            // linkRegister
            // 
            this.linkRegister.AutoSize = true;
            this.linkRegister.Location = new System.Drawing.Point(312, 395);
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Size = new System.Drawing.Size(46, 13);
            this.linkRegister.TabIndex = 4;
            this.linkRegister.TabStop = true;
            this.linkRegister.Text = "Register";
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(131, 297);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(111, 31);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_Guest
            // 
            this.btn_Guest.Location = new System.Drawing.Point(280, 297);
            this.btn_Guest.Name = "btn_Guest";
            this.btn_Guest.Size = new System.Drawing.Size(111, 31);
            this.btn_Guest.TabIndex = 4;
            this.btn_Guest.Text = "Continue as Guest";
            this.btn_Guest.UseVisualStyleBackColor = true;
            this.btn_Guest.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "or";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 483);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Guest);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "My Recipe App: Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkRegister;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_Guest;
        private System.Windows.Forms.Label label5;
    }
}

