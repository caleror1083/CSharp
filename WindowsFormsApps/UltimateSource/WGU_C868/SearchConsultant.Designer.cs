
namespace WGU_C868
{
	partial class SearchConsultant
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
			this.DateTimeLbl = new System.Windows.Forms.Label();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.SearchResults = new System.Windows.Forms.DataGridView();
			this.UserCombo = new System.Windows.Forms.ComboBox();
			this.TitleLbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.SearchResults)).BeginInit();
			this.SuspendLayout();
			// 
			// DateTimeLbl
			// 
			this.DateTimeLbl.AutoSize = true;
			this.DateTimeLbl.Location = new System.Drawing.Point(267, 384);
			this.DateTimeLbl.Name = "DateTimeLbl";
			this.DateTimeLbl.Size = new System.Drawing.Size(0, 13);
			this.DateTimeLbl.TabIndex = 9;
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(292, 351);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 8;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// SearchResults
			// 
			this.SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SearchResults.Location = new System.Drawing.Point(13, 69);
			this.SearchResults.Name = "SearchResults";
			this.SearchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.SearchResults.Size = new System.Drawing.Size(646, 276);
			this.SearchResults.TabIndex = 7;
			// 
			// UserCombo
			// 
			this.UserCombo.FormattingEnabled = true;
			this.UserCombo.Location = new System.Drawing.Point(184, 42);
			this.UserCombo.Name = "UserCombo";
			this.UserCombo.Size = new System.Drawing.Size(308, 21);
			this.UserCombo.TabIndex = 5;
			this.UserCombo.Text = "--Select--";
			this.UserCombo.SelectedValueChanged += new System.EventHandler(this.UserCombo_SelectedValueChanged);
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLbl.Location = new System.Drawing.Point(98, 9);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(511, 24);
			this.TitleLbl.TabIndex = 6;
			this.TitleLbl.Text = "Select a user to view the appointments they have scheduled";
			// 
			// SearchConsultant
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(671, 414);
			this.Controls.Add(this.DateTimeLbl);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.SearchResults);
			this.Controls.Add(this.UserCombo);
			this.Controls.Add(this.TitleLbl);
			this.Name = "SearchConsultant";
			this.Text = "Sunshine Dental - Search By User";
			((System.ComponentModel.ISupportInitialize)(this.SearchResults)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label DateTimeLbl;
		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.DataGridView SearchResults;
		private System.Windows.Forms.ComboBox UserCombo;
		private System.Windows.Forms.Label TitleLbl;
	}
}