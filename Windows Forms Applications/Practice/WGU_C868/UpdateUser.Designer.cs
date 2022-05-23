
namespace WGU_C868
{
	partial class UpdateUser
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
			this.UpdateBtn = new System.Windows.Forms.Button();
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
			this.UserLbl = new System.Windows.Forms.Label();
			this.UserCombo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(168, 228);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 47;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// UpdateBtn
			// 
			this.UpdateBtn.Location = new System.Drawing.Point(69, 228);
			this.UpdateBtn.Name = "UpdateBtn";
			this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
			this.UpdateBtn.TabIndex = 46;
			this.UpdateBtn.Text = "Update";
			this.UpdateBtn.UseVisualStyleBackColor = true;
			this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
			// 
			// NoRadio
			// 
			this.NoRadio.AutoSize = true;
			this.NoRadio.Location = new System.Drawing.Point(218, 192);
			this.NoRadio.Name = "NoRadio";
			this.NoRadio.Size = new System.Drawing.Size(39, 17);
			this.NoRadio.TabIndex = 45;
			this.NoRadio.TabStop = true;
			this.NoRadio.Text = "No";
			this.NoRadio.UseVisualStyleBackColor = true;
			// 
			// YesRadio
			// 
			this.YesRadio.AutoSize = true;
			this.YesRadio.Location = new System.Drawing.Point(162, 192);
			this.YesRadio.Name = "YesRadio";
			this.YesRadio.Size = new System.Drawing.Size(43, 17);
			this.YesRadio.TabIndex = 44;
			this.YesRadio.TabStop = true;
			this.YesRadio.Text = "Yes";
			this.YesRadio.UseVisualStyleBackColor = true;
			// 
			// ConfirmTxt
			// 
			this.ConfirmTxt.Location = new System.Drawing.Point(150, 149);
			this.ConfirmTxt.Name = "ConfirmTxt";
			this.ConfirmTxt.PasswordChar = '*';
			this.ConfirmTxt.Size = new System.Drawing.Size(119, 20);
			this.ConfirmTxt.TabIndex = 43;
			// 
			// PasswordTxt
			// 
			this.PasswordTxt.Location = new System.Drawing.Point(150, 114);
			this.PasswordTxt.Name = "PasswordTxt";
			this.PasswordTxt.PasswordChar = '*';
			this.PasswordTxt.Size = new System.Drawing.Size(119, 20);
			this.PasswordTxt.TabIndex = 42;
			// 
			// UserNameTxt
			// 
			this.UserNameTxt.Location = new System.Drawing.Point(150, 75);
			this.UserNameTxt.Name = "UserNameTxt";
			this.UserNameTxt.Size = new System.Drawing.Size(119, 20);
			this.UserNameTxt.TabIndex = 41;
			this.UserNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserNameTxt_KeyPress);
			// 
			// ActiveLbl
			// 
			this.ActiveLbl.AutoSize = true;
			this.ActiveLbl.Location = new System.Drawing.Point(40, 192);
			this.ActiveLbl.Name = "ActiveLbl";
			this.ActiveLbl.Size = new System.Drawing.Size(37, 13);
			this.ActiveLbl.TabIndex = 40;
			this.ActiveLbl.Text = "Active";
			// 
			// ConfirmLbl
			// 
			this.ConfirmLbl.AutoSize = true;
			this.ConfirmLbl.Location = new System.Drawing.Point(40, 152);
			this.ConfirmLbl.Name = "ConfirmLbl";
			this.ConfirmLbl.Size = new System.Drawing.Size(91, 13);
			this.ConfirmLbl.TabIndex = 39;
			this.ConfirmLbl.Text = "Confirm Password";
			// 
			// PasswordLbl
			// 
			this.PasswordLbl.AutoSize = true;
			this.PasswordLbl.Location = new System.Drawing.Point(40, 117);
			this.PasswordLbl.Name = "PasswordLbl";
			this.PasswordLbl.Size = new System.Drawing.Size(53, 13);
			this.PasswordLbl.TabIndex = 38;
			this.PasswordLbl.Text = "Password";
			// 
			// UserNameLbl
			// 
			this.UserNameLbl.AutoSize = true;
			this.UserNameLbl.Location = new System.Drawing.Point(40, 78);
			this.UserNameLbl.Name = "UserNameLbl";
			this.UserNameLbl.Size = new System.Drawing.Size(60, 13);
			this.UserNameLbl.TabIndex = 37;
			this.UserNameLbl.Text = "User Name";
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Location = new System.Drawing.Point(55, 9);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(211, 13);
			this.TitleLbl.TabIndex = 36;
			this.TitleLbl.Text = "Only current logged in user can be updated";
			// 
			// UserLbl
			// 
			this.UserLbl.AutoSize = true;
			this.UserLbl.Location = new System.Drawing.Point(41, 38);
			this.UserLbl.Name = "UserLbl";
			this.UserLbl.Size = new System.Drawing.Size(62, 13);
			this.UserLbl.TabIndex = 48;
			this.UserLbl.Text = "Select User";
			// 
			// UserCombo
			// 
			this.UserCombo.FormattingEnabled = true;
			this.UserCombo.Location = new System.Drawing.Point(150, 35);
			this.UserCombo.Name = "UserCombo";
			this.UserCombo.Size = new System.Drawing.Size(121, 21);
			this.UserCombo.TabIndex = 0;
			this.UserCombo.Text = "--Select--";
			this.UserCombo.SelectedValueChanged += new System.EventHandler(this.UserCombo_SelectedValueChanged);
			// 
			// UpdateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 269);
			this.Controls.Add(this.UserCombo);
			this.Controls.Add(this.UserLbl);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.UpdateBtn);
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
			this.Name = "UpdateUser";
			this.Text = "Sunshine Dental - Update User";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.Button UpdateBtn;
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
		private System.Windows.Forms.Label UserLbl;
		private System.Windows.Forms.ComboBox UserCombo;
	}
}