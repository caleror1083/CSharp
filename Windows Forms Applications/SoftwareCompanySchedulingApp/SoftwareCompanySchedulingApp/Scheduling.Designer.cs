/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

namespace SoftwareCompanySchedulingApp
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
			this.CalendarGB = new System.Windows.Forms.GroupBox();
			this.DeleteApptBtn = new System.Windows.Forms.Button();
			this.EditApptBtn = new System.Windows.Forms.Button();
			this.Message = new System.Windows.Forms.Label();
			this.MonthlyCalendar = new System.Windows.Forms.RadioButton();
			this.WeeklyCalendar = new System.Windows.Forms.RadioButton();
			this.CalendarDGV = new System.Windows.Forms.DataGridView();
			this.AddApptBtn = new System.Windows.Forms.Button();
			this.Calendar = new System.Windows.Forms.Label();
			this.CustomersGB = new System.Windows.Forms.GroupBox();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.UpdateBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.Customers = new System.Windows.Forms.Label();
			this.ReportsGB = new System.Windows.Forms.GroupBox();
			this.ReportCustomer = new System.Windows.Forms.Button();
			this.Reports = new System.Windows.Forms.Label();
			this.ReportConsultant = new System.Windows.Forms.Button();
			this.ReportApptMonth = new System.Windows.Forms.Button();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.CalendarGB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CalendarDGV)).BeginInit();
			this.CustomersGB.SuspendLayout();
			this.ReportsGB.SuspendLayout();
			this.SuspendLayout();
			// 
			// calendarGB
			// 
			this.CalendarGB.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.CalendarGB.Controls.Add(this.DeleteApptBtn);
			this.CalendarGB.Controls.Add(this.EditApptBtn);
			this.CalendarGB.Controls.Add(this.Message);
			this.CalendarGB.Controls.Add(this.MonthlyCalendar);
			this.CalendarGB.Controls.Add(this.WeeklyCalendar);
			this.CalendarGB.Controls.Add(this.CalendarDGV);
			this.CalendarGB.Controls.Add(this.AddApptBtn);
			this.CalendarGB.Controls.Add(this.Calendar);
			this.CalendarGB.Location = new System.Drawing.Point(7, 15);
			this.CalendarGB.Margin = new System.Windows.Forms.Padding(2);
			this.CalendarGB.Name = "calendarGB";
			this.CalendarGB.Padding = new System.Windows.Forms.Padding(2);
			this.CalendarGB.Size = new System.Drawing.Size(1137, 420);
			this.CalendarGB.TabIndex = 0;
			this.CalendarGB.TabStop = false;
			// 
			// DeleteApptBtn
			// 
			this.DeleteApptBtn.Location = new System.Drawing.Point(645, 381);
			this.DeleteApptBtn.Margin = new System.Windows.Forms.Padding(2);
			this.DeleteApptBtn.Name = "DeleteApptBtn";
			this.DeleteApptBtn.Size = new System.Drawing.Size(57, 31);
			this.DeleteApptBtn.TabIndex = 7;
			this.DeleteApptBtn.Text = "Delete";
			this.DeleteApptBtn.UseVisualStyleBackColor = true;
			this.DeleteApptBtn.Click += new System.EventHandler(this.DeleteApptBtn_Click);
			// 
			// EditApptBtn
			// 
			this.EditApptBtn.Location = new System.Drawing.Point(565, 381);
			this.EditApptBtn.Margin = new System.Windows.Forms.Padding(2);
			this.EditApptBtn.Name = "EditApptBtn";
			this.EditApptBtn.Size = new System.Drawing.Size(57, 31);
			this.EditApptBtn.TabIndex = 6;
			this.EditApptBtn.Text = "Update";
			this.EditApptBtn.UseVisualStyleBackColor = true;
			this.EditApptBtn.Click += new System.EventHandler(this.UpdateApptBtn_Click);
			// 
			// message
			// 
			this.Message.AutoSize = true;
			this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Message.Location = new System.Drawing.Point(457, 71);
			this.Message.Name = "message";
			this.Message.Size = new System.Drawing.Size(300, 16);
			this.Message.TabIndex = 5;
			this.Message.Text = "Showing appointments for the next 7 days";
			// 
			// monthlyCalendar
			// 
			this.MonthlyCalendar.AutoSize = true;
			this.MonthlyCalendar.Location = new System.Drawing.Point(621, 49);
			this.MonthlyCalendar.Margin = new System.Windows.Forms.Padding(2);
			this.MonthlyCalendar.Name = "monthlyCalendar";
			this.MonthlyCalendar.Size = new System.Drawing.Size(62, 17);
			this.MonthlyCalendar.TabIndex = 4;
			this.MonthlyCalendar.Text = "Monthly";
			this.MonthlyCalendar.UseVisualStyleBackColor = true;
			this.MonthlyCalendar.CheckedChanged += new System.EventHandler(this.monthlyCalendar_CheckedChanged);
			// 
			// weeklyCalendar
			// 
			this.WeeklyCalendar.AutoSize = true;
			this.WeeklyCalendar.Checked = true;
			this.WeeklyCalendar.Location = new System.Drawing.Point(499, 49);
			this.WeeklyCalendar.Margin = new System.Windows.Forms.Padding(2);
			this.WeeklyCalendar.Name = "weeklyCalendar";
			this.WeeklyCalendar.Size = new System.Drawing.Size(61, 17);
			this.WeeklyCalendar.TabIndex = 3;
			this.WeeklyCalendar.TabStop = true;
			this.WeeklyCalendar.Text = "Weekly";
			this.WeeklyCalendar.UseVisualStyleBackColor = true;
			this.WeeklyCalendar.CheckedChanged += new System.EventHandler(this.weeklyCalendar_CheckedChanged);
			// 
			// calendarDGV
			// 
			this.CalendarDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.CalendarDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.CalendarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CalendarDGV.Location = new System.Drawing.Point(354, 92);
			this.CalendarDGV.Margin = new System.Windows.Forms.Padding(2);
			this.CalendarDGV.Name = "calendarDGV";
			this.CalendarDGV.RowHeadersWidth = 72;
			this.CalendarDGV.RowTemplate.Height = 31;
			this.CalendarDGV.Size = new System.Drawing.Size(484, 280);
			this.CalendarDGV.TabIndex = 2;
			// 
			// AddApptBtn
			// 
			this.AddApptBtn.Location = new System.Drawing.Point(477, 381);
			this.AddApptBtn.Margin = new System.Windows.Forms.Padding(2);
			this.AddApptBtn.Name = "AddApptBtn";
			this.AddApptBtn.Size = new System.Drawing.Size(57, 31);
			this.AddApptBtn.TabIndex = 1;
			this.AddApptBtn.Text = "Add";
			this.AddApptBtn.UseVisualStyleBackColor = true;
			this.AddApptBtn.Click += new System.EventHandler(this.AddApptBtn_Click);
			// 
			// calendar
			// 
			this.Calendar.AutoSize = true;
			this.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Calendar.Location = new System.Drawing.Point(490, 7);
			this.Calendar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Calendar.Name = "calendar";
			this.Calendar.Size = new System.Drawing.Size(200, 31);
			this.Calendar.TabIndex = 0;
			this.Calendar.Text = "Appt Calendar";
			// 
			// customersGB
			// 
			this.CustomersGB.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.CustomersGB.Controls.Add(this.DeleteBtn);
			this.CustomersGB.Controls.Add(this.UpdateBtn);
			this.CustomersGB.Controls.Add(this.AddBtn);
			this.CustomersGB.Controls.Add(this.Customers);
			this.CustomersGB.Location = new System.Drawing.Point(605, 445);
			this.CustomersGB.Margin = new System.Windows.Forms.Padding(2);
			this.CustomersGB.Name = "customersGB";
			this.CustomersGB.Padding = new System.Windows.Forms.Padding(2);
			this.CustomersGB.Size = new System.Drawing.Size(299, 133);
			this.CustomersGB.TabIndex = 1;
			this.CustomersGB.TabStop = false;
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Location = new System.Drawing.Point(200, 61);
			this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(57, 31);
			this.DeleteBtn.TabIndex = 3;
			this.DeleteBtn.Text = "Delete";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// UpdateBtn
			// 
			this.UpdateBtn.Location = new System.Drawing.Point(121, 61);
			this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2);
			this.UpdateBtn.Name = "UpdateBtn";
			this.UpdateBtn.Size = new System.Drawing.Size(57, 31);
			this.UpdateBtn.TabIndex = 2;
			this.UpdateBtn.Text = "Update";
			this.UpdateBtn.UseVisualStyleBackColor = true;
			this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(30, 61);
			this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(57, 31);
			this.AddBtn.TabIndex = 1;
			this.AddBtn.Text = "Add";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// customers
			// 
			this.Customers.AutoSize = true;
			this.Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Customers.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Customers.Location = new System.Drawing.Point(72, 7);
			this.Customers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Customers.Name = "customers";
			this.Customers.Size = new System.Drawing.Size(149, 31);
			this.Customers.TabIndex = 0;
			this.Customers.Text = "customers";
			// 
			// reportsGB
			// 
			this.ReportsGB.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ReportsGB.Controls.Add(this.ReportCustomer);
			this.ReportsGB.Controls.Add(this.Reports);
			this.ReportsGB.Controls.Add(this.ReportConsultant);
			this.ReportsGB.Controls.Add(this.ReportApptMonth);
			this.ReportsGB.Location = new System.Drawing.Point(288, 445);
			this.ReportsGB.Margin = new System.Windows.Forms.Padding(2);
			this.ReportsGB.Name = "reportsGB";
			this.ReportsGB.Padding = new System.Windows.Forms.Padding(2);
			this.ReportsGB.Size = new System.Drawing.Size(308, 133);
			this.ReportsGB.TabIndex = 2;
			this.ReportsGB.TabStop = false;
			// 
			// ReportCustomer
			// 
			this.ReportCustomer.Location = new System.Drawing.Point(219, 53);
			this.ReportCustomer.Name = "ReportCustomer";
			this.ReportCustomer.Size = new System.Drawing.Size(84, 55);
			this.ReportCustomer.TabIndex = 5;
			this.ReportCustomer.Text = "Appointments by Customer";
			this.ReportCustomer.UseVisualStyleBackColor = true;
			this.ReportCustomer.Click += new System.EventHandler(this.ReportShort_Click);
			// 
			// reports
			// 
			this.Reports.AutoSize = true;
			this.Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Reports.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Reports.Location = new System.Drawing.Point(112, 7);
			this.Reports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Reports.Name = "reports";
			this.Reports.Size = new System.Drawing.Size(106, 31);
			this.Reports.TabIndex = 4;
			this.Reports.Text = "reports";
			// 
			// ReportConsultant
			// 
			this.ReportConsultant.Location = new System.Drawing.Point(120, 53);
			this.ReportConsultant.Name = "ReportConsultant";
			this.ReportConsultant.Size = new System.Drawing.Size(84, 55);
			this.ReportConsultant.TabIndex = 1;
			this.ReportConsultant.Text = "Consultant Schedules";
			this.ReportConsultant.UseVisualStyleBackColor = true;
			this.ReportConsultant.Click += new System.EventHandler(this.ReportConsultant_Click);
			// 
			// ReportApptMonth
			// 
			this.ReportApptMonth.Location = new System.Drawing.Point(14, 53);
			this.ReportApptMonth.Name = "ReportApptMonth";
			this.ReportApptMonth.Size = new System.Drawing.Size(84, 55);
			this.ReportApptMonth.TabIndex = 0;
			this.ReportApptMonth.Text = "Appointment types by month";
			this.ReportApptMonth.UseVisualStyleBackColor = true;
			this.ReportApptMonth.Click += new System.EventHandler(this.ReportApptMonth_Click);
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(1009, 506);
			this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(57, 31);
			this.ExitBtn.TabIndex = 3;
			this.ExitBtn.Text = "Exit";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// Scheduling
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1148, 581);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.ReportsGB);
			this.Controls.Add(this.CustomersGB);
			this.Controls.Add(this.CalendarGB);
			this.Name = "Scheduling";
			this.Text = "Scheduling";
			this.CalendarGB.ResumeLayout(false);
			this.CalendarGB.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CalendarDGV)).EndInit();
			this.CustomersGB.ResumeLayout(false);
			this.CustomersGB.PerformLayout();
			this.ReportsGB.ResumeLayout(false);
			this.ReportsGB.PerformLayout();
			this.ResumeLayout(false);

					}

				#endregion

				private System.Windows.Forms.GroupBox CalendarGB;
				private System.Windows.Forms.GroupBox CustomersGB;
				private System.Windows.Forms.GroupBox ReportsGB;
				private System.Windows.Forms.Button DeleteBtn;
				private System.Windows.Forms.Button UpdateBtn;
				private System.Windows.Forms.Button AddBtn;
				private System.Windows.Forms.Label Calendar;
				private System.Windows.Forms.Label Message;
				private System.Windows.Forms.RadioButton MonthlyCalendar;
				private System.Windows.Forms.RadioButton WeeklyCalendar;
				private System.Windows.Forms.DataGridView CalendarDGV;
				private System.Windows.Forms.Button AddApptBtn;
				private System.Windows.Forms.Button ExitBtn;
				private System.Windows.Forms.Button ReportApptMonth;
				private System.Windows.Forms.Label Customers;
				private System.Windows.Forms.Label Reports;
				private System.Windows.Forms.Button ReportConsultant;
				private System.Windows.Forms.Button ReportCustomer;
		private System.Windows.Forms.Button EditApptBtn;
		private System.Windows.Forms.Button DeleteApptBtn;
	}
	}