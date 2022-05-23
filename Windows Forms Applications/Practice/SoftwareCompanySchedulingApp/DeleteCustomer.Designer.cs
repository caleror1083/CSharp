/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

namespace SoftwareCompanySchedulingApp
	{
		partial class DeleteCustomer
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
			this.SearchBtn = new System.Windows.Forms.Button();
			this.SearchTxt = new System.Windows.Forms.TextBox();
			this.search = new System.Windows.Forms.Label();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.PhoneTxt = new System.Windows.Forms.TextBox();
			this.CityTxt = new System.Windows.Forms.TextBox();
			this.AddressTxt = new System.Windows.Forms.TextBox();
			this.NameTxt = new System.Windows.Forms.TextBox();
			this.PostalCodeTxt = new System.Windows.Forms.TextBox();
			this.phone = new System.Windows.Forms.Label();
			this.postalCode = new System.Windows.Forms.Label();
			this.country = new System.Windows.Forms.Label();
			this.city = new System.Windows.Forms.Label();
			this.active = new System.Windows.Forms.Label();
			this.address = new System.Windows.Forms.Label();
			this.customerName = new System.Windows.Forms.Label();
			this.CountryTxt = new System.Windows.Forms.TextBox();
			this.ActiveTxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// SearchBtn
			// 
			this.SearchBtn.Location = new System.Drawing.Point(223, 11);
			this.SearchBtn.Name = "SearchBtn";
			this.SearchBtn.Size = new System.Drawing.Size(75, 23);
			this.SearchBtn.TabIndex = 2;
			this.SearchBtn.Text = "Search";
			this.SearchBtn.UseVisualStyleBackColor = true;
			this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
			// 
			// SearchTxt
			// 
			this.SearchTxt.Location = new System.Drawing.Point(93, 11);
			this.SearchTxt.Name = "SearchTxt";
			this.SearchTxt.Size = new System.Drawing.Size(100, 20);
			this.SearchTxt.TabIndex = 1;
			// 
			// search
			// 
			this.search.AutoSize = true;
			this.search.Location = new System.Drawing.Point(12, 19);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(44, 13);
			this.search.TabIndex = 51;
			this.search.Text = "Search:";
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(106, 322);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 11;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Location = new System.Drawing.Point(14, 322);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
			this.DeleteBtn.TabIndex = 10;
			this.DeleteBtn.Text = "Delete";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// PhoneTxt
			// 
			this.PhoneTxt.Location = new System.Drawing.Point(93, 249);
			this.PhoneTxt.Name = "PhoneTxt";
			this.PhoneTxt.ReadOnly = true;
			this.PhoneTxt.Size = new System.Drawing.Size(100, 20);
			this.PhoneTxt.TabIndex = 8;
			// 
			// CityTxt
			// 
			this.CityTxt.Location = new System.Drawing.Point(93, 136);
			this.CityTxt.Name = "CityTxt";
			this.CityTxt.ReadOnly = true;
			this.CityTxt.Size = new System.Drawing.Size(100, 20);
			this.CityTxt.TabIndex = 5;
			// 
			// AddressTxt
			// 
			this.AddressTxt.Location = new System.Drawing.Point(93, 96);
			this.AddressTxt.Name = "AddressTxt";
			this.AddressTxt.ReadOnly = true;
			this.AddressTxt.Size = new System.Drawing.Size(100, 20);
			this.AddressTxt.TabIndex = 4;
			// 
			// NameTxt
			// 
			this.NameTxt.Location = new System.Drawing.Point(93, 60);
			this.NameTxt.Name = "NameTxt";
			this.NameTxt.ReadOnly = true;
			this.NameTxt.Size = new System.Drawing.Size(100, 20);
			this.NameTxt.TabIndex = 3;
			// 
			// PostalCodeTxt
			// 
			this.PostalCodeTxt.Location = new System.Drawing.Point(93, 173);
			this.PostalCodeTxt.Name = "PostalCodeTxt";
			this.PostalCodeTxt.ReadOnly = true;
			this.PostalCodeTxt.Size = new System.Drawing.Size(100, 20);
			this.PostalCodeTxt.TabIndex = 6;
			// 
			// phone
			// 
			this.phone.AutoSize = true;
			this.phone.Location = new System.Drawing.Point(11, 256);
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(38, 13);
			this.phone.TabIndex = 41;
			this.phone.Text = "Phone";
			// 
			// postalCode
			// 
			this.postalCode.AutoSize = true;
			this.postalCode.Location = new System.Drawing.Point(11, 180);
			this.postalCode.Name = "postalCode";
			this.postalCode.Size = new System.Drawing.Size(64, 13);
			this.postalCode.TabIndex = 40;
			this.postalCode.Text = "Postal Code";
			// 
			// country
			// 
			this.country.AutoSize = true;
			this.country.Location = new System.Drawing.Point(12, 214);
			this.country.Name = "country";
			this.country.Size = new System.Drawing.Size(43, 13);
			this.country.TabIndex = 39;
			this.country.Text = "Country";
			// 
			// city
			// 
			this.city.AutoSize = true;
			this.city.Location = new System.Drawing.Point(11, 143);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(24, 13);
			this.city.TabIndex = 38;
			this.city.Text = "City";
			// 
			// active
			// 
			this.active.AutoSize = true;
			this.active.Location = new System.Drawing.Point(12, 290);
			this.active.Name = "active";
			this.active.Size = new System.Drawing.Size(61, 13);
			this.active.TabIndex = 37;
			this.active.Text = "Active Cust";
			// 
			// address
			// 
			this.address.AutoSize = true;
			this.address.Location = new System.Drawing.Point(11, 103);
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(45, 13);
			this.address.TabIndex = 36;
			this.address.Text = "Address";
			// 
			// customerName
			// 
			this.customerName.AutoSize = true;
			this.customerName.Location = new System.Drawing.Point(11, 67);
			this.customerName.Name = "customerName";
			this.customerName.Size = new System.Drawing.Size(35, 13);
			this.customerName.TabIndex = 35;
			this.customerName.Text = "Name";
			// 
			// CountryTxt
			// 
			this.CountryTxt.Location = new System.Drawing.Point(93, 211);
			this.CountryTxt.Name = "CountryTxt";
			this.CountryTxt.ReadOnly = true;
			this.CountryTxt.Size = new System.Drawing.Size(100, 20);
			this.CountryTxt.TabIndex = 7;
			// 
			// ActiveTxt
			// 
			this.ActiveTxt.Location = new System.Drawing.Point(93, 287);
			this.ActiveTxt.Name = "ActiveTxt";
			this.ActiveTxt.ReadOnly = true;
			this.ActiveTxt.Size = new System.Drawing.Size(100, 20);
			this.ActiveTxt.TabIndex = 9;
			// 
			// DeleteCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(313, 375);
			this.Controls.Add(this.ActiveTxt);
			this.Controls.Add(this.CountryTxt);
			this.Controls.Add(this.SearchBtn);
			this.Controls.Add(this.SearchTxt);
			this.Controls.Add(this.search);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.PhoneTxt);
			this.Controls.Add(this.CityTxt);
			this.Controls.Add(this.AddressTxt);
			this.Controls.Add(this.NameTxt);
			this.Controls.Add(this.PostalCodeTxt);
			this.Controls.Add(this.phone);
			this.Controls.Add(this.postalCode);
			this.Controls.Add(this.country);
			this.Controls.Add(this.city);
			this.Controls.Add(this.active);
			this.Controls.Add(this.address);
			this.Controls.Add(this.customerName);
			this.Name = "DeleteCustomer";
			this.Text = "Delete Customer";
			this.ResumeLayout(false);
			this.PerformLayout();

					}

				#endregion

				private System.Windows.Forms.Button SearchBtn;
				private System.Windows.Forms.TextBox SearchTxt;
				private System.Windows.Forms.Label search;
				private System.Windows.Forms.Button ExitBtn;
				private System.Windows.Forms.Button DeleteBtn;
				private System.Windows.Forms.TextBox PhoneTxt;
				private System.Windows.Forms.TextBox CityTxt;
				private System.Windows.Forms.TextBox AddressTxt;
				private System.Windows.Forms.TextBox NameTxt;
				private System.Windows.Forms.TextBox PostalCodeTxt;
				private System.Windows.Forms.Label phone;
				private System.Windows.Forms.Label postalCode;
				private System.Windows.Forms.Label country;
				private System.Windows.Forms.Label city;
				private System.Windows.Forms.Label active;
				private System.Windows.Forms.Label address;
				private System.Windows.Forms.Label customerName;
		private System.Windows.Forms.TextBox CountryTxt;
		private System.Windows.Forms.TextBox ActiveTxt;
	}
	}