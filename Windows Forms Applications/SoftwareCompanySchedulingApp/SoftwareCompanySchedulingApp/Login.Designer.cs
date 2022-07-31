/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

namespace SoftwareCompanySchedulingApp
	{
	    partial class Login
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
			this.UsernameLbl = new System.Windows.Forms.Label();
			this.PasswordLbl = new System.Windows.Forms.Label();
			this.UsernameTxt = new System.Windows.Forms.TextBox();
			this.PasswordTxt = new System.Windows.Forms.TextBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.LoginError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// usernameLbl
			// 
			this.UsernameLbl.AutoSize = true;
			this.UsernameLbl.Location = new System.Drawing.Point(80, 59);
			this.UsernameLbl.Name = "usernameLbl";
			this.UsernameLbl.Size = new System.Drawing.Size(55, 13);
			this.UsernameLbl.TabIndex = 2;
			this.UsernameLbl.Text = "Username";
			// 
			// passwordLbl
			// 
			this.PasswordLbl.AutoSize = true;
			this.PasswordLbl.Location = new System.Drawing.Point(83, 108);
			this.PasswordLbl.Name = "passwordLbl";
			this.PasswordLbl.Size = new System.Drawing.Size(53, 13);
			this.PasswordLbl.TabIndex = 3;
			this.PasswordLbl.Text = "Password";
			// 
			// usernameTxt
			// 
			this.UsernameTxt.Location = new System.Drawing.Point(178, 59);
			this.UsernameTxt.Name = "usernameTxt";
			this.UsernameTxt.Size = new System.Drawing.Size(134, 20);
			this.UsernameTxt.TabIndex = 0;
			// 
			// passwordTxt
			// 
			this.PasswordTxt.Location = new System.Drawing.Point(178, 100);
			this.PasswordTxt.Name = "passwordTxt";
			this.PasswordTxt.Size = new System.Drawing.Size(134, 20);
			this.PasswordTxt.TabIndex = 1;
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(86, 178);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(75, 23);
			this.LoginButton.TabIndex = 4;
			this.LoginButton.Text = global::SoftwareCompanySchedulingApp.Properties.translations.res_login_loginBtn;
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(237, 178);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(75, 23);
			this.ExitButton.TabIndex = 5;
			this.ExitButton.Text = global::SoftwareCompanySchedulingApp.Properties.translations.res_login_exitBtn;
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// LoginError
			// 
			this.LoginError.AutoSize = true;
			this.LoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginError.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.LoginError.Location = new System.Drawing.Point(50, 147);
			this.LoginError.Name = "LoginError";
			this.LoginError.Size = new System.Drawing.Size(0, 17);
			this.LoginError.TabIndex = 6;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 265);
			this.Controls.Add(this.LoginError);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.PasswordTxt);
			this.Controls.Add(this.UsernameTxt);
			this.Controls.Add(this.PasswordLbl);
			this.Controls.Add(this.UsernameLbl);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

					}

				#endregion

				private System.Windows.Forms.Label UsernameLbl;
				private System.Windows.Forms.Label PasswordLbl;
				private System.Windows.Forms.TextBox UsernameTxt;
				private System.Windows.Forms.TextBox PasswordTxt;
				private System.Windows.Forms.Button LoginButton;
				private System.Windows.Forms.Button ExitButton;
				private System.Windows.Forms.Label LoginError;
			}
	}