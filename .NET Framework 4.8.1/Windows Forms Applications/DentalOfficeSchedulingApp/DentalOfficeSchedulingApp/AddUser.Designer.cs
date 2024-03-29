﻿
namespace DentalOfficeSchedulingApp
{
	partial class AddUser
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
			this.ExitBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.NoRadio = new System.Windows.Forms.RadioButton();
			this.YesRadio = new System.Windows.Forms.RadioButton();
			this.ConfirmTxt = new System.Windows.Forms.TextBox();
			this.PasswordTxt = new System.Windows.Forms.TextBox();
			this.UserNameTxt = new System.Windows.Forms.TextBox();
			this.ActiveLbl = new System.Windows.Forms.Label();
			this.ConfirmLbl = new System.Windows.Forms.Label();
			this.PasswordLbl = new System.Windows.Forms.Label();
			this.UserNameLbl = new System.Windows.Forms.Label();
			this.TitleLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(157, 195);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 35;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(58, 195);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 34;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// NoRadio
			// 
			this.NoRadio.AutoSize = true;
			this.NoRadio.Location = new System.Drawing.Point(193, 159);
			this.NoRadio.Name = "NoRadio";
			this.NoRadio.Size = new System.Drawing.Size(39, 17);
			this.NoRadio.TabIndex = 33;
			this.NoRadio.TabStop = true;
			this.NoRadio.Text = "No";
			this.NoRadio.UseVisualStyleBackColor = true;
			// 
			// YesRadio
			// 
			this.YesRadio.AutoSize = true;
			this.YesRadio.Location = new System.Drawing.Point(137, 159);
			this.YesRadio.Name = "YesRadio";
			this.YesRadio.Size = new System.Drawing.Size(43, 17);
			this.YesRadio.TabIndex = 32;
			this.YesRadio.TabStop = true;
			this.YesRadio.Text = "Yes";
			this.YesRadio.UseVisualStyleBackColor = true;
			// 
			// ConfirmTxt
			// 
			this.ConfirmTxt.Location = new System.Drawing.Point(139, 116);
			this.ConfirmTxt.Name = "ConfirmTxt";
			this.ConfirmTxt.PasswordChar = '*';
			this.ConfirmTxt.Size = new System.Drawing.Size(100, 20);
			this.ConfirmTxt.TabIndex = 28;
			// 
			// PasswordTxt
			// 
			this.PasswordTxt.Location = new System.Drawing.Point(139, 81);
			this.PasswordTxt.Name = "PasswordTxt";
			this.PasswordTxt.PasswordChar = '*';
			this.PasswordTxt.Size = new System.Drawing.Size(100, 20);
			this.PasswordTxt.TabIndex = 27;
			// 
			// UserNameTxt
			// 
			this.UserNameTxt.Location = new System.Drawing.Point(139, 42);
			this.UserNameTxt.Name = "UserNameTxt";
			this.UserNameTxt.Size = new System.Drawing.Size(100, 20);
			this.UserNameTxt.TabIndex = 26;
			this.UserNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserNameTxt_KeyPress);
			// 
			// ActiveLbl
			// 
			this.ActiveLbl.AutoSize = true;
			this.ActiveLbl.Location = new System.Drawing.Point(29, 159);
			this.ActiveLbl.Name = "ActiveLbl";
			this.ActiveLbl.Size = new System.Drawing.Size(37, 13);
			this.ActiveLbl.TabIndex = 25;
			this.ActiveLbl.Text = "Active";
			// 
			// ConfirmLbl
			// 
			this.ConfirmLbl.AutoSize = true;
			this.ConfirmLbl.Location = new System.Drawing.Point(29, 119);
			this.ConfirmLbl.Name = "ConfirmLbl";
			this.ConfirmLbl.Size = new System.Drawing.Size(91, 13);
			this.ConfirmLbl.TabIndex = 21;
			this.ConfirmLbl.Text = "Confirm Password";
			// 
			// PasswordLbl
			// 
			this.PasswordLbl.AutoSize = true;
			this.PasswordLbl.Location = new System.Drawing.Point(29, 84);
			this.PasswordLbl.Name = "PasswordLbl";
			this.PasswordLbl.Size = new System.Drawing.Size(53, 13);
			this.PasswordLbl.TabIndex = 20;
			this.PasswordLbl.Text = "Password";
			// 
			// UserNameLbl
			// 
			this.UserNameLbl.AutoSize = true;
			this.UserNameLbl.Location = new System.Drawing.Point(29, 45);
			this.UserNameLbl.Name = "UserNameLbl";
			this.UserNameLbl.Size = new System.Drawing.Size(60, 13);
			this.UserNameLbl.TabIndex = 19;
			this.UserNameLbl.Text = "User Name";
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Location = new System.Drawing.Point(58, 9);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(159, 13);
			this.TitleLbl.TabIndex = 18;
			this.TitleLbl.Text = "Please fill out all user information";
			// 
			// AddUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 243);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.NoRadio);
			this.Controls.Add(this.YesRadio);
			this.Controls.Add(this.ConfirmTxt);
			this.Controls.Add(this.PasswordTxt);
			this.Controls.Add(this.UserNameTxt);
			this.Controls.Add(this.ActiveLbl);
			this.Controls.Add(this.ConfirmLbl);
			this.Controls.Add(this.PasswordLbl);
			this.Controls.Add(this.UserNameLbl);
			this.Controls.Add(this.TitleLbl);
			this.Name = "AddUser";
			this.Text = "Sunshine Dental - Add User";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.RadioButton NoRadio;
		private System.Windows.Forms.RadioButton YesRadio;
		private System.Windows.Forms.TextBox ConfirmTxt;
		private System.Windows.Forms.TextBox PasswordTxt;
		private System.Windows.Forms.TextBox UserNameTxt;
		private System.Windows.Forms.Label ActiveLbl;
		private System.Windows.Forms.Label ConfirmLbl;
		private System.Windows.Forms.Label PasswordLbl;
		private System.Windows.Forms.Label UserNameLbl;
		private System.Windows.Forms.Label TitleLbl;
	}
}