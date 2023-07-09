
namespace DentalOfficeSchedulingApp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.LoginBtn = new System.Windows.Forms.Button();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.PasswordLbl = new System.Windows.Forms.Label();
			this.PasswordTxt = new System.Windows.Forms.TextBox();
			this.UserNameLbl = new System.Windows.Forms.Label();
			this.UserNameTxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// LoginBtn
			// 
			resources.ApplyResources(this.LoginBtn, "LoginBtn");
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.UseVisualStyleBackColor = true;
			this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
			// 
			// ExitBtn
			// 
			resources.ApplyResources(this.ExitBtn, "ExitBtn");
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// PasswordLbl
			// 
			resources.ApplyResources(this.PasswordLbl, "PasswordLbl");
			this.PasswordLbl.Name = "PasswordLbl";
			// 
			// PasswordTxt
			// 
			resources.ApplyResources(this.PasswordTxt, "PasswordTxt");
			this.PasswordTxt.Name = "PasswordTxt";
			// 
			// UserNameLbl
			// 
			resources.ApplyResources(this.UserNameLbl, "UserNameLbl");
			this.UserNameLbl.Name = "UserNameLbl";
			// 
			// UserNameTxt
			// 
			resources.ApplyResources(this.UserNameTxt, "UserNameTxt");
			this.UserNameTxt.Name = "UserNameTxt";
			// 
			// Login
			// 
			this.AcceptButton = this.LoginBtn;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.UserNameTxt);
			this.Controls.Add(this.UserNameLbl);
			this.Controls.Add(this.PasswordTxt);
			this.Controls.Add(this.PasswordLbl);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.LoginBtn);
			this.Name = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button LoginBtn;
		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.Label PasswordLbl;
		private System.Windows.Forms.TextBox PasswordTxt;
		private System.Windows.Forms.Label UserNameLbl;
		private System.Windows.Forms.TextBox UserNameTxt;
	}
}

