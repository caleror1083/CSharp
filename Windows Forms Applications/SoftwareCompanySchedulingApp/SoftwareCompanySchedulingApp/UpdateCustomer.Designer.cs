/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

namespace SoftwareCompanySchedulingApp
	{
		partial class UpdateCustomer
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
			this.PhoneTxt = new System.Windows.Forms.TextBox();
			this.CityTxt = new System.Windows.Forms.TextBox();
			this.AddressTxt = new System.Windows.Forms.TextBox();
			this.NameTxt = new System.Windows.Forms.TextBox();
			this.PostalCodeTxt = new System.Windows.Forms.TextBox();
			this.phone = new System.Windows.Forms.Label();
			this.postalCode = new System.Windows.Forms.Label();
			this.country = new System.Windows.Forms.Label();
			this.city = new System.Windows.Forms.Label();
			this.address = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.Label();
			this.search = new System.Windows.Forms.Label();
			this.SearchTxt = new System.Windows.Forms.TextBox();
			this.SearchBtn = new System.Windows.Forms.Button();
			this.CountryDD = new System.Windows.Forms.ComboBox();
			this.active = new System.Windows.Forms.Label();
			this.YesRadio = new System.Windows.Forms.RadioButton();
			this.NoRadio = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(107, 359);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 12;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// UpdateBtn
			// 
			this.UpdateBtn.Location = new System.Drawing.Point(15, 359);
			this.UpdateBtn.Name = "UpdateBtn";
			this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
			this.UpdateBtn.TabIndex = 11;
			this.UpdateBtn.Text = "Update";
			this.UpdateBtn.UseVisualStyleBackColor = true;
			this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
			// 
			// PhoneTxt
			// 
			this.PhoneTxt.Location = new System.Drawing.Point(100, 265);
			this.PhoneTxt.Name = "PhoneTxt";
			this.PhoneTxt.Size = new System.Drawing.Size(100, 20);
			this.PhoneTxt.TabIndex = 8;
			// 
			// CityTxt
			// 
			this.CityTxt.Location = new System.Drawing.Point(100, 143);
			this.CityTxt.Name = "CityTxt";
			this.CityTxt.Size = new System.Drawing.Size(100, 20);
			this.CityTxt.TabIndex = 5;
			// 
			// AddressTxt
			// 
			this.AddressTxt.Location = new System.Drawing.Point(100, 101);
			this.AddressTxt.Name = "AddressTxt";
			this.AddressTxt.Size = new System.Drawing.Size(100, 20);
			this.AddressTxt.TabIndex = 4;
			// 
			// NameTxt
			// 
			this.NameTxt.Location = new System.Drawing.Point(100, 65);
			this.NameTxt.Name = "NameTxt";
			this.NameTxt.Size = new System.Drawing.Size(100, 20);
			this.NameTxt.TabIndex = 3;
			// 
			// PostalCodeTxt
			// 
			this.PostalCodeTxt.Location = new System.Drawing.Point(100, 178);
			this.PostalCodeTxt.Name = "PostalCodeTxt";
			this.PostalCodeTxt.Size = new System.Drawing.Size(100, 20);
			this.PostalCodeTxt.TabIndex = 6;
			// 
			// phone
			// 
			this.phone.AutoSize = true;
			this.phone.Location = new System.Drawing.Point(12, 271);
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(38, 13);
			this.phone.TabIndex = 22;
			this.phone.Text = "Phone";
			// 
			// postalCode
			// 
			this.postalCode.AutoSize = true;
			this.postalCode.Location = new System.Drawing.Point(12, 184);
			this.postalCode.Name = "postalCode";
			this.postalCode.Size = new System.Drawing.Size(64, 13);
			this.postalCode.TabIndex = 21;
			this.postalCode.Text = "Postal Code";
			// 
			// country
			// 
			this.country.AutoSize = true;
			this.country.Location = new System.Drawing.Point(12, 219);
			this.country.Name = "country";
			this.country.Size = new System.Drawing.Size(43, 13);
			this.country.TabIndex = 20;
			this.country.Text = "Country";
			// 
			// city
			// 
			this.city.AutoSize = true;
			this.city.Location = new System.Drawing.Point(12, 149);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(24, 13);
			this.city.TabIndex = 19;
			this.city.Text = "City";
			// 
			// address
			// 
			this.address.AutoSize = true;
			this.address.Location = new System.Drawing.Point(12, 107);
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(45, 13);
			this.address.TabIndex = 17;
			this.address.Text = "Address";
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Location = new System.Drawing.Point(12, 71);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(35, 13);
			this.name.TabIndex = 16;
			this.name.Text = "Name";
			// 
			// search
			// 
			this.search.AutoSize = true;
			this.search.Location = new System.Drawing.Point(13, 23);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(44, 13);
			this.search.TabIndex = 32;
			this.search.Text = "Search:";
			// 
			// SearchTxt
			// 
			this.SearchTxt.Location = new System.Drawing.Point(100, 16);
			this.SearchTxt.Name = "SearchTxt";
			this.SearchTxt.Size = new System.Drawing.Size(100, 20);
			this.SearchTxt.TabIndex = 1;
			// 
			// SearchBtn
			// 
			this.SearchBtn.Location = new System.Drawing.Point(224, 15);
			this.SearchBtn.Name = "SearchBtn";
			this.SearchBtn.Size = new System.Drawing.Size(75, 23);
			this.SearchBtn.TabIndex = 2;
			this.SearchBtn.Text = "Search";
			this.SearchBtn.UseVisualStyleBackColor = true;
			this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
			// 
			// CountryDD
			// 
			this.CountryDD.FormattingEnabled = true;
			this.CountryDD.Location = new System.Drawing.Point(100, 220);
			this.CountryDD.Name = "CountryDD";
			this.CountryDD.Size = new System.Drawing.Size(100, 21);
			this.CountryDD.TabIndex = 7;
			// 
			// active
			// 
			this.active.AutoSize = true;
			this.active.Location = new System.Drawing.Point(15, 312);
			this.active.Name = "active";
			this.active.Size = new System.Drawing.Size(61, 13);
			this.active.TabIndex = 36;
			this.active.Text = "Active Cust";
			// 
			// YesRadio
			// 
			this.YesRadio.AutoSize = true;
			this.YesRadio.Location = new System.Drawing.Point(100, 313);
			this.YesRadio.Name = "YesRadio";
			this.YesRadio.Size = new System.Drawing.Size(43, 17);
			this.YesRadio.TabIndex = 9;
			this.YesRadio.TabStop = true;
			this.YesRadio.Text = "Yes";
			this.YesRadio.UseVisualStyleBackColor = true;
			// 
			// NoRadio
			// 
			this.NoRadio.AutoSize = true;
			this.NoRadio.Location = new System.Drawing.Point(157, 313);
			this.NoRadio.Name = "NoRadio";
			this.NoRadio.Size = new System.Drawing.Size(39, 17);
			this.NoRadio.TabIndex = 10;
			this.NoRadio.TabStop = true;
			this.NoRadio.Text = "No";
			this.NoRadio.UseVisualStyleBackColor = true;
			// 
			// UpdateCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(313, 394);
			this.Controls.Add(this.NoRadio);
			this.Controls.Add(this.YesRadio);
			this.Controls.Add(this.active);
			this.Controls.Add(this.CountryDD);
			this.Controls.Add(this.SearchBtn);
			this.Controls.Add(this.SearchTxt);
			this.Controls.Add(this.search);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.UpdateBtn);
			this.Controls.Add(this.PhoneTxt);
			this.Controls.Add(this.CityTxt);
			this.Controls.Add(this.AddressTxt);
			this.Controls.Add(this.NameTxt);
			this.Controls.Add(this.PostalCodeTxt);
			this.Controls.Add(this.phone);
			this.Controls.Add(this.postalCode);
			this.Controls.Add(this.country);
			this.Controls.Add(this.city);
			this.Controls.Add(this.address);
			this.Controls.Add(this.name);
			this.Name = "UpdateCustomer";
			this.Text = "Update Customer";
			this.Load += new System.EventHandler(this.UpdateCustomer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

					}

				#endregion

				private System.Windows.Forms.Button ExitBtn;
				private System.Windows.Forms.Button UpdateBtn;
				private System.Windows.Forms.TextBox PhoneTxt;
				private System.Windows.Forms.TextBox CityTxt;
				private System.Windows.Forms.TextBox AddressTxt;
				private System.Windows.Forms.TextBox NameTxt;
				private System.Windows.Forms.TextBox PostalCodeTxt;
				private System.Windows.Forms.Label phone;
				private System.Windows.Forms.Label postalCode;
				private System.Windows.Forms.Label country;
				private System.Windows.Forms.Label city;
				private System.Windows.Forms.Label address;
				private System.Windows.Forms.Label name;
				private System.Windows.Forms.Label search;
				private System.Windows.Forms.TextBox SearchTxt;
				private System.Windows.Forms.Button SearchBtn;
		private System.Windows.Forms.ComboBox CountryDD;
		private System.Windows.Forms.Label active;
		private System.Windows.Forms.RadioButton YesRadio;
		private System.Windows.Forms.RadioButton NoRadio;
	}
	}