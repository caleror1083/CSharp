// Robert Calero
// Login Form - C# - Windows Form Application .NET Framework

namespace Login
    {
        partial class LoginForm
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
			this.lblUser = new System.Windows.Forms.Label();
			this.lblPW = new System.Windows.Forms.Label();
			this.UserNameInfo = new System.Windows.Forms.TextBox();
			this.PasswordInfo = new System.Windows.Forms.TextBox();
			this.Exit = new System.Windows.Forms.Button();
			this.LoginMain = new System.Windows.Forms.Button();
			this.lblLogin = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.LoginMainMySql = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Location = new System.Drawing.Point(270, 56);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(63, 13);
			this.lblUser.TabIndex = 0;
			this.lblUser.Text = "User Name:";
			// 
			// lblPW
			// 
			this.lblPW.AutoSize = true;
			this.lblPW.Location = new System.Drawing.Point(270, 103);
			this.lblPW.Name = "lblPW";
			this.lblPW.Size = new System.Drawing.Size(56, 13);
			this.lblPW.TabIndex = 1;
			this.lblPW.Text = "Password:";
			// 
			// UserNameInfo
			// 
			this.UserNameInfo.Location = new System.Drawing.Point(339, 56);
			this.UserNameInfo.Name = "UserNameInfo";
			this.UserNameInfo.Size = new System.Drawing.Size(100, 20);
			this.UserNameInfo.TabIndex = 2;
			// 
			// PasswordInfo
			// 
			this.PasswordInfo.Location = new System.Drawing.Point(339, 103);
			this.PasswordInfo.Name = "PasswordInfo";
			this.PasswordInfo.Size = new System.Drawing.Size(100, 20);
			this.PasswordInfo.TabIndex = 3;
			// 
			// Exit
			// 
			this.Exit.Location = new System.Drawing.Point(273, 148);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(75, 23);
			this.Exit.TabIndex = 4;
			this.Exit.Text = "&Exit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// LoginMain
			// 
			this.LoginMain.Location = new System.Drawing.Point(364, 148);
			this.LoginMain.Name = "LoginMain";
			this.LoginMain.Size = new System.Drawing.Size(75, 23);
			this.LoginMain.TabIndex = 5;
			this.LoginMain.Text = "Login";
			this.LoginMain.UseVisualStyleBackColor = true;
			this.LoginMain.Click += new System.EventHandler(this.LoginMain_Click);
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Location = new System.Drawing.Point(84, 93);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(33, 13);
			this.lblLogin.TabIndex = 6;
			this.lblLogin.Text = "Login";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.lblLogin);
			this.panel1.Location = new System.Drawing.Point(20, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(214, 182);
			this.panel1.TabIndex = 7;
			// 
			// LoginMainMySql
			// 
			this.LoginMainMySql.Location = new System.Drawing.Point(364, 177);
			this.LoginMainMySql.Name = "LoginMainMySql";
			this.LoginMainMySql.Size = new System.Drawing.Size(100, 23);
			this.LoginMainMySql.TabIndex = 8;
			this.LoginMainMySql.Text = "Login MySQL";
			this.LoginMainMySql.UseVisualStyleBackColor = true;
			this.LoginMainMySql.Click += new System.EventHandler(this.LoginMainMySql_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(478, 218);
			this.Controls.Add(this.LoginMainMySql);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.LoginMain);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.PasswordInfo);
			this.Controls.Add(this.UserNameInfo);
			this.Controls.Add(this.lblPW);
			this.Controls.Add(this.lblUser);
			this.Name = "LoginForm";
			this.Text = "Login Window";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

                    }

                #endregion

                private System.Windows.Forms.Label lblUser;
                private System.Windows.Forms.Label lblPW;
                private System.Windows.Forms.TextBox UserNameInfo;
                private System.Windows.Forms.TextBox PasswordInfo;
                private System.Windows.Forms.Button Exit;
                private System.Windows.Forms.Button LoginMain;
                private System.Windows.Forms.Label lblLogin;
                private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button LoginMainMySql;
	}
    }