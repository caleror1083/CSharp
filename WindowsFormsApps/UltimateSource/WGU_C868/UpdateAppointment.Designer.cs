
namespace WGU_C868
{
	partial class UpdateAppointment
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
			this.TypeCombo = new System.Windows.Forms.ComboBox();
			this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.LocationTxt = new System.Windows.Forms.TextBox();
			this.TitleLbl = new System.Windows.Forms.Label();
			this.EndTimeLbl = new System.Windows.Forms.Label();
			this.StartTimeLbl = new System.Windows.Forms.Label();
			this.TypeLbl = new System.Windows.Forms.Label();
			this.LocationLbl = new System.Windows.Forms.Label();
			this.ContactLbl = new System.Windows.Forms.Label();
			this.DescriptionLbl = new System.Windows.Forms.Label();
			this.AppointmentLbl = new System.Windows.Forms.Label();
			this.SelectCustomerLbl = new System.Windows.Forms.Label();
			this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.DescriptionTxt = new System.Windows.Forms.TextBox();
			this.ContactTxt = new System.Windows.Forms.TextBox();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.AppointmentTxt = new System.Windows.Forms.TextBox();
			this.CustomerCombo = new System.Windows.Forms.ComboBox();
			this.UpdateBtn = new System.Windows.Forms.Button();
			this.SelectAppointmentLbl = new System.Windows.Forms.Label();
			this.AppointmentCombo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// TypeCombo
			// 
			this.TypeCombo.FormattingEnabled = true;
			this.TypeCombo.Items.AddRange(new object[] {
            "Cleaning",
            "Cavities",
            "Wisdom Teeth",
            "Consultation",
            "Root Canal",
            "Other"});
			this.TypeCombo.Location = new System.Drawing.Point(123, 281);
			this.TypeCombo.Name = "TypeCombo";
			this.TypeCombo.Size = new System.Drawing.Size(251, 21);
			this.TypeCombo.TabIndex = 86;
			// 
			// StartDateTimePicker
			// 
			this.StartDateTimePicker.Checked = false;
			this.StartDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
			this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.StartDateTimePicker.Location = new System.Drawing.Point(123, 307);
			this.StartDateTimePicker.Name = "StartDateTimePicker";
			this.StartDateTimePicker.Size = new System.Drawing.Size(251, 20);
			this.StartDateTimePicker.TabIndex = 85;
			// 
			// LocationTxt
			// 
			this.LocationTxt.Location = new System.Drawing.Point(123, 227);
			this.LocationTxt.Name = "LocationTxt";
			this.LocationTxt.Size = new System.Drawing.Size(251, 20);
			this.LocationTxt.TabIndex = 84;
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Location = new System.Drawing.Point(93, 13);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(216, 13);
			this.TitleLbl.TabIndex = 83;
			this.TitleLbl.Text = "Select a customer to update an appointment";
			// 
			// EndTimeLbl
			// 
			this.EndTimeLbl.AutoSize = true;
			this.EndTimeLbl.Location = new System.Drawing.Point(12, 345);
			this.EndTimeLbl.Name = "EndTimeLbl";
			this.EndTimeLbl.Size = new System.Drawing.Size(52, 13);
			this.EndTimeLbl.TabIndex = 82;
			this.EndTimeLbl.Text = "End Time";
			// 
			// StartTimeLbl
			// 
			this.StartTimeLbl.AutoSize = true;
			this.StartTimeLbl.Location = new System.Drawing.Point(9, 315);
			this.StartTimeLbl.Name = "StartTimeLbl";
			this.StartTimeLbl.Size = new System.Drawing.Size(55, 13);
			this.StartTimeLbl.TabIndex = 81;
			this.StartTimeLbl.Text = "Start Time";
			// 
			// TypeLbl
			// 
			this.TypeLbl.AutoSize = true;
			this.TypeLbl.Location = new System.Drawing.Point(9, 285);
			this.TypeLbl.Name = "TypeLbl";
			this.TypeLbl.Size = new System.Drawing.Size(31, 13);
			this.TypeLbl.TabIndex = 80;
			this.TypeLbl.Text = "Type";
			// 
			// LocationLbl
			// 
			this.LocationLbl.AutoSize = true;
			this.LocationLbl.Location = new System.Drawing.Point(9, 223);
			this.LocationLbl.Name = "LocationLbl";
			this.LocationLbl.Size = new System.Drawing.Size(48, 13);
			this.LocationLbl.TabIndex = 79;
			this.LocationLbl.Text = "Location";
			// 
			// ContactLbl
			// 
			this.ContactLbl.AutoSize = true;
			this.ContactLbl.Location = new System.Drawing.Point(9, 257);
			this.ContactLbl.Name = "ContactLbl";
			this.ContactLbl.Size = new System.Drawing.Size(44, 13);
			this.ContactLbl.TabIndex = 78;
			this.ContactLbl.Text = "Contact";
			// 
			// DescriptionLbl
			// 
			this.DescriptionLbl.AutoSize = true;
			this.DescriptionLbl.Location = new System.Drawing.Point(9, 138);
			this.DescriptionLbl.Name = "DescriptionLbl";
			this.DescriptionLbl.Size = new System.Drawing.Size(60, 13);
			this.DescriptionLbl.TabIndex = 77;
			this.DescriptionLbl.Text = "Description";
			// 
			// AppointmentLbl
			// 
			this.AppointmentLbl.AutoSize = true;
			this.AppointmentLbl.Location = new System.Drawing.Point(9, 115);
			this.AppointmentLbl.Name = "AppointmentLbl";
			this.AppointmentLbl.Size = new System.Drawing.Size(97, 13);
			this.AppointmentLbl.TabIndex = 76;
			this.AppointmentLbl.Text = "Appointment Name";
			// 
			// SelectCustomerLbl
			// 
			this.SelectCustomerLbl.AutoSize = true;
			this.SelectCustomerLbl.Location = new System.Drawing.Point(9, 50);
			this.SelectCustomerLbl.Name = "SelectCustomerLbl";
			this.SelectCustomerLbl.Size = new System.Drawing.Size(84, 13);
			this.SelectCustomerLbl.TabIndex = 75;
			this.SelectCustomerLbl.Text = "Select Customer";
			// 
			// EndDateTimePicker
			// 
			this.EndDateTimePicker.Checked = false;
			this.EndDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
			this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.EndDateTimePicker.Location = new System.Drawing.Point(123, 339);
			this.EndDateTimePicker.Name = "EndDateTimePicker";
			this.EndDateTimePicker.Size = new System.Drawing.Size(251, 20);
			this.EndDateTimePicker.TabIndex = 74;
			// 
			// DescriptionTxt
			// 
			this.DescriptionTxt.Location = new System.Drawing.Point(123, 138);
			this.DescriptionTxt.Multiline = true;
			this.DescriptionTxt.Name = "DescriptionTxt";
			this.DescriptionTxt.Size = new System.Drawing.Size(251, 82);
			this.DescriptionTxt.TabIndex = 73;
			// 
			// ContactTxt
			// 
			this.ContactTxt.Location = new System.Drawing.Point(123, 254);
			this.ContactTxt.Name = "ContactTxt";
			this.ContactTxt.Size = new System.Drawing.Size(251, 20);
			this.ContactTxt.TabIndex = 72;
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(225, 388);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 71;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// AppointmentTxt
			// 
			this.AppointmentTxt.Location = new System.Drawing.Point(123, 112);
			this.AppointmentTxt.Name = "AppointmentTxt";
			this.AppointmentTxt.Size = new System.Drawing.Size(251, 20);
			this.AppointmentTxt.TabIndex = 70;
			// 
			// CustomerCombo
			// 
			this.CustomerCombo.FormattingEnabled = true;
			this.CustomerCombo.Location = new System.Drawing.Point(123, 47);
			this.CustomerCombo.Name = "CustomerCombo";
			this.CustomerCombo.Size = new System.Drawing.Size(251, 21);
			this.CustomerCombo.TabIndex = 0;
			this.CustomerCombo.Text = "--Select--";
			this.CustomerCombo.SelectedValueChanged += new System.EventHandler(this.CustomerCombo_SelectedValueChanged);
			// 
			// UpdateBtn
			// 
			this.UpdateBtn.Location = new System.Drawing.Point(102, 388);
			this.UpdateBtn.Name = "UpdateBtn";
			this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
			this.UpdateBtn.TabIndex = 69;
			this.UpdateBtn.Text = "Update";
			this.UpdateBtn.UseVisualStyleBackColor = true;
			this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
			// 
			// SelectAppointmentLbl
			// 
			this.SelectAppointmentLbl.AutoSize = true;
			this.SelectAppointmentLbl.Location = new System.Drawing.Point(9, 79);
			this.SelectAppointmentLbl.Name = "SelectAppointmentLbl";
			this.SelectAppointmentLbl.Size = new System.Drawing.Size(99, 13);
			this.SelectAppointmentLbl.TabIndex = 87;
			this.SelectAppointmentLbl.Text = "Select Appointment";
			// 
			// AppointmentCombo
			// 
			this.AppointmentCombo.FormattingEnabled = true;
			this.AppointmentCombo.Location = new System.Drawing.Point(123, 79);
			this.AppointmentCombo.Name = "AppointmentCombo";
			this.AppointmentCombo.Size = new System.Drawing.Size(251, 21);
			this.AppointmentCombo.TabIndex = 1;
			this.AppointmentCombo.Text = "--Select--";
			this.AppointmentCombo.SelectedValueChanged += new System.EventHandler(this.AppointmentCombo_SelectedValueChanged);
			// 
			// UpdateAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(433, 437);
			this.Controls.Add(this.AppointmentCombo);
			this.Controls.Add(this.SelectAppointmentLbl);
			this.Controls.Add(this.TypeCombo);
			this.Controls.Add(this.StartDateTimePicker);
			this.Controls.Add(this.LocationTxt);
			this.Controls.Add(this.TitleLbl);
			this.Controls.Add(this.EndTimeLbl);
			this.Controls.Add(this.StartTimeLbl);
			this.Controls.Add(this.TypeLbl);
			this.Controls.Add(this.LocationLbl);
			this.Controls.Add(this.ContactLbl);
			this.Controls.Add(this.DescriptionLbl);
			this.Controls.Add(this.AppointmentLbl);
			this.Controls.Add(this.SelectCustomerLbl);
			this.Controls.Add(this.EndDateTimePicker);
			this.Controls.Add(this.DescriptionTxt);
			this.Controls.Add(this.ContactTxt);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.AppointmentTxt);
			this.Controls.Add(this.CustomerCombo);
			this.Controls.Add(this.UpdateBtn);
			this.Name = "UpdateAppointment";
			this.Text = "Sunshine Dental - Update Appointment";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox TypeCombo;
		private System.Windows.Forms.DateTimePicker StartDateTimePicker;
		private System.Windows.Forms.TextBox LocationTxt;
		private System.Windows.Forms.Label TitleLbl;
		private System.Windows.Forms.Label EndTimeLbl;
		private System.Windows.Forms.Label StartTimeLbl;
		private System.Windows.Forms.Label TypeLbl;
		private System.Windows.Forms.Label LocationLbl;
		private System.Windows.Forms.Label ContactLbl;
		private System.Windows.Forms.Label DescriptionLbl;
		private System.Windows.Forms.Label AppointmentLbl;
		private System.Windows.Forms.Label SelectCustomerLbl;
		private System.Windows.Forms.DateTimePicker EndDateTimePicker;
		private System.Windows.Forms.TextBox DescriptionTxt;
		private System.Windows.Forms.TextBox ContactTxt;
		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.TextBox AppointmentTxt;
		private System.Windows.Forms.ComboBox CustomerCombo;
		private System.Windows.Forms.Button UpdateBtn;
		private System.Windows.Forms.Label SelectAppointmentLbl;
		private System.Windows.Forms.ComboBox AppointmentCombo;
	}
}