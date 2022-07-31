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
			this.usernameLbl = new System.Windows.Forms.Label();
			this.passwordLbl = new System.Windows.Forms.Label();
			this.usernameTxt = new System.Windows.Forms.TextBox();
			this.passwordTxt = new System.Windows.Forms.TextBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.LoginError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// usernameLbl
			// 
			this.usernameLbl.AutoSize = true;
			this.usernameLbl.Location = new System.Drawing.Point(80, 59);
			this.usernameLbl.Name = "usernameLbl";
			this.usernameLbl.Size = new System.Drawing.Size(55, 13);
			this.usernameLbl.TabIndex = 2;
			this.usernameLbl.Text = "Username";
			// 
			// passwordLbl
			// 
			this.passwordLbl.AutoSize = true;
			this.passwordLbl.Location = new System.Drawing.Point(83, 108);
			this.passwordLbl.Name = "passwordLbl";
			this.passwordLbl.Size = new System.Drawing.Size(53, 13);
			this.passwordLbl.TabIndex = 3;
			this.passwordLbl.Text = "Password";
			// 
			// usernameTxt
			// 
			this.usernameTxt.Location = new System.Drawing.Point(178, 59);
			this.usernameTxt.Name = "usernameTxt";
			this.usernameTxt.Size = new System.Drawing.Size(134, 20);
			this.usernameTxt.TabIndex = 0;
			// 
			// passwordTxt
			// 
			this.passwordTxt.Location = new System.Drawing.Point(178, 100);
			this.passwordTxt.Name = "passwordTxt";
			this.passwordTxt.Size = new System.Drawing.Size(134, 20);
			this.passwordTxt.TabIndex = 1;
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
			// loginError
			// 
			this.LoginError.AutoSize = true;
			this.LoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginError.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.LoginError.Location = new System.Drawing.Point(50, 147);
			this.LoginError.Name = "loginError";
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
			this.Controls.Add(this.passwordTxt);
			this.Controls.Add(this.usernameTxt);
			this.Controls.Add(this.passwordLbl);
			this.Controls.Add(this.usernameLbl);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

					}

				#endregion

				private System.Windows.Forms.Label usernameLbl;
				private System.Windows.Forms.Label passwordLbl;
				private System.Windows.Forms.TextBox usernameTxt;
				private System.Windows.Forms.TextBox passwordTxt;
				private System.Windows.Forms.Button LoginButton;
				private System.Windows.Forms.Button ExitButton;
				private System.Windows.Forms.Label LoginError;
			}
	}