
namespace DentalOfficeSchedulingApp
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
			this.SelectCombo = new System.Windows.Forms.ComboBox();
			this.SelectLbl = new System.Windows.Forms.Label();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.NoRadio = new System.Windows.Forms.RadioButton();
			this.YesRadio = new System.Windows.Forms.RadioButton();
			this.PhoneTxt = new System.Windows.Forms.TextBox();
			this.CountryTxt = new System.Windows.Forms.TextBox();
			this.ZipCodeTxt = new System.Windows.Forms.TextBox();
			this.CityTxt = new System.Windows.Forms.TextBox();
			this.AddressTxt = new System.Windows.Forms.TextBox();
			this.NameTxt = new System.Windows.Forms.TextBox();
			this.ActiveLbl = new System.Windows.Forms.Label();
			this.PhoneLbl = new System.Windows.Forms.Label();
			this.CountryLbl = new System.Windows.Forms.Label();
			this.ZipCodeLbl = new System.Windows.Forms.Label();
			this.CityLbl = new System.Windows.Forms.Label();
			this.AddressLbl = new System.Windows.Forms.Label();
			this.NameLbl = new System.Windows.Forms.Label();
			this.TitleLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SelectCombo
			// 
			this.SelectCombo.FormattingEnabled = true;
			this.SelectCombo.Location = new System.Drawing.Point(136, 41);
			this.SelectCombo.Name = "SelectCombo";
			this.SelectCombo.Size = new System.Drawing.Size(121, 21);
			this.SelectCombo.TabIndex = 0;
			this.SelectCombo.Text = "--Select--";
			this.SelectCombo.SelectedValueChanged += new System.EventHandler(this.SelectCombo_SelectedValueChanged);
			// 
			// SelectLbl
			// 
			this.SelectLbl.AutoSize = true;
			this.SelectLbl.Location = new System.Drawing.Point(46, 44);
			this.SelectLbl.Name = "SelectLbl";
			this.SelectLbl.Size = new System.Drawing.Size(84, 13);
			this.SelectLbl.TabIndex = 56;
			this.SelectLbl.Text = "Select Customer";
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(165, 347);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 55;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Location = new System.Drawing.Point(66, 347);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
			this.DeleteBtn.TabIndex = 54;
			this.DeleteBtn.Text = "Delete";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// NoRadio
			// 
			this.NoRadio.AutoSize = true;
			this.NoRadio.Enabled = false;
			this.NoRadio.Location = new System.Drawing.Point(192, 311);
			this.NoRadio.Name = "NoRadio";
			this.NoRadio.Size = new System.Drawing.Size(39, 17);
			this.NoRadio.TabIndex = 53;
			this.NoRadio.TabStop = true;
			this.NoRadio.Text = "No";
			this.NoRadio.UseVisualStyleBackColor = true;
			// 
			// YesRadio
			// 
			this.YesRadio.AutoSize = true;
			this.YesRadio.Enabled = false;
			this.YesRadio.Location = new System.Drawing.Point(136, 311);
			this.YesRadio.Name = "YesRadio";
			this.YesRadio.Size = new System.Drawing.Size(43, 17);
			this.YesRadio.TabIndex = 52;
			this.YesRadio.TabStop = true;
			this.YesRadio.Text = "Yes";
			this.YesRadio.UseVisualStyleBackColor = true;
			// 
			// PhoneTxt
			// 
			this.PhoneTxt.Enabled = false;
			this.PhoneTxt.Location = new System.Drawing.Point(136, 279);
			this.PhoneTxt.Name = "PhoneTxt";
			this.PhoneTxt.Size = new System.Drawing.Size(100, 20);
			this.PhoneTxt.TabIndex = 51;
			this.PhoneTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTxt_KeyPress);
			// 
			// CountryTxt
			// 
			this.CountryTxt.Enabled = false;
			this.CountryTxt.Location = new System.Drawing.Point(136, 238);
			this.CountryTxt.Name = "CountryTxt";
			this.CountryTxt.Size = new System.Drawing.Size(100, 20);
			this.CountryTxt.TabIndex = 50;
			this.CountryTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryTxt_KeyPress);
			// 
			// ZipCodeTxt
			// 
			this.ZipCodeTxt.Enabled = false;
			this.ZipCodeTxt.Location = new System.Drawing.Point(136, 200);
			this.ZipCodeTxt.Name = "ZipCodeTxt";
			this.ZipCodeTxt.Size = new System.Drawing.Size(100, 20);
			this.ZipCodeTxt.TabIndex = 49;
			this.ZipCodeTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipCodeTxt_KeyPress);
			// 
			// CityTxt
			// 
			this.CityTxt.Enabled = false;
			this.CityTxt.Location = new System.Drawing.Point(136, 164);
			this.CityTxt.Name = "CityTxt";
			this.CityTxt.Size = new System.Drawing.Size(100, 20);
			this.CityTxt.TabIndex = 48;
			this.CityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityTxt_KeyPress);
			// 
			// AddressTxt
			// 
			this.AddressTxt.Enabled = false;
			this.AddressTxt.Location = new System.Drawing.Point(136, 129);
			this.AddressTxt.Name = "AddressTxt";
			this.AddressTxt.Size = new System.Drawing.Size(100, 20);
			this.AddressTxt.TabIndex = 47;
			this.AddressTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTxt_KeyPress);
			// 
			// NameTxt
			// 
			this.NameTxt.Enabled = false;
			this.NameTxt.Location = new System.Drawing.Point(136, 90);
			this.NameTxt.Name = "NameTxt";
			this.NameTxt.Size = new System.Drawing.Size(100, 20);
			this.NameTxt.TabIndex = 46;
			this.NameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTxt_KeyPress);
			// 
			// ActiveLbl
			// 
			this.ActiveLbl.AutoSize = true;
			this.ActiveLbl.Location = new System.Drawing.Point(46, 315);
			this.ActiveLbl.Name = "ActiveLbl";
			this.ActiveLbl.Size = new System.Drawing.Size(37, 13);
			this.ActiveLbl.TabIndex = 45;
			this.ActiveLbl.Text = "Active";
			// 
			// PhoneLbl
			// 
			this.PhoneLbl.AutoSize = true;
			this.PhoneLbl.Location = new System.Drawing.Point(46, 282);
			this.PhoneLbl.Name = "PhoneLbl";
			this.PhoneLbl.Size = new System.Drawing.Size(38, 13);
			this.PhoneLbl.TabIndex = 44;
			this.PhoneLbl.Text = "Phone";
			// 
			// CountryLbl
			// 
			this.CountryLbl.AutoSize = true;
			this.CountryLbl.Location = new System.Drawing.Point(46, 241);
			this.CountryLbl.Name = "CountryLbl";
			this.CountryLbl.Size = new System.Drawing.Size(43, 13);
			this.CountryLbl.TabIndex = 43;
			this.CountryLbl.Text = "Country";
			// 
			// ZipCodeLbl
			// 
			this.ZipCodeLbl.AutoSize = true;
			this.ZipCodeLbl.Location = new System.Drawing.Point(46, 203);
			this.ZipCodeLbl.Name = "ZipCodeLbl";
			this.ZipCodeLbl.Size = new System.Drawing.Size(50, 13);
			this.ZipCodeLbl.TabIndex = 42;
			this.ZipCodeLbl.Text = "Zip Code";
			// 
			// CityLbl
			// 
			this.CityLbl.AutoSize = true;
			this.CityLbl.Location = new System.Drawing.Point(46, 167);
			this.CityLbl.Name = "CityLbl";
			this.CityLbl.Size = new System.Drawing.Size(24, 13);
			this.CityLbl.TabIndex = 41;
			this.CityLbl.Text = "City";
			// 
			// AddressLbl
			// 
			this.AddressLbl.AutoSize = true;
			this.AddressLbl.Location = new System.Drawing.Point(46, 132);
			this.AddressLbl.Name = "AddressLbl";
			this.AddressLbl.Size = new System.Drawing.Size(45, 13);
			this.AddressLbl.TabIndex = 40;
			this.AddressLbl.Text = "Address";
			// 
			// NameLbl
			// 
			this.NameLbl.AutoSize = true;
			this.NameLbl.Location = new System.Drawing.Point(46, 93);
			this.NameLbl.Name = "NameLbl";
			this.NameLbl.Size = new System.Drawing.Size(35, 13);
			this.NameLbl.TabIndex = 39;
			this.NameLbl.Text = "Name";
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Location = new System.Drawing.Point(82, 9);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(136, 13);
			this.TitleLbl.TabIndex = 38;
			this.TitleLbl.Text = "Select a customer to delete";
			// 
			// DeleteCustomer
			// 
			this.AcceptButton = this.DeleteBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 396);
			this.Controls.Add(this.SelectCombo);
			this.Controls.Add(this.SelectLbl);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.DeleteBtn);
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
			this.Name = "DeleteCustomer";
			this.Text = "Sunshine Dental - Delete Customer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox SelectCombo;
		private System.Windows.Forms.Label SelectLbl;
		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.RadioButton NoRadio;
		private System.Windows.Forms.RadioButton YesRadio;
		private System.Windows.Forms.TextBox PhoneTxt;
		private System.Windows.Forms.TextBox CountryTxt;
		private System.Windows.Forms.TextBox ZipCodeTxt;
		private System.Windows.Forms.TextBox CityTxt;
		private System.Windows.Forms.TextBox AddressTxt;
		private System.Windows.Forms.TextBox NameTxt;
		private System.Windows.Forms.Label ActiveLbl;
		private System.Windows.Forms.Label PhoneLbl;
		private System.Windows.Forms.Label CountryLbl;
		private System.Windows.Forms.Label ZipCodeLbl;
		private System.Windows.Forms.Label CityLbl;
		private System.Windows.Forms.Label AddressLbl;
		private System.Windows.Forms.Label NameLbl;
		private System.Windows.Forms.Label TitleLbl;
	}
}