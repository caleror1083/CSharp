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
			this._UsernameLabel = new System.Windows.Forms.Label();
			this._PasswordLabel = new System.Windows.Forms.Label();
			this._UsernameTextbox = new System.Windows.Forms.TextBox();
			this._PasswordTextbox = new System.Windows.Forms.TextBox();
			this._LoginButton = new System.Windows.Forms.Button();
			this._ExitButton = new System.Windows.Forms.Button();
			this._LoginErrorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// usernameLbl
			// 
			this._UsernameLabel.AutoSize = true;
			this._UsernameLabel.Location = new System.Drawing.Point(80, 59);
			this._UsernameLabel.Name = "usernameLbl";
			this._UsernameLabel.Size = new System.Drawing.Size(55, 13);
			this._UsernameLabel.TabIndex = 2;
			this._UsernameLabel.Text = "Username";
			// 
			// passwordLbl
			// 
			this._PasswordLabel.AutoSize = true;
			this._PasswordLabel.Location = new System.Drawing.Point(83, 108);
			this._PasswordLabel.Name = "passwordLbl";
			this._PasswordLabel.Size = new System.Drawing.Size(53, 13);
			this._PasswordLabel.TabIndex = 3;
			this._PasswordLabel.Text = "Password";
			// 
			// usernameTxt
			// 
			this._UsernameTextbox.Location = new System.Drawing.Point(178, 59);
			this._UsernameTextbox.Name = "usernameTxt";
			this._UsernameTextbox.Size = new System.Drawing.Size(134, 20);
			this._UsernameTextbox.TabIndex = 0;
			// 
			// passwordTxt
			// 
			this._PasswordTextbox.Location = new System.Drawing.Point(178, 100);
			this._PasswordTextbox.Name = "passwordTxt";
			this._PasswordTextbox.Size = new System.Drawing.Size(134, 20);
			this._PasswordTextbox.TabIndex = 1;
			// 
			// LoginButton
			// 
			this._LoginButton.Location = new System.Drawing.Point(86, 178);
			this._LoginButton.Name = "LoginButton";
			this._LoginButton.Size = new System.Drawing.Size(75, 23);
			this._LoginButton.TabIndex = 4;
			this._LoginButton.Text = global::SoftwareCompanySchedulingApp.Properties.translations.res_login_loginBtn;
			this._LoginButton.UseVisualStyleBackColor = true;
			this._LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// ExitButton
			// 
			this._ExitButton.Location = new System.Drawing.Point(237, 178);
			this._ExitButton.Name = "ExitButton";
			this._ExitButton.Size = new System.Drawing.Size(75, 23);
			this._ExitButton.TabIndex = 5;
			this._ExitButton.Text = global::SoftwareCompanySchedulingApp.Properties.translations.res_login_exitBtn;
			this._ExitButton.UseVisualStyleBackColor = true;
			this._ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// LoginError
			// 
			this._LoginErrorLabel.AutoSize = true;
			this._LoginErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._LoginErrorLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this._LoginErrorLabel.Location = new System.Drawing.Point(50, 147);
			this._LoginErrorLabel.Name = "LoginError";
			this._LoginErrorLabel.Size = new System.Drawing.Size(0, 17);
			this._LoginErrorLabel.TabIndex = 6;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 265);
			this.Controls.Add(this._LoginErrorLabel);
			this.Controls.Add(this._ExitButton);
			this.Controls.Add(this._LoginButton);
			this.Controls.Add(this._PasswordTextbox);
			this.Controls.Add(this._UsernameTextbox);
			this.Controls.Add(this._PasswordLabel);
			this.Controls.Add(this._UsernameLabel);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

					}

				#endregion

				private System.Windows.Forms.Label _UsernameLabel;
				private System.Windows.Forms.Label _PasswordLabel;
				private System.Windows.Forms.TextBox _UsernameTextbox;
				private System.Windows.Forms.TextBox _PasswordTextbox;
				private System.Windows.Forms.Button _LoginButton;
				private System.Windows.Forms.Button _ExitButton;
				private System.Windows.Forms.Label _LoginErrorLabel;
			}
	}