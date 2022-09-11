
namespace DentalOfficeSchedulingApp
{
	partial class AddCustomer
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
			this.NameLbl = new System.Windows.Forms.Label();
			this.AddressLbl = new System.Windows.Forms.Label();
			this.CityLbl = new System.Windows.Forms.Label();
			this.ZipCodeLbl = new System.Windows.Forms.Label();
			this.CountryLbl = new System.Windows.Forms.Label();
			this.PhoneLbl = new System.Windows.Forms.Label();
			this.ActiveLbl = new System.Windows.Forms.Label();
			this.NameTxt = new System.Windows.Forms.TextBox();
			this.AddressTxt = new System.Windows.Forms.TextBox();
			this.CityTxt = new System.Windows.Forms.TextBox();
			this.ZipCodeTxt = new System.Windows.Forms.TextBox();
			this.CountryTxt = new System.Windows.Forms.TextBox();
			this.PhoneTxt = new System.Windows.Forms.TextBox();
			this.YesRadio = new System.Windows.Forms.RadioButton();
			this.NoRadio = new System.Windows.Forms.RadioButton();
			this.AddBtn = new System.Windows.Forms.Button();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Location = new System.Drawing.Point(70, 14);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(182, 13);
			this.TitleLbl.TabIndex = 0;
			this.TitleLbl.Text = "Please fill out all customer information";
			// 
			// NameLbl
			// 
			this.NameLbl.AutoSize = true;
			this.NameLbl.Location = new System.Drawing.Point(64, 53);
			this.NameLbl.Name = "NameLbl";
			this.NameLbl.Size = new System.Drawing.Size(35, 13);
			this.NameLbl.TabIndex = 1;
			this.NameLbl.Text = "Name";
			// 
			// AddressLbl
			// 
			this.AddressLbl.AutoSize = true;
			this.AddressLbl.Location = new System.Drawing.Point(64, 92);
			this.AddressLbl.Name = "AddressLbl";
			this.AddressLbl.Size = new System.Drawing.Size(45, 13);
			this.AddressLbl.TabIndex = 2;
			this.AddressLbl.Text = "Address";
			// 
			// CityLbl
			// 
			this.CityLbl.AutoSize = true;
			this.CityLbl.Location = new System.Drawing.Point(64, 127);
			this.CityLbl.Name = "CityLbl";
			this.CityLbl.Size = new System.Drawing.Size(24, 13);
			this.CityLbl.TabIndex = 3;
			this.CityLbl.Text = "City";
			// 
			// ZipCodeLbl
			// 
			this.ZipCodeLbl.AutoSize = true;
			this.ZipCodeLbl.Location = new System.Drawing.Point(64, 163);
			this.ZipCodeLbl.Name = "ZipCodeLbl";
			this.ZipCodeLbl.Size = new System.Drawing.Size(50, 13);
			this.ZipCodeLbl.TabIndex = 4;
			this.ZipCodeLbl.Text = "Zip Code";
			// 
			// CountryLbl
			// 
			this.CountryLbl.AutoSize = true;
			this.CountryLbl.Location = new System.Drawing.Point(64, 201);
			this.CountryLbl.Name = "CountryLbl";
			this.CountryLbl.Size = new System.Drawing.Size(43, 13);
			this.CountryLbl.TabIndex = 5;
			this.CountryLbl.Text = "Country";
			// 
			// PhoneLbl
			// 
			this.PhoneLbl.AutoSize = true;
			this.PhoneLbl.Location = new System.Drawing.Point(64, 242);
			this.PhoneLbl.Name = "PhoneLbl";
			this.PhoneLbl.Size = new System.Drawing.Size(38, 13);
			this.PhoneLbl.TabIndex = 6;
			this.PhoneLbl.Text = "Phone";
			// 
			// ActiveLbl
			// 
			this.ActiveLbl.AutoSize = true;
			this.ActiveLbl.Location = new System.Drawing.Point(64, 275);
			this.ActiveLbl.Name = "ActiveLbl";
			this.ActiveLbl.Size = new System.Drawing.Size(37, 13);
			this.ActiveLbl.TabIndex = 7;
			this.ActiveLbl.Text = "Active";
			// 
			// NameTxt
			// 
			this.NameTxt.Location = new System.Drawing.Point(146, 50);
			this.NameTxt.Name = "NameTxt";
			this.NameTxt.Size = new System.Drawing.Size(100, 20);
			this.NameTxt.TabIndex = 8;
			this.NameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxt_KeyPress);
			// 
			// AddressTxt
			// 
			this.AddressTxt.Location = new System.Drawing.Point(146, 89);
			this.AddressTxt.Name = "AddressTxt";
			this.AddressTxt.Size = new System.Drawing.Size(100, 20);
			this.AddressTxt.TabIndex = 9;
			this.AddressTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTxt_KeyPress);
			// 
			// CityTxt
			// 
			this.CityTxt.Location = new System.Drawing.Point(146, 124);
			this.CityTxt.Name = "CityTxt";
			this.CityTxt.Size = new System.Drawing.Size(100, 20);
			this.CityTxt.TabIndex = 10;
			this.CityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityTxt_KeyPress);
			// 
			// ZipCodeTxt
			// 
			this.ZipCodeTxt.Location = new System.Drawing.Point(146, 160);
			this.ZipCodeTxt.Name = "ZipCodeTxt";
			this.ZipCodeTxt.Size = new System.Drawing.Size(100, 20);
			this.ZipCodeTxt.TabIndex = 11;
			this.ZipCodeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipCodeTxt_KeyPress);
			// 
			// CountryTxt
			// 
			this.CountryTxt.Location = new System.Drawing.Point(146, 198);
			this.CountryTxt.Name = "CountryTxt";
			this.CountryTxt.Size = new System.Drawing.Size(100, 20);
			this.CountryTxt.TabIndex = 12;
			this.CountryTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryTxt_KeyPress);
			// 
			// PhoneTxt
			// 
			this.PhoneTxt.Location = new System.Drawing.Point(146, 239);
			this.PhoneTxt.Name = "PhoneTxt";
			this.PhoneTxt.Size = new System.Drawing.Size(100, 20);
			this.PhoneTxt.TabIndex = 13;
			this.PhoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTxt_KeyPress);
			// 
			// YesRadio
			// 
			this.YesRadio.AutoSize = true;
			this.YesRadio.Location = new System.Drawing.Point(146, 271);
			this.YesRadio.Name = "YesRadio";
			this.YesRadio.Size = new System.Drawing.Size(43, 17);
			this.YesRadio.TabIndex = 14;
			this.YesRadio.TabStop = true;
			this.YesRadio.Text = "Yes";
			this.YesRadio.UseVisualStyleBackColor = true;
			// 
			// NoRadio
			// 
			this.NoRadio.AutoSize = true;
			this.NoRadio.Location = new System.Drawing.Point(202, 271);
			this.NoRadio.Name = "NoRadio";
			this.NoRadio.Size = new System.Drawing.Size(39, 17);
			this.NoRadio.TabIndex = 15;
			this.NoRadio.TabStop = true;
			this.NoRadio.Text = "No";
			this.NoRadio.UseVisualStyleBackColor = true;
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(69, 307);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 16;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(168, 307);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 17;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// AddCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 342);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.NoRadio);
			this.Controls.Add(this.YesRadio);
			this.Controls.Add(this.PhoneTxt);
			this.Controls.Add(this.CountryTxt);
			this.Controls.Add(this.ZipCodeTxt);
			this.Controls.Add(this.CityTxt);
			this.Controls.Add(this.AddressTxt);
			this.Controls.Add(this.NameTxt);
			this.Controls.Add(this.ActiveLbl);
			this.Controls.Add(this.PhoneLbl);
			this.Controls.Add(this.CountryLbl);
			this.Controls.Add(this.ZipCodeLbl);
			this.Controls.Add(this.CityLbl);
			this.Controls.Add(this.AddressLbl);
			this.Controls.Add(this.NameLbl);
			this.Controls.Add(this.TitleLbl);
			this.Name = "AddCustomer";
			this.Text = "Sunshine Dental - Add Customer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLbl;
		private System.Windows.Forms.Label NameLbl;
		private System.Windows.Forms.Label AddressLbl;
		private System.Windows.Forms.Label CityLbl;
		private System.Windows.Forms.Label ZipCodeLbl;
		private System.Windows.Forms.Label CountryLbl;
		private System.Windows.Forms.Label PhoneLbl;
		private System.Windows.Forms.Label ActiveLbl;
		private System.Windows.Forms.TextBox NameTxt;
		private System.Windows.Forms.TextBox AddressTxt;
		private System.Windows.Forms.TextBox CityTxt;
		private System.Windows.Forms.TextBox ZipCodeTxt;
		private System.Windows.Forms.TextBox CountryTxt;
		private System.Windows.Forms.TextBox PhoneTxt;
		private System.Windows.Forms.RadioButton YesRadio;
		private System.Windows.Forms.RadioButton NoRadio;
		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.Button ExitBtn;
	}
}