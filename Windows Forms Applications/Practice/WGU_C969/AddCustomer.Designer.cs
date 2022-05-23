/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

namespace SoftwareCompanySchedulingApp
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
			this.name = new System.Windows.Forms.Label();
			this.address = new System.Windows.Forms.Label();
			this.city = new System.Windows.Forms.Label();
			this.country = new System.Windows.Forms.Label();
			this.postalCode = new System.Windows.Forms.Label();
			this.phone = new System.Windows.Forms.Label();
			this.PostalCodeTxt = new System.Windows.Forms.TextBox();
			this.NameTxt = new System.Windows.Forms.TextBox();
			this.AddressTxt = new System.Windows.Forms.TextBox();
			this.CityTxt = new System.Windows.Forms.TextBox();
			this.PhoneTxt = new System.Windows.Forms.TextBox();
			this.AddBtn = new System.Windows.Forms.Button();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.active = new System.Windows.Forms.Label();
			this.YesRadio = new System.Windows.Forms.RadioButton();
			this.NoRadio = new System.Windows.Forms.RadioButton();
			this.CountryDD = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Location = new System.Drawing.Point(12, 9);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(35, 13);
			this.name.TabIndex = 0;
			this.name.Text = "Name";
			// 
			// address
			// 
			this.address.AutoSize = true;
			this.address.Location = new System.Drawing.Point(12, 44);
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(45, 13);
			this.address.TabIndex = 1;
			this.address.Text = "Address";
			// 
			// city
			// 
			this.city.AutoSize = true;
			this.city.Location = new System.Drawing.Point(12, 83);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(24, 13);
			this.city.TabIndex = 3;
			this.city.Text = "City";
			// 
			// country
			// 
			this.country.AutoSize = true;
			this.country.Location = new System.Drawing.Point(12, 160);
			this.country.Name = "country";
			this.country.Size = new System.Drawing.Size(43, 13);
			this.country.TabIndex = 4;
			this.country.Text = "Country";
			// 
			// postalCode
			// 
			this.postalCode.AutoSize = true;
			this.postalCode.Location = new System.Drawing.Point(12, 124);
			this.postalCode.Name = "postalCode";
			this.postalCode.Size = new System.Drawing.Size(64, 13);
			this.postalCode.TabIndex = 5;
			this.postalCode.Text = "Postal Code";
			// 
			// phone
			// 
			this.phone.AutoSize = true;
			this.phone.Location = new System.Drawing.Point(11, 199);
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(38, 13);
			this.phone.TabIndex = 6;
			this.phone.Text = "Phone";
			// 
			// PostalCodeTxt
			// 
			this.PostalCodeTxt.Location = new System.Drawing.Point(107, 117);
			this.PostalCodeTxt.Name = "PostalCodeTxt";
			this.PostalCodeTxt.Size = new System.Drawing.Size(100, 20);
			this.PostalCodeTxt.TabIndex = 4;
			// 
			// NameTxt
			// 
			this.NameTxt.Location = new System.Drawing.Point(107, 2);
			this.NameTxt.Name = "NameTxt";
			this.NameTxt.Size = new System.Drawing.Size(100, 20);
			this.NameTxt.TabIndex = 1;
			// 
			// AddressTxt
			// 
			this.AddressTxt.Location = new System.Drawing.Point(107, 37);
			this.AddressTxt.Name = "AddressTxt";
			this.AddressTxt.Size = new System.Drawing.Size(100, 20);
			this.AddressTxt.TabIndex = 2;
			// 
			// CityTxt
			// 
			this.CityTxt.Location = new System.Drawing.Point(107, 76);
			this.CityTxt.Name = "CityTxt";
			this.CityTxt.Size = new System.Drawing.Size(100, 20);
			this.CityTxt.TabIndex = 3;
			// 
			// PhoneTxt
			// 
			this.PhoneTxt.Location = new System.Drawing.Point(106, 192);
			this.PhoneTxt.Name = "PhoneTxt";
			this.PhoneTxt.Size = new System.Drawing.Size(100, 20);
			this.PhoneTxt.TabIndex = 6;
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(15, 264);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 9;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(107, 264);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 10;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// active
			// 
			this.active.AutoSize = true;
			this.active.Location = new System.Drawing.Point(14, 227);
			this.active.Name = "active";
			this.active.Size = new System.Drawing.Size(61, 13);
			this.active.TabIndex = 16;
			this.active.Text = "Active Cust";
			// 
			// YesRadio
			// 
			this.YesRadio.AutoSize = true;
			this.YesRadio.Location = new System.Drawing.Point(107, 225);
			this.YesRadio.Name = "YesRadio";
			this.YesRadio.Size = new System.Drawing.Size(43, 17);
			this.YesRadio.TabIndex = 7;
			this.YesRadio.TabStop = true;
			this.YesRadio.Text = "Yes";
			this.YesRadio.UseVisualStyleBackColor = true;
			// 
			// NoRadio
			// 
			this.NoRadio.AutoSize = true;
			this.NoRadio.Location = new System.Drawing.Point(164, 225);
			this.NoRadio.Name = "NoRadio";
			this.NoRadio.Size = new System.Drawing.Size(39, 17);
			this.NoRadio.TabIndex = 8;
			this.NoRadio.TabStop = true;
			this.NoRadio.Text = "No";
			this.NoRadio.UseVisualStyleBackColor = true;
			// 
			// CountryDD
			// 
			this.CountryDD.FormattingEnabled = true;
			this.CountryDD.Location = new System.Drawing.Point(107, 157);
			this.CountryDD.Name = "CountryDD";
			this.CountryDD.Size = new System.Drawing.Size(100, 21);
			this.CountryDD.TabIndex = 5;
			// 
			// AddCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 302);
			this.Controls.Add(this.CountryDD);
			this.Controls.Add(this.NoRadio);
			this.Controls.Add(this.YesRadio);
			this.Controls.Add(this.active);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.AddBtn);
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
			this.Name = "AddCustomer";
			this.Text = "Add Customer";
			this.Load += new System.EventHandler(this.AddCustomer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

				}

				#endregion

				private System.Windows.Forms.Label name;
				private System.Windows.Forms.Label address;
				private System.Windows.Forms.Label city;
				private System.Windows.Forms.Label country;
				private System.Windows.Forms.Label postalCode;
				private System.Windows.Forms.Label phone;
				private System.Windows.Forms.TextBox PostalCodeTxt;
				private System.Windows.Forms.TextBox NameTxt;
				private System.Windows.Forms.TextBox AddressTxt;
				private System.Windows.Forms.TextBox CityTxt;
				private System.Windows.Forms.TextBox PhoneTxt;
				private System.Windows.Forms.Button AddBtn;
				private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.Label active;
		private System.Windows.Forms.RadioButton YesRadio;
		private System.Windows.Forms.RadioButton NoRadio;
		private System.Windows.Forms.ComboBox CountryDD;
	}
	}