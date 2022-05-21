/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

namespace WGU_C969
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
			this.calendarGB = new System.Windows.Forms.GroupBox();
			this.DeleteApptBtn = new System.Windows.Forms.Button();
			this.EditApptBtn = new System.Windows.Forms.Button();
			this.message = new System.Windows.Forms.Label();
			this.monthlyCalendar = new System.Windows.Forms.RadioButton();
			this.weeklyCalendar = new System.Windows.Forms.RadioButton();
			this.calendarDGV = new System.Windows.Forms.DataGridView();
			this.AddApptBtn = new System.Windows.Forms.Button();
			this.calendar = new System.Windows.Forms.Label();
			this.customersGB = new System.Windows.Forms.GroupBox();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.UpdateBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.customers = new System.Windows.Forms.Label();
			this.reportsGB = new System.Windows.Forms.GroupBox();
			this.ReportCustomer = new System.Windows.Forms.Button();
			this.reports = new System.Windows.Forms.Label();
			this.ReportConsultant = new System.Windows.Forms.Button();
			this.ReportApptMonth = new System.Windows.Forms.Button();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.calendarGB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.calendarDGV)).BeginInit();
			this.customersGB.SuspendLayout();
			this.reportsGB.SuspendLayout();
			this.SuspendLayout();
			// 
			// calendarGB
			// 
			this.calendarGB.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.calendarGB.Controls.Add(this.DeleteApptBtn);
			this.calendarGB.Controls.Add(this.EditApptBtn);
			this.calendarGB.Controls.Add(this.message);
			this.calendarGB.Controls.Add(this.monthlyCalendar);
			this.calendarGB.Controls.Add(this.weeklyCalendar);
			this.calendarGB.Controls.Add(this.calendarDGV);
			this.calendarGB.Controls.Add(this.AddApptBtn);
			this.calendarGB.Controls.Add(this.calendar);
			this.calendarGB.Location = new System.Drawing.Point(7, 15);
			this.calendarGB.Margin = new System.Windows.Forms.Padding(2);
			this.calendarGB.Name = "calendarGB";
			this.calendarGB.Padding = new System.Windows.Forms.Padding(2);
			this.calendarGB.Size = new System.Drawing.Size(1137, 420);
			this.calendarGB.TabIndex = 0;
			this.calendarGB.TabStop = false;
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
			this.message.AutoSize = true;
			this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.message.Location = new System.Drawing.Point(457, 71);
			this.message.Name = "message";
			this.message.Size = new System.Drawing.Size(300, 16);
			this.message.TabIndex = 5;
			this.message.Text = "Showing appointments for the next 7 days";
			// 
			// monthlyCalendar
			// 
			this.monthlyCalendar.AutoSize = true;
			this.monthlyCalendar.Location = new System.Drawing.Point(621, 49);
			this.monthlyCalendar.Margin = new System.Windows.Forms.Padding(2);
			this.monthlyCalendar.Name = "monthlyCalendar";
			this.monthlyCalendar.Size = new System.Drawing.Size(62, 17);
			this.monthlyCalendar.TabIndex = 4;
			this.monthlyCalendar.Text = "Monthly";
			this.monthlyCalendar.UseVisualStyleBackColor = true;
			this.monthlyCalendar.CheckedChanged += new System.EventHandler(this.monthlyCalendar_CheckedChanged);
			// 
			// weeklyCalendar
			// 
			this.weeklyCalendar.AutoSize = true;
			this.weeklyCalendar.Checked = true;
			this.weeklyCalendar.Location = new System.Drawing.Point(499, 49);
			this.weeklyCalendar.Margin = new System.Windows.Forms.Padding(2);
			this.weeklyCalendar.Name = "weeklyCalendar";
			this.weeklyCalendar.Size = new System.Drawing.Size(61, 17);
			this.weeklyCalendar.TabIndex = 3;
			this.weeklyCalendar.TabStop = true;
			this.weeklyCalendar.Text = "Weekly";
			this.weeklyCalendar.UseVisualStyleBackColor = true;
			this.weeklyCalendar.CheckedChanged += new System.EventHandler(this.weeklyCalendar_CheckedChanged);
			// 
			// calendarDGV
			// 
			this.calendarDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.calendarDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.calendarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.calendarDGV.Location = new System.Drawing.Point(354, 92);
			this.calendarDGV.Margin = new System.Windows.Forms.Padding(2);
			this.calendarDGV.Name = "calendarDGV";
			this.calendarDGV.RowHeadersWidth = 72;
			this.calendarDGV.RowTemplate.Height = 31;
			this.calendarDGV.Size = new System.Drawing.Size(484, 280);
			this.calendarDGV.TabIndex = 2;
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
			this.calendar.AutoSize = true;
			this.calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calendar.Location = new System.Drawing.Point(490, 7);
			this.calendar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.calendar.Name = "calendar";
			this.calendar.Size = new System.Drawing.Size(200, 31);
			this.calendar.TabIndex = 0;
			this.calendar.Text = "Appt Calendar";
			// 
			// customersGB
			// 
			this.customersGB.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.customersGB.Controls.Add(this.DeleteBtn);
			this.customersGB.Controls.Add(this.UpdateBtn);
			this.customersGB.Controls.Add(this.AddBtn);
			this.customersGB.Controls.Add(this.customers);
			this.customersGB.Location = new System.Drawing.Point(605, 445);
			this.customersGB.Margin = new System.Windows.Forms.Padding(2);
			this.customersGB.Name = "customersGB";
			this.customersGB.Padding = new System.Windows.Forms.Padding(2);
			this.customersGB.Size = new System.Drawing.Size(299, 133);
			this.customersGB.TabIndex = 1;
			this.customersGB.TabStop = false;
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
			this.customers.AutoSize = true;
			this.customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customers.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.customers.Location = new System.Drawing.Point(72, 7);
			this.customers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.customers.Name = "customers";
			this.customers.Size = new System.Drawing.Size(149, 31);
			this.customers.TabIndex = 0;
			this.customers.Text = "customers";
			// 
			// reportsGB
			// 
			this.reportsGB.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.reportsGB.Controls.Add(this.ReportCustomer);
			this.reportsGB.Controls.Add(this.reports);
			this.reportsGB.Controls.Add(this.ReportConsultant);
			this.reportsGB.Controls.Add(this.ReportApptMonth);
			this.reportsGB.Location = new System.Drawing.Point(288, 445);
			this.reportsGB.Margin = new System.Windows.Forms.Padding(2);
			this.reportsGB.Name = "reportsGB";
			this.reportsGB.Padding = new System.Windows.Forms.Padding(2);
			this.reportsGB.Size = new System.Drawing.Size(308, 133);
			this.reportsGB.TabIndex = 2;
			this.reportsGB.TabStop = false;
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
			this.reports.AutoSize = true;
			this.reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reports.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.reports.Location = new System.Drawing.Point(112, 7);
			this.reports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.reports.Name = "reports";
			this.reports.Size = new System.Drawing.Size(106, 31);
			this.reports.TabIndex = 4;
			this.reports.Text = "reports";
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
			this.Controls.Add(this.reportsGB);
			this.Controls.Add(this.customersGB);
			this.Controls.Add(this.calendarGB);
			this.Name = "Scheduling";
			this.Text = "Scheduling";
			this.calendarGB.ResumeLayout(false);
			this.calendarGB.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.calendarDGV)).EndInit();
			this.customersGB.ResumeLayout(false);
			this.customersGB.PerformLayout();
			this.reportsGB.ResumeLayout(false);
			this.reportsGB.PerformLayout();
			this.ResumeLayout(false);

					}

				#endregion

				private System.Windows.Forms.GroupBox calendarGB;
				private System.Windows.Forms.GroupBox customersGB;
				private System.Windows.Forms.GroupBox reportsGB;
				private System.Windows.Forms.Button DeleteBtn;
				private System.Windows.Forms.Button UpdateBtn;
				private System.Windows.Forms.Button AddBtn;
				private System.Windows.Forms.Label calendar;
				private System.Windows.Forms.Label message;
				private System.Windows.Forms.RadioButton monthlyCalendar;
				private System.Windows.Forms.RadioButton weeklyCalendar;
				private System.Windows.Forms.DataGridView calendarDGV;
				private System.Windows.Forms.Button AddApptBtn;
				private System.Windows.Forms.Button ExitBtn;
				private System.Windows.Forms.Button ReportApptMonth;
				private System.Windows.Forms.Label customers;
				private System.Windows.Forms.Label reports;
				private System.Windows.Forms.Button ReportConsultant;
				private System.Windows.Forms.Button ReportCustomer;
		private System.Windows.Forms.Button EditApptBtn;
		private System.Windows.Forms.Button DeleteApptBtn;
	}
	}