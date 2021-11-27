
namespace GUI_PL
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_Register = new System.Windows.Forms.Button();
            this.bt_ChangePassword = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(249, 104);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(125, 27);
            this.txt_Email.TabIndex = 2;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(249, 168);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(125, 27);
            this.txt_Password.TabIndex = 3;
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(27, 270);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(135, 29);
            this.bt_Login.TabIndex = 4;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.LoginfromFORMLOGIN);
            // 
            // bt_Register
            // 
            this.bt_Register.Location = new System.Drawing.Point(209, 270);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.Size = new System.Drawing.Size(129, 29);
            this.bt_Register.TabIndex = 5;
            this.bt_Register.Text = "Register";
            this.bt_Register.UseVisualStyleBackColor = true;
            this.bt_Register.Click += new System.EventHandler(this.RegisterfromFORMLOGIN);
            // 
            // bt_ChangePassword
            // 
            this.bt_ChangePassword.Location = new System.Drawing.Point(383, 270);
            this.bt_ChangePassword.Name = "bt_ChangePassword";
            this.bt_ChangePassword.Size = new System.Drawing.Size(131, 29);
            this.bt_ChangePassword.TabIndex = 6;
            this.bt_ChangePassword.Text = "ChangePassword";
            this.bt_ChangePassword.UseVisualStyleBackColor = true;
            this.bt_ChangePassword.Click += new System.EventHandler(this.ChangefromFORMLOGIN);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(551, 270);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(116, 29);
            this.bt_Exit.TabIndex = 7;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(190, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "LOGINFORM";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_ChangePassword);
            this.Controls.Add(this.bt_Register);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button bt_Register;
        private System.Windows.Forms.Button bt_ChangePassword;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Label label3;
    }
}

