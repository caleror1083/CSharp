
namespace DentalOfficeSchedulingApp
{
	partial class SearchCustomer
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
			this.TitleLbl = new System.Windows.Forms.Label();
			this.CustomerCombo = new System.Windows.Forms.ComboBox();
			this.SearchResults = new System.Windows.Forms.DataGridView();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.DateTimeLbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.SearchResults)).BeginInit();
			this.SuspendLayout();
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLbl.Location = new System.Drawing.Point(152, 13);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(382, 24);
			this.TitleLbl.TabIndex = 1;
			this.TitleLbl.Text = "Select a customer to view their appointments";
			// 
			// CustomerCombo
			// 
			this.CustomerCombo.FormattingEnabled = true;
			this.CustomerCombo.Location = new System.Drawing.Point(183, 46);
			this.CustomerCombo.Name = "CustomerCombo";
			this.CustomerCombo.Size = new System.Drawing.Size(308, 21);
			this.CustomerCombo.TabIndex = 0;
			this.CustomerCombo.Text = "--Select--";
			this.CustomerCombo.SelectedValueChanged += new System.EventHandler(this.CustomerCombo_SelectedValueChanged);
			// 
			// SearchResults
			// 
			this.SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SearchResults.Location = new System.Drawing.Point(12, 73);
			this.SearchResults.Name = "SearchResults";
			this.SearchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.SearchResults.Size = new System.Drawing.Size(646, 276);
			this.SearchResults.TabIndex = 2;
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(291, 355);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 3;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// DateTimeLbl
			// 
			this.DateTimeLbl.AutoSize = true;
			this.DateTimeLbl.Location = new System.Drawing.Point(266, 388);
			this.DateTimeLbl.Name = "DateTimeLbl";
			this.DateTimeLbl.Size = new System.Drawing.Size(0, 13);
			this.DateTimeLbl.TabIndex = 4;
			// 
			// SearchCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(667, 414);
			this.Controls.Add(this.DateTimeLbl);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.SearchResults);
			this.Controls.Add(this.CustomerCombo);
			this.Controls.Add(this.TitleLbl);
			this.Name = "SearchCustomer";
			this.Text = "Sunshine Dental - Search By Customer";
			((System.ComponentModel.ISupportInitialize)(this.SearchResults)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLbl;
		private System.Windows.Forms.ComboBox CustomerCombo;
		private System.Windows.Forms.DataGridView SearchResults;
		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.Label DateTimeLbl;
	}
}