
namespace DentalOfficeSchedulingApp
{
	partial class DeleteAppointment
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
			this.AppointmentCombo = new System.Windows.Forms.ComboBox();
			this.SelectAppointmentLbl = new System.Windows.Forms.Label();
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
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AppointmentCombo
			// 
			this.AppointmentCombo.FormattingEnabled = true;
			this.AppointmentCombo.Location = new System.Drawing.Point(121, 72);
			this.AppointmentCombo.Name = "AppointmentCombo";
			this.AppointmentCombo.Size = new System.Drawing.Size(251, 21);
			this.AppointmentCombo.TabIndex = 89;
			this.AppointmentCombo.Text = "--Select--";
			this.AppointmentCombo.SelectedValueChanged += new System.EventHandler(this.AppointmentCombo_SelectedValueChanged);
			// 
			// SelectAppointmentLbl
			// 
			this.SelectAppointmentLbl.AutoSize = true;
			this.SelectAppointmentLbl.Location = new System.Drawing.Point(7, 72);
			this.SelectAppointmentLbl.Name = "SelectAppointmentLbl";
			this.SelectAppointmentLbl.Size = new System.Drawing.Size(99, 13);
			this.SelectAppointmentLbl.TabIndex = 108;
			this.SelectAppointmentLbl.Text = "Select Appointment";
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
			this.TypeCombo.Location = new System.Drawing.Point(121, 274);
			this.TypeCombo.Name = "TypeCombo";
			this.TypeCombo.Size = new System.Drawing.Size(251, 21);
			this.TypeCombo.TabIndex = 107;
			// 
			// StartDateTimePicker
			// 
			this.StartDateTimePicker.Checked = false;
			this.StartDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
			this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.StartDateTimePicker.Location = new System.Drawing.Point(121, 300);
			this.StartDateTimePicker.Name = "StartDateTimePicker";
			this.StartDateTimePicker.Size = new System.Drawing.Size(251, 20);
			this.StartDateTimePicker.TabIndex = 106;
			// 
			// LocationTxt
			// 
			this.LocationTxt.Location = new System.Drawing.Point(121, 220);
			this.LocationTxt.Name = "LocationTxt";
			this.LocationTxt.Size = new System.Drawing.Size(251, 20);
			this.LocationTxt.TabIndex = 105;
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Location = new System.Drawing.Point(79, 9);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(227, 13);
			this.TitleLbl.TabIndex = 104;
			this.TitleLbl.Text = "Select a customer to delete an appointment for";
			// 
			// EndTimeLbl
			// 
			this.EndTimeLbl.AutoSize = true;
			this.EndTimeLbl.Location = new System.Drawing.Point(10, 338);
			this.EndTimeLbl.Name = "EndTimeLbl";
			this.EndTimeLbl.Size = new System.Drawing.Size(52, 13);
			this.EndTimeLbl.TabIndex = 103;
			this.EndTimeLbl.Text = "End Time";
			// 
			// StartTimeLbl
			// 
			this.StartTimeLbl.AutoSize = true;
			this.StartTimeLbl.Location = new System.Drawing.Point(7, 308);
			this.StartTimeLbl.Name = "StartTimeLbl";
			this.StartTimeLbl.Size = new System.Drawing.Size(55, 13);
			this.StartTimeLbl.TabIndex = 102;
			this.StartTimeLbl.Text = "Start Time";
			// 
			// TypeLbl
			// 
			this.TypeLbl.AutoSize = true;
			this.TypeLbl.Location = new System.Drawing.Point(7, 278);
			this.TypeLbl.Name = "TypeLbl";
			this.TypeLbl.Size = new System.Drawing.Size(31, 13);
			this.TypeLbl.TabIndex = 101;
			this.TypeLbl.Text = "Type";
			// 
			// LocationLbl
			// 
			this.LocationLbl.AutoSize = true;
			this.LocationLbl.Location = new System.Drawing.Point(7, 216);
			this.LocationLbl.Name = "LocationLbl";
			this.LocationLbl.Size = new System.Drawing.Size(48, 13);
			this.LocationLbl.TabIndex = 100;
			this.LocationLbl.Text = "Location";
			// 
			// ContactLbl
			// 
			this.ContactLbl.AutoSize = true;
			this.ContactLbl.Location = new System.Drawing.Point(7, 250);
			this.ContactLbl.Name = "ContactLbl";
			this.ContactLbl.Size = new System.Drawing.Size(44, 13);
			this.ContactLbl.TabIndex = 99;
			this.ContactLbl.Text = "Contact";
			// 
			// DescriptionLbl
			// 
			this.DescriptionLbl.AutoSize = true;
			this.DescriptionLbl.Location = new System.Drawing.Point(7, 131);
			this.DescriptionLbl.Name = "DescriptionLbl";
			this.DescriptionLbl.Size = new System.Drawing.Size(60, 13);
			this.DescriptionLbl.TabIndex = 98;
			this.DescriptionLbl.Text = "Description";
			// 
			// AppointmentLbl
			// 
			this.AppointmentLbl.AutoSize = true;
			this.AppointmentLbl.Location = new System.Drawing.Point(7, 108);
			this.AppointmentLbl.Name = "AppointmentLbl";
			this.AppointmentLbl.Size = new System.Drawing.Size(97, 13);
			this.AppointmentLbl.TabIndex = 97;
			this.AppointmentLbl.Text = "Appointment Name";
			// 
			// SelectCustomerLbl
			// 
			this.SelectCustomerLbl.AutoSize = true;
			this.SelectCustomerLbl.Location = new System.Drawing.Point(7, 43);
			this.SelectCustomerLbl.Name = "SelectCustomerLbl";
			this.SelectCustomerLbl.Size = new System.Drawing.Size(84, 13);
			this.SelectCustomerLbl.TabIndex = 96;
			this.SelectCustomerLbl.Text = "Select Customer";
			// 
			// EndDateTimePicker
			// 
			this.EndDateTimePicker.Checked = false;
			this.EndDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
			this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.EndDateTimePicker.Location = new System.Drawing.Point(121, 332);
			this.EndDateTimePicker.Name = "EndDateTimePicker";
			this.EndDateTimePicker.Size = new System.Drawing.Size(251, 20);
			this.EndDateTimePicker.TabIndex = 95;
			// 
			// DescriptionTxt
			// 
			this.DescriptionTxt.Location = new System.Drawing.Point(121, 131);
			this.DescriptionTxt.Multiline = true;
			this.DescriptionTxt.Name = "DescriptionTxt";
			this.DescriptionTxt.Size = new System.Drawing.Size(251, 82);
			this.DescriptionTxt.TabIndex = 94;
			// 
			// ContactTxt
			// 
			this.ContactTxt.Location = new System.Drawing.Point(121, 247);
			this.ContactTxt.Name = "ContactTxt";
			this.ContactTxt.Size = new System.Drawing.Size(251, 20);
			this.ContactTxt.TabIndex = 93;
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(223, 381);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 92;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// AppointmentTxt
			// 
			this.AppointmentTxt.Location = new System.Drawing.Point(121, 105);
			this.AppointmentTxt.Name = "AppointmentTxt";
			this.AppointmentTxt.Size = new System.Drawing.Size(251, 20);
			this.AppointmentTxt.TabIndex = 91;
			// 
			// CustomerCombo
			// 
			this.CustomerCombo.FormattingEnabled = true;
			this.CustomerCombo.Location = new System.Drawing.Point(121, 40);
			this.CustomerCombo.Name = "CustomerCombo";
			this.CustomerCombo.Size = new System.Drawing.Size(251, 21);
			this.CustomerCombo.TabIndex = 88;
			this.CustomerCombo.Text = "--Select--";
			this.CustomerCombo.SelectedValueChanged += new System.EventHandler(this.CustomerCombo_SelectedValueChanged);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Location = new System.Drawing.Point(100, 381);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
			this.DeleteBtn.TabIndex = 90;
			this.DeleteBtn.Text = "Delete";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// DeleteAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 430);
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
			this.Controls.Add(this.DeleteBtn);
			this.Name = "DeleteAppointment";
			this.Text = "Sunshine Dental - Delete Appointment";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox AppointmentCombo;
		private System.Windows.Forms.Label SelectAppointmentLbl;
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
		private System.Windows.Forms.Button DeleteBtn;
	}
}