
namespace DentalOfficeSchedulingApp
{
	partial class DeleteUser
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
			this.UserCombo = new System.Windows.Forms.ComboBox();
			this.UserLbl = new System.Windows.Forms.Label();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.TitleLbl = new System.Windows.Forms.Label();
			this.SubTitleLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// UserCombo
			// 
			this.UserCombo.FormattingEnabled = true;
			this.UserCombo.Location = new System.Drawing.Point(119, 60);
			this.UserCombo.Name = "UserCombo";
			this.UserCombo.Size = new System.Drawing.Size(121, 21);
			this.UserCombo.TabIndex = 49;
			this.UserCombo.Text = "--Select--";
			this.UserCombo.SelectedValueChanged += new System.EventHandler(this.UserCombo_SelectedValueChanged);
			// 
			// UserLbl
			// 
			this.UserLbl.AutoSize = true;
			this.UserLbl.Location = new System.Drawing.Point(13, 63);
			this.UserLbl.Name = "UserLbl";
			this.UserLbl.Size = new System.Drawing.Size(62, 13);
			this.UserLbl.TabIndex = 62;
			this.UserLbl.Text = "Select User";
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(137, 101);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 61;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Location = new System.Drawing.Point(38, 101);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
			this.DeleteBtn.TabIndex = 60;
			this.DeleteBtn.Text = "Delete";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Location = new System.Drawing.Point(71, 9);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(113, 13);
			this.TitleLbl.TabIndex = 50;
			this.TitleLbl.Text = "Select a user to delete";
			// 
			// SubTitleLbl
			// 
			this.SubTitleLbl.AutoSize = true;
			this.SubTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SubTitleLbl.Location = new System.Drawing.Point(13, 36);
			this.SubTitleLbl.Name = "SubTitleLbl";
			this.SubTitleLbl.Size = new System.Drawing.Size(239, 13);
			this.SubTitleLbl.TabIndex = 63;
			this.SubTitleLbl.Text = "Current logged in user cannot be deleted";
			// 
			// DeleteUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 144);
			this.Controls.Add(this.SubTitleLbl);
			this.Controls.Add(this.UserCombo);
			this.Controls.Add(this.UserLbl);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.TitleLbl);
			this.Name = "DeleteUser";
			this.Text = "Delete User";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox UserCombo;
		private System.Windows.Forms.Label UserLbl;
		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.Label TitleLbl;
		private System.Windows.Forms.Label SubTitleLbl;
	}
}