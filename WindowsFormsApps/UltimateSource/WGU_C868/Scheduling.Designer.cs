
namespace WGU_C868
{
	partial class Scheduling
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
			this.CalendarPanel = new System.Windows.Forms.Panel();
			this.CalendarDGV = new System.Windows.Forms.DataGridView();
			this.RefreshBtn = new System.Windows.Forms.Button();
			this.MonthlyCalendar = new System.Windows.Forms.RadioButton();
			this.Calendar = new System.Windows.Forms.Label();
			this.WeeklyCalendar = new System.Windows.Forms.RadioButton();
			this.CustomersPanel = new System.Windows.Forms.Panel();
			this.DeleteCustBtn = new System.Windows.Forms.Button();
			this.UpdateCustBtn = new System.Windows.Forms.Button();
			this.AddCustBtn = new System.Windows.Forms.Button();
			this.Customers = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.DeleteApptBtn = new System.Windows.Forms.Button();
			this.UpdateApptBtn = new System.Windows.Forms.Button();
			this.AddApptBtn = new System.Windows.Forms.Button();
			this.Appointments = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ReportAppointmentType = new System.Windows.Forms.Button();
			this.ReportAppointmentMonth = new System.Windows.Forms.Button();
			this.Reports = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.AppointmentsByConsultant = new System.Windows.Forms.Button();
			this.AppointmentsByCustomer = new System.Windows.Forms.Button();
			this.Search = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.DeleteUserBtn = new System.Windows.Forms.Button();
			this.UpdateUserBtn = new System.Windows.Forms.Button();
			this.AddUserBtn = new System.Windows.Forms.Button();
			this.Users = new System.Windows.Forms.Label();
			this.CalendarPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CalendarDGV)).BeginInit();
			this.CustomersPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// CalendarPanel
			// 
			this.CalendarPanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.CalendarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CalendarPanel.Controls.Add(this.CalendarDGV);
			this.CalendarPanel.Controls.Add(this.RefreshBtn);
			this.CalendarPanel.Controls.Add(this.MonthlyCalendar);
			this.CalendarPanel.Controls.Add(this.Calendar);
			this.CalendarPanel.Controls.Add(this.WeeklyCalendar);
			this.CalendarPanel.Location = new System.Drawing.Point(7, 15);
			this.CalendarPanel.Name = "CalendarPanel";
			this.CalendarPanel.Size = new System.Drawing.Size(1137, 420);
			this.CalendarPanel.TabIndex = 0;
			// 
			// CalendarDGV
			// 
			this.CalendarDGV.AllowUserToOrderColumns = true;
			this.CalendarDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.CalendarDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.CalendarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CalendarDGV.Location = new System.Drawing.Point(304, 92);
			this.CalendarDGV.Name = "CalendarDGV";
			this.CalendarDGV.RowHeadersWidth = 45;
			this.CalendarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.CalendarDGV.Size = new System.Drawing.Size(604, 318);
			this.CalendarDGV.TabIndex = 4;
			// 
			// RefreshBtn
			// 
			this.RefreshBtn.Location = new System.Drawing.Point(688, 47);
			this.RefreshBtn.Name = "RefreshBtn";
			this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
			this.RefreshBtn.TabIndex = 3;
			this.RefreshBtn.Text = "Refresh";
			this.RefreshBtn.UseVisualStyleBackColor = true;
			this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
			// 
			// MonthlyCalendar
			// 
			this.MonthlyCalendar.AutoSize = true;
			this.MonthlyCalendar.Location = new System.Drawing.Point(585, 49);
			this.MonthlyCalendar.Name = "MonthlyCalendar";
			this.MonthlyCalendar.Size = new System.Drawing.Size(62, 17);
			this.MonthlyCalendar.TabIndex = 2;
			this.MonthlyCalendar.TabStop = true;
			this.MonthlyCalendar.Text = "Monthly";
			this.MonthlyCalendar.UseVisualStyleBackColor = true;
			// 
			// Calendar
			// 
			this.Calendar.AutoSize = true;
			this.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.Calendar.Location = new System.Drawing.Point(459, 7);
			this.Calendar.Name = "Calendar";
			this.Calendar.Size = new System.Drawing.Size(303, 31);
			this.Calendar.TabIndex = 1;
			this.Calendar.Text = "Appointment Calendar";
			// 
			// WeeklyCalendar
			// 
			this.WeeklyCalendar.AutoSize = true;
			this.WeeklyCalendar.Checked = true;
			this.WeeklyCalendar.Location = new System.Drawing.Point(468, 49);
			this.WeeklyCalendar.Name = "WeeklyCalendar";
			this.WeeklyCalendar.Size = new System.Drawing.Size(61, 17);
			this.WeeklyCalendar.TabIndex = 0;
			this.WeeklyCalendar.TabStop = true;
			this.WeeklyCalendar.Text = "Weekly";
			this.WeeklyCalendar.UseVisualStyleBackColor = true;
			this.WeeklyCalendar.CheckedChanged += new System.EventHandler(this.WeeklyCalendar_CheckedChanged);
			// 
			// CustomersPanel
			// 
			this.CustomersPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.CustomersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CustomersPanel.Controls.Add(this.DeleteCustBtn);
			this.CustomersPanel.Controls.Add(this.UpdateCustBtn);
			this.CustomersPanel.Controls.Add(this.AddCustBtn);
			this.CustomersPanel.Controls.Add(this.Customers);
			this.CustomersPanel.Location = new System.Drawing.Point(7, 445);
			this.CustomersPanel.Name = "CustomersPanel";
			this.CustomersPanel.Size = new System.Drawing.Size(299, 133);
			this.CustomersPanel.TabIndex = 1;
			// 
			// DeleteCustBtn
			// 
			this.DeleteCustBtn.Location = new System.Drawing.Point(200, 61);
			this.DeleteCustBtn.Name = "DeleteCustBtn";
			this.DeleteCustBtn.Size = new System.Drawing.Size(57, 31);
			this.DeleteCustBtn.TabIndex = 3;
			this.DeleteCustBtn.Text = "Delete";
			this.DeleteCustBtn.UseVisualStyleBackColor = true;
			this.DeleteCustBtn.Click += new System.EventHandler(this.DeleteCustBtn_Click);
			// 
			// UpdateCustBtn
			// 
			this.UpdateCustBtn.Location = new System.Drawing.Point(121, 61);
			this.UpdateCustBtn.Name = "UpdateCustBtn";
			this.UpdateCustBtn.Size = new System.Drawing.Size(57, 31);
			this.UpdateCustBtn.TabIndex = 2;
			this.UpdateCustBtn.Text = "Update";
			this.UpdateCustBtn.UseVisualStyleBackColor = true;
			this.UpdateCustBtn.Click += new System.EventHandler(this.UpdateCustBtn_Click);
			// 
			// AddCustBtn
			// 
			this.AddCustBtn.Location = new System.Drawing.Point(30, 61);
			this.AddCustBtn.Name = "AddCustBtn";
			this.AddCustBtn.Size = new System.Drawing.Size(57, 31);
			this.AddCustBtn.TabIndex = 1;
			this.AddCustBtn.Text = "Add";
			this.AddCustBtn.UseVisualStyleBackColor = true;
			this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
			// 
			// Customers
			// 
			this.Customers.AutoSize = true;
			this.Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Customers.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Customers.Location = new System.Drawing.Point(72, 7);
			this.Customers.Name = "Customers";
			this.Customers.Size = new System.Drawing.Size(155, 31);
			this.Customers.TabIndex = 0;
			this.Customers.Text = "Customers";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.DeleteApptBtn);
			this.panel1.Controls.Add(this.UpdateApptBtn);
			this.panel1.Controls.Add(this.AddApptBtn);
			this.panel1.Controls.Add(this.Appointments);
			this.panel1.Location = new System.Drawing.Point(312, 445);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(299, 133);
			this.panel1.TabIndex = 2;
			// 
			// DeleteApptBtn
			// 
			this.DeleteApptBtn.Location = new System.Drawing.Point(220, 61);
			this.DeleteApptBtn.Name = "DeleteApptBtn";
			this.DeleteApptBtn.Size = new System.Drawing.Size(57, 31);
			this.DeleteApptBtn.TabIndex = 3;
			this.DeleteApptBtn.Text = "Delete";
			this.DeleteApptBtn.UseVisualStyleBackColor = true;
			this.DeleteApptBtn.Click += new System.EventHandler(this.DeleteApptBtn_Click);
			// 
			// UpdateApptBtn
			// 
			this.UpdateApptBtn.Location = new System.Drawing.Point(141, 61);
			this.UpdateApptBtn.Name = "UpdateApptBtn";
			this.UpdateApptBtn.Size = new System.Drawing.Size(57, 31);
			this.UpdateApptBtn.TabIndex = 2;
			this.UpdateApptBtn.Text = "Update";
			this.UpdateApptBtn.UseVisualStyleBackColor = true;
			this.UpdateApptBtn.Click += new System.EventHandler(this.UpdateApptBtn_Click);
			// 
			// AddApptBtn
			// 
			this.AddApptBtn.Location = new System.Drawing.Point(50, 61);
			this.AddApptBtn.Name = "AddApptBtn";
			this.AddApptBtn.Size = new System.Drawing.Size(57, 31);
			this.AddApptBtn.TabIndex = 1;
			this.AddApptBtn.Text = "Add";
			this.AddApptBtn.UseVisualStyleBackColor = true;
			this.AddApptBtn.Click += new System.EventHandler(this.AddApptBtn_Click);
			// 
			// Appointments
			// 
			this.Appointments.AutoSize = true;
			this.Appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Appointments.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Appointments.Location = new System.Drawing.Point(72, 7);
			this.Appointments.Name = "Appointments";
			this.Appointments.Size = new System.Drawing.Size(192, 31);
			this.Appointments.TabIndex = 0;
			this.Appointments.Text = "Appointments";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.ReportAppointmentType);
			this.panel2.Controls.Add(this.ReportAppointmentMonth);
			this.panel2.Controls.Add(this.Reports);
			this.panel2.Location = new System.Drawing.Point(922, 445);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(222, 133);
			this.panel2.TabIndex = 3;
			// 
			// ReportAppointmentType
			// 
			this.ReportAppointmentType.Location = new System.Drawing.Point(119, 61);
			this.ReportAppointmentType.Name = "ReportAppointmentType";
			this.ReportAppointmentType.Size = new System.Drawing.Size(68, 42);
			this.ReportAppointmentType.TabIndex = 2;
			this.ReportAppointmentType.Text = "Appts by Type";
			this.ReportAppointmentType.UseVisualStyleBackColor = true;
			this.ReportAppointmentType.Click += new System.EventHandler(this.ReportAppointmentType_Click);
			// 
			// ReportAppointmentMonth
			// 
			this.ReportAppointmentMonth.Location = new System.Drawing.Point(30, 61);
			this.ReportAppointmentMonth.Name = "ReportAppointmentMonth";
			this.ReportAppointmentMonth.Size = new System.Drawing.Size(68, 42);
			this.ReportAppointmentMonth.TabIndex = 1;
			this.ReportAppointmentMonth.Text = "Appts by Month";
			this.ReportAppointmentMonth.UseVisualStyleBackColor = true;
			this.ReportAppointmentMonth.Click += new System.EventHandler(this.ReportAppointmentMonth_Click);
			// 
			// Reports
			// 
			this.Reports.AutoSize = true;
			this.Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Reports.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Reports.Location = new System.Drawing.Point(51, 7);
			this.Reports.Name = "Reports";
			this.Reports.Size = new System.Drawing.Size(117, 31);
			this.Reports.TabIndex = 0;
			this.Reports.Text = "Reports";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.AppointmentsByConsultant);
			this.panel3.Controls.Add(this.AppointmentsByCustomer);
			this.panel3.Controls.Add(this.Search);
			this.panel3.Location = new System.Drawing.Point(617, 445);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(299, 133);
			this.panel3.TabIndex = 4;
			// 
			// AppointmentsByConsultant
			// 
			this.AppointmentsByConsultant.Location = new System.Drawing.Point(154, 61);
			this.AppointmentsByConsultant.Name = "AppointmentsByConsultant";
			this.AppointmentsByConsultant.Size = new System.Drawing.Size(85, 42);
			this.AppointmentsByConsultant.TabIndex = 2;
			this.AppointmentsByConsultant.Text = "Appts by User";
			this.AppointmentsByConsultant.UseVisualStyleBackColor = true;
			this.AppointmentsByConsultant.Click += new System.EventHandler(this.AppointmentsByConsultant_Click);
			// 
			// AppointmentsByCustomer
			// 
			this.AppointmentsByCustomer.Location = new System.Drawing.Point(39, 61);
			this.AppointmentsByCustomer.Name = "AppointmentsByCustomer";
			this.AppointmentsByCustomer.Size = new System.Drawing.Size(85, 42);
			this.AppointmentsByCustomer.TabIndex = 1;
			this.AppointmentsByCustomer.Text = "Appts by Customer";
			this.AppointmentsByCustomer.UseVisualStyleBackColor = true;
			this.AppointmentsByCustomer.Click += new System.EventHandler(this.AppointmentsByCustomer_Click);
			// 
			// Search
			// 
			this.Search.AutoSize = true;
			this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Search.Location = new System.Drawing.Point(87, 7);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(106, 31);
			this.Search.TabIndex = 0;
			this.Search.Text = "Search";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.DeleteUserBtn);
			this.panel4.Controls.Add(this.UpdateUserBtn);
			this.panel4.Controls.Add(this.AddUserBtn);
			this.panel4.Controls.Add(this.Users);
			this.panel4.Location = new System.Drawing.Point(479, 584);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(263, 133);
			this.panel4.TabIndex = 5;
			// 
			// DeleteUserBtn
			// 
			this.DeleteUserBtn.Location = new System.Drawing.Point(184, 61);
			this.DeleteUserBtn.Name = "DeleteUserBtn";
			this.DeleteUserBtn.Size = new System.Drawing.Size(57, 31);
			this.DeleteUserBtn.TabIndex = 3;
			this.DeleteUserBtn.Text = "Delete";
			this.DeleteUserBtn.UseVisualStyleBackColor = true;
			this.DeleteUserBtn.Click += new System.EventHandler(this.DeleteUserBtn_Click);
			// 
			// UpdateUserBtn
			// 
			this.UpdateUserBtn.Location = new System.Drawing.Point(105, 61);
			this.UpdateUserBtn.Name = "UpdateUserBtn";
			this.UpdateUserBtn.Size = new System.Drawing.Size(57, 31);
			this.UpdateUserBtn.TabIndex = 2;
			this.UpdateUserBtn.Text = "Update";
			this.UpdateUserBtn.UseVisualStyleBackColor = true;
			this.UpdateUserBtn.Click += new System.EventHandler(this.UpdateUserBtn_Click);
			// 
			// AddUserBtn
			// 
			this.AddUserBtn.Location = new System.Drawing.Point(29, 61);
			this.AddUserBtn.Name = "AddUserBtn";
			this.AddUserBtn.Size = new System.Drawing.Size(57, 31);
			this.AddUserBtn.TabIndex = 1;
			this.AddUserBtn.Text = "Add";
			this.AddUserBtn.UseVisualStyleBackColor = true;
			this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
			// 
			// Users
			// 
			this.Users.AutoSize = true;
			this.Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Users.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Users.Location = new System.Drawing.Point(81, 13);
			this.Users.Name = "Users";
			this.Users.Size = new System.Drawing.Size(91, 31);
			this.Users.TabIndex = 0;
			this.Users.Text = "Users";
			// 
			// Scheduling
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1148, 722);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.CustomersPanel);
			this.Controls.Add(this.CalendarPanel);
			this.Name = "Scheduling";
			this.Text = "Sunshine Dental - Scheduling";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Scheduling_FormClosing);
			this.CalendarPanel.ResumeLayout(false);
			this.CalendarPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CalendarDGV)).EndInit();
			this.CustomersPanel.ResumeLayout(false);
			this.CustomersPanel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel CalendarPanel;
		private System.Windows.Forms.Button RefreshBtn;
		private System.Windows.Forms.RadioButton MonthlyCalendar;
		private System.Windows.Forms.Label Calendar;
		private System.Windows.Forms.RadioButton WeeklyCalendar;
		private System.Windows.Forms.DataGridView CalendarDGV;
		private System.Windows.Forms.Panel CustomersPanel;
		private System.Windows.Forms.Button DeleteCustBtn;
		private System.Windows.Forms.Button UpdateCustBtn;
		private System.Windows.Forms.Button AddCustBtn;
		private System.Windows.Forms.Label Customers;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button DeleteApptBtn;
		private System.Windows.Forms.Button UpdateApptBtn;
		private System.Windows.Forms.Button AddApptBtn;
		private System.Windows.Forms.Label Appointments;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button ReportAppointmentType;
		private System.Windows.Forms.Button ReportAppointmentMonth;
		private System.Windows.Forms.Label Reports;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button AppointmentsByConsultant;
		private System.Windows.Forms.Button AppointmentsByCustomer;
		private System.Windows.Forms.Label Search;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button DeleteUserBtn;
		private System.Windows.Forms.Button UpdateUserBtn;
		private System.Windows.Forms.Button AddUserBtn;
		private System.Windows.Forms.Label Users;
	}
}