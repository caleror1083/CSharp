
namespace DentalOfficeSchedulingApp
{
	partial class AddAppointment
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
			this.AddBtn = new System.Windows.Forms.Button();
			this.SelectCombo = new System.Windows.Forms.ComboBox();
			this.AppointmentTxt = new System.Windows.Forms.TextBox();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.ContactTxt = new System.Windows.Forms.TextBox();
			this.DescriptionTxt = new System.Windows.Forms.TextBox();
			this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.SelectLbl = new System.Windows.Forms.Label();
			this.AppointmentLbl = new System.Windows.Forms.Label();
			this.DescriptionLbl = new System.Windows.Forms.Label();
			this.ContactLbl = new System.Windows.Forms.Label();
			this.LocationLbl = new System.Windows.Forms.Label();
			this.TypeLbl = new System.Windows.Forms.Label();
			this.StartTimeLbl = new System.Windows.Forms.Label();
			this.EndTimeLbl = new System.Windows.Forms.Label();
			this.TitleLbl = new System.Windows.Forms.Label();
			this.LocationTxt = new System.Windows.Forms.TextBox();
			this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.TypeCombo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(80, 354);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 23);
			this.AddBtn.TabIndex = 50;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// SelectCombo
			// 
			this.SelectCombo.FormattingEnabled = true;
			this.SelectCombo.Location = new System.Drawing.Point(142, 51);
			this.SelectCombo.Name = "SelectCombo";
			this.SelectCombo.Size = new System.Drawing.Size(200, 21);
			this.SelectCombo.TabIndex = 0;
			this.SelectCombo.Text = "--Select--";
			this.SelectCombo.SelectedValueChanged += new System.EventHandler(this.SelectCombo_SelectedValueChanged);
			// 
			// AppointmentTxt
			// 
			this.AppointmentTxt.Location = new System.Drawing.Point(142, 78);
			this.AppointmentTxt.Name = "AppointmentTxt";
			this.AppointmentTxt.Size = new System.Drawing.Size(200, 20);
			this.AppointmentTxt.TabIndex = 51;
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(203, 354);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 52;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// ContactTxt
			// 
			this.ContactTxt.Location = new System.Drawing.Point(142, 220);
			this.ContactTxt.Name = "ContactTxt";
			this.ContactTxt.Size = new System.Drawing.Size(200, 20);
			this.ContactTxt.TabIndex = 53;
			// 
			// DescriptionTxt
			// 
			this.DescriptionTxt.Location = new System.Drawing.Point(142, 104);
			this.DescriptionTxt.Multiline = true;
			this.DescriptionTxt.Name = "DescriptionTxt";
			this.DescriptionTxt.Size = new System.Drawing.Size(200, 82);
			this.DescriptionTxt.TabIndex = 54;
			// 
			// EndDateTimePicker
			// 
			this.EndDateTimePicker.Checked = false;
			this.EndDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
			this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.EndDateTimePicker.Location = new System.Drawing.Point(142, 305);
			this.EndDateTimePicker.Name = "EndDateTimePicker";
			this.EndDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.EndDateTimePicker.TabIndex = 55;
			// 
			// SelectLbl
			// 
			this.SelectLbl.AutoSize = true;
			this.SelectLbl.Location = new System.Drawing.Point(44, 54);
			this.SelectLbl.Name = "SelectLbl";
			this.SelectLbl.Size = new System.Drawing.Size(84, 13);
			this.SelectLbl.TabIndex = 56;
			this.SelectLbl.Text = "Select Customer";
			// 
			// AppointmentLbl
			// 
			this.AppointmentLbl.AutoSize = true;
			this.AppointmentLbl.Location = new System.Drawing.Point(44, 81);
			this.AppointmentLbl.Name = "AppointmentLbl";
			this.AppointmentLbl.Size = new System.Drawing.Size(97, 13);
			this.AppointmentLbl.TabIndex = 57;
			this.AppointmentLbl.Text = "Appointment Name";
			// 
			// DescriptionLbl
			// 
			this.DescriptionLbl.AutoSize = true;
			this.DescriptionLbl.Location = new System.Drawing.Point(44, 104);
			this.DescriptionLbl.Name = "DescriptionLbl";
			this.DescriptionLbl.Size = new System.Drawing.Size(60, 13);
			this.DescriptionLbl.TabIndex = 58;
			this.DescriptionLbl.Text = "Description";
			// 
			// ContactLbl
			// 
			this.ContactLbl.AutoSize = true;
			this.ContactLbl.Location = new System.Drawing.Point(44, 223);
			this.ContactLbl.Name = "ContactLbl";
			this.ContactLbl.Size = new System.Drawing.Size(44, 13);
			this.ContactLbl.TabIndex = 59;
			this.ContactLbl.Text = "Contact";
			// 
			// LocationLbl
			// 
			this.LocationLbl.AutoSize = true;
			this.LocationLbl.Location = new System.Drawing.Point(44, 189);
			this.LocationLbl.Name = "LocationLbl";
			this.LocationLbl.Size = new System.Drawing.Size(48, 13);
			this.LocationLbl.TabIndex = 60;
			this.LocationLbl.Text = "Location";
			// 
			// TypeLbl
			// 
			this.TypeLbl.AutoSize = true;
			this.TypeLbl.Location = new System.Drawing.Point(44, 251);
			this.TypeLbl.Name = "TypeLbl";
			this.TypeLbl.Size = new System.Drawing.Size(31, 13);
			this.TypeLbl.TabIndex = 61;
			this.TypeLbl.Text = "Type";
			// 
			// StartTimeLbl
			// 
			this.StartTimeLbl.AutoSize = true;
			this.StartTimeLbl.Location = new System.Drawing.Point(44, 281);
			this.StartTimeLbl.Name = "StartTimeLbl";
			this.StartTimeLbl.Size = new System.Drawing.Size(55, 13);
			this.StartTimeLbl.TabIndex = 62;
			this.StartTimeLbl.Text = "Start Time";
			// 
			// EndTimeLbl
			// 
			this.EndTimeLbl.AutoSize = true;
			this.EndTimeLbl.Location = new System.Drawing.Point(47, 311);
			this.EndTimeLbl.Name = "EndTimeLbl";
			this.EndTimeLbl.Size = new System.Drawing.Size(52, 13);
			this.EndTimeLbl.TabIndex = 63;
			this.EndTimeLbl.Text = "End Time";
			// 
			// TitleLbl
			// 
			this.TitleLbl.AutoSize = true;
			this.TitleLbl.Location = new System.Drawing.Point(82, 13);
			this.TitleLbl.Name = "TitleLbl";
			this.TitleLbl.Size = new System.Drawing.Size(213, 13);
			this.TitleLbl.TabIndex = 64;
			this.TitleLbl.Text = "Select a customer to create an appointment";
			// 
			// LocationTxt
			// 
			this.LocationTxt.Location = new System.Drawing.Point(142, 193);
			this.LocationTxt.Name = "LocationTxt";
			this.LocationTxt.Size = new System.Drawing.Size(200, 20);
			this.LocationTxt.TabIndex = 65;
			// 
			// StartDateTimePicker
			// 
			this.StartDateTimePicker.Checked = false;
			this.StartDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
			this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.StartDateTimePicker.Location = new System.Drawing.Point(142, 273);
			this.StartDateTimePicker.Name = "StartDateTimePicker";
			this.StartDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.StartDateTimePicker.TabIndex = 66;
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
			this.TypeCombo.Location = new System.Drawing.Point(142, 247);
			this.TypeCombo.Name = "TypeCombo";
			this.TypeCombo.Size = new System.Drawing.Size(200, 21);
			this.TypeCombo.TabIndex = 67;
			// 
			// AddAppointment
			// 
			this.AcceptButton = this.AddBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(380, 413);
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
			this.Controls.Add(this.SelectLbl);
			this.Controls.Add(this.EndDateTimePicker);
			this.Controls.Add(this.DescriptionTxt);
			this.Controls.Add(this.ContactTxt);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.AppointmentTxt);
			this.Controls.Add(this.SelectCombo);
			this.Controls.Add(this.AddBtn);
			this.Name = "AddAppointment";
			this.Text = "Sunshine Dental - Add Appointment";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddBtn;
		private System.Windows.Forms.ComboBox SelectCombo;
		private System.Windows.Forms.TextBox AppointmentTxt;
		private System.Windows.Forms.Button ExitBtn;
		private System.Windows.Forms.TextBox ContactTxt;
		private System.Windows.Forms.TextBox DescriptionTxt;
		private System.Windows.Forms.DateTimePicker EndDateTimePicker;
		private System.Windows.Forms.Label SelectLbl;
		private System.Windows.Forms.Label AppointmentLbl;
		private System.Windows.Forms.Label DescriptionLbl;
		private System.Windows.Forms.Label ContactLbl;
		private System.Windows.Forms.Label LocationLbl;
		private System.Windows.Forms.Label TypeLbl;
		private System.Windows.Forms.Label StartTimeLbl;
		private System.Windows.Forms.Label EndTimeLbl;
		private System.Windows.Forms.Label TitleLbl;
		private System.Windows.Forms.TextBox LocationTxt;
		private System.Windows.Forms.DateTimePicker StartDateTimePicker;
		private System.Windows.Forms.ComboBox TypeCombo;
	}
}