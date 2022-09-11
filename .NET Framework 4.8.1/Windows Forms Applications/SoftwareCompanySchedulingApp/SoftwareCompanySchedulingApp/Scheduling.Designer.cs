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
			this._CalendarGroupBox = new System.Windows.Forms.GroupBox();
			this._DeleteApptButton = new System.Windows.Forms.Button();
			this._UpdateApptButton = new System.Windows.Forms.Button();
			this._MessageLabel = new System.Windows.Forms.Label();
			this._MonthlyCalendarRadioButton = new System.Windows.Forms.RadioButton();
			this._WeeklyCalendarRadioButton = new System.Windows.Forms.RadioButton();
			this._CalendarDataGridView = new System.Windows.Forms.DataGridView();
			this._AddApptButton = new System.Windows.Forms.Button();
			this._CalendarLabel = new System.Windows.Forms.Label();
			this._CustomersGroupBox = new System.Windows.Forms.GroupBox();
			this._DeleteButton = new System.Windows.Forms.Button();
			this._UpdateButton = new System.Windows.Forms.Button();
			this._AddButton = new System.Windows.Forms.Button();
			this._CustomersLabel = new System.Windows.Forms.Label();
			this._ReportsGroupBox = new System.Windows.Forms.GroupBox();
			this._ReportCustomerButton = new System.Windows.Forms.Button();
			this._ReportsLabel = new System.Windows.Forms.Label();
			this._ReportConsultantButton = new System.Windows.Forms.Button();
			this._ReportApptMonthButton = new System.Windows.Forms.Button();
			this._ExitButton = new System.Windows.Forms.Button();
			this._CalendarGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._CalendarDataGridView)).BeginInit();
			this._CustomersGroupBox.SuspendLayout();
			this._ReportsGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// calendarGB
			// 
			this._CalendarGroupBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this._CalendarGroupBox.Controls.Add(this._DeleteApptButton);
			this._CalendarGroupBox.Controls.Add(this._UpdateApptButton);
			this._CalendarGroupBox.Controls.Add(this._MessageLabel);
			this._CalendarGroupBox.Controls.Add(this._MonthlyCalendarRadioButton);
			this._CalendarGroupBox.Controls.Add(this._WeeklyCalendarRadioButton);
			this._CalendarGroupBox.Controls.Add(this._CalendarDataGridView);
			this._CalendarGroupBox.Controls.Add(this._AddApptButton);
			this._CalendarGroupBox.Controls.Add(this._CalendarLabel);
			this._CalendarGroupBox.Location = new System.Drawing.Point(7, 15);
			this._CalendarGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this._CalendarGroupBox.Name = "calendarGB";
			this._CalendarGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this._CalendarGroupBox.Size = new System.Drawing.Size(1137, 420);
			this._CalendarGroupBox.TabIndex = 0;
			this._CalendarGroupBox.TabStop = false;
			// 
			// DeleteApptBtn
			// 
			this._DeleteApptButton.Location = new System.Drawing.Point(645, 381);
			this._DeleteApptButton.Margin = new System.Windows.Forms.Padding(2);
			this._DeleteApptButton.Name = "DeleteApptBtn";
			this._DeleteApptButton.Size = new System.Drawing.Size(57, 31);
			this._DeleteApptButton.TabIndex = 7;
			this._DeleteApptButton.Text = "Delete";
			this._DeleteApptButton.UseVisualStyleBackColor = true;
			this._DeleteApptButton.Click += new System.EventHandler(this.DeleteApptButton_Click);
			// 
			// EditApptBtn
			// 
			this._UpdateApptButton.Location = new System.Drawing.Point(565, 381);
			this._UpdateApptButton.Margin = new System.Windows.Forms.Padding(2);
			this._UpdateApptButton.Name = "EditApptBtn";
			this._UpdateApptButton.Size = new System.Drawing.Size(57, 31);
			this._UpdateApptButton.TabIndex = 6;
			this._UpdateApptButton.Text = "Update";
			this._UpdateApptButton.UseVisualStyleBackColor = true;
			this._UpdateApptButton.Click += new System.EventHandler(this.UpdateApptButton_Click);
			// 
			// message
			// 
			this._MessageLabel.AutoSize = true;
			this._MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._MessageLabel.Location = new System.Drawing.Point(457, 71);
			this._MessageLabel.Name = "message";
			this._MessageLabel.Size = new System.Drawing.Size(300, 16);
			this._MessageLabel.TabIndex = 5;
			this._MessageLabel.Text = "Showing appointments for the next 7 days";
			// 
			// monthlyCalendar
			// 
			this._MonthlyCalendarRadioButton.AutoSize = true;
			this._MonthlyCalendarRadioButton.Location = new System.Drawing.Point(621, 49);
			this._MonthlyCalendarRadioButton.Margin = new System.Windows.Forms.Padding(2);
			this._MonthlyCalendarRadioButton.Name = "monthlyCalendar";
			this._MonthlyCalendarRadioButton.Size = new System.Drawing.Size(62, 17);
			this._MonthlyCalendarRadioButton.TabIndex = 4;
			this._MonthlyCalendarRadioButton.Text = "Monthly";
			this._MonthlyCalendarRadioButton.UseVisualStyleBackColor = true;
			this._MonthlyCalendarRadioButton.CheckedChanged += new System.EventHandler(this.MonthlyCalendarRadioButton_CheckedChanged);
			// 
			// weeklyCalendar
			// 
			this._WeeklyCalendarRadioButton.AutoSize = true;
			this._WeeklyCalendarRadioButton.Checked = true;
			this._WeeklyCalendarRadioButton.Location = new System.Drawing.Point(499, 49);
			this._WeeklyCalendarRadioButton.Margin = new System.Windows.Forms.Padding(2);
			this._WeeklyCalendarRadioButton.Name = "weeklyCalendar";
			this._WeeklyCalendarRadioButton.Size = new System.Drawing.Size(61, 17);
			this._WeeklyCalendarRadioButton.TabIndex = 3;
			this._WeeklyCalendarRadioButton.TabStop = true;
			this._WeeklyCalendarRadioButton.Text = "Weekly";
			this._WeeklyCalendarRadioButton.UseVisualStyleBackColor = true;
			this._WeeklyCalendarRadioButton.CheckedChanged += new System.EventHandler(this.WeeklyCalendarRadioButton_CheckedChanged);
			// 
			// calendarDGV
			// 
			this._CalendarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this._CalendarDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this._CalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._CalendarDataGridView.Location = new System.Drawing.Point(354, 92);
			this._CalendarDataGridView.Margin = new System.Windows.Forms.Padding(2);
			this._CalendarDataGridView.Name = "calendarDGV";
			this._CalendarDataGridView.RowHeadersWidth = 72;
			this._CalendarDataGridView.RowTemplate.Height = 31;
			this._CalendarDataGridView.Size = new System.Drawing.Size(484, 280);
			this._CalendarDataGridView.TabIndex = 2;
			// 
			// AddApptBtn
			// 
			this._AddApptButton.Location = new System.Drawing.Point(477, 381);
			this._AddApptButton.Margin = new System.Windows.Forms.Padding(2);
			this._AddApptButton.Name = "AddApptBtn";
			this._AddApptButton.Size = new System.Drawing.Size(57, 31);
			this._AddApptButton.TabIndex = 1;
			this._AddApptButton.Text = "Add";
			this._AddApptButton.UseVisualStyleBackColor = true;
			this._AddApptButton.Click += new System.EventHandler(this.AddApptButton_Click);
			// 
			// calendar
			// 
			this._CalendarLabel.AutoSize = true;
			this._CalendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._CalendarLabel.Location = new System.Drawing.Point(490, 7);
			this._CalendarLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this._CalendarLabel.Name = "calendar";
			this._CalendarLabel.Size = new System.Drawing.Size(200, 31);
			this._CalendarLabel.TabIndex = 0;
			this._CalendarLabel.Text = "Appt Calendar";
			// 
			// customersGB
			// 
			this._CustomersGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this._CustomersGroupBox.Controls.Add(this._DeleteButton);
			this._CustomersGroupBox.Controls.Add(this._UpdateButton);
			this._CustomersGroupBox.Controls.Add(this._AddButton);
			this._CustomersGroupBox.Controls.Add(this._CustomersLabel);
			this._CustomersGroupBox.Location = new System.Drawing.Point(605, 445);
			this._CustomersGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this._CustomersGroupBox.Name = "customersGB";
			this._CustomersGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this._CustomersGroupBox.Size = new System.Drawing.Size(299, 133);
			this._CustomersGroupBox.TabIndex = 1;
			this._CustomersGroupBox.TabStop = false;
			// 
			// DeleteBtn
			// 
			this._DeleteButton.Location = new System.Drawing.Point(200, 61);
			this._DeleteButton.Margin = new System.Windows.Forms.Padding(2);
			this._DeleteButton.Name = "DeleteBtn";
			this._DeleteButton.Size = new System.Drawing.Size(57, 31);
			this._DeleteButton.TabIndex = 3;
			this._DeleteButton.Text = "Delete";
			this._DeleteButton.UseVisualStyleBackColor = true;
			this._DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// UpdateBtn
			// 
			this._UpdateButton.Location = new System.Drawing.Point(121, 61);
			this._UpdateButton.Margin = new System.Windows.Forms.Padding(2);
			this._UpdateButton.Name = "UpdateBtn";
			this._UpdateButton.Size = new System.Drawing.Size(57, 31);
			this._UpdateButton.TabIndex = 2;
			this._UpdateButton.Text = "Update";
			this._UpdateButton.UseVisualStyleBackColor = true;
			this._UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// AddBtn
			// 
			this._AddButton.Location = new System.Drawing.Point(30, 61);
			this._AddButton.Margin = new System.Windows.Forms.Padding(2);
			this._AddButton.Name = "AddBtn";
			this._AddButton.Size = new System.Drawing.Size(57, 31);
			this._AddButton.TabIndex = 1;
			this._AddButton.Text = "Add";
			this._AddButton.UseVisualStyleBackColor = true;
			this._AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// customers
			// 
			this._CustomersLabel.AutoSize = true;
			this._CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._CustomersLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this._CustomersLabel.Location = new System.Drawing.Point(72, 7);
			this._CustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this._CustomersLabel.Name = "customers";
			this._CustomersLabel.Size = new System.Drawing.Size(149, 31);
			this._CustomersLabel.TabIndex = 0;
			this._CustomersLabel.Text = "customers";
			// 
			// reportsGB
			// 
			this._ReportsGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this._ReportsGroupBox.Controls.Add(this._ReportCustomerButton);
			this._ReportsGroupBox.Controls.Add(this._ReportsLabel);
			this._ReportsGroupBox.Controls.Add(this._ReportConsultantButton);
			this._ReportsGroupBox.Controls.Add(this._ReportApptMonthButton);
			this._ReportsGroupBox.Location = new System.Drawing.Point(288, 445);
			this._ReportsGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this._ReportsGroupBox.Name = "reportsGB";
			this._ReportsGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this._ReportsGroupBox.Size = new System.Drawing.Size(308, 133);
			this._ReportsGroupBox.TabIndex = 2;
			this._ReportsGroupBox.TabStop = false;
			// 
			// ReportCustomer
			// 
			this._ReportCustomerButton.Location = new System.Drawing.Point(219, 53);
			this._ReportCustomerButton.Name = "ReportCustomer";
			this._ReportCustomerButton.Size = new System.Drawing.Size(84, 55);
			this._ReportCustomerButton.TabIndex = 5;
			this._ReportCustomerButton.Text = "Appointments by Customer";
			this._ReportCustomerButton.UseVisualStyleBackColor = true;
			this._ReportCustomerButton.Click += new System.EventHandler(this.ReportCustomerButton_Click);
			// 
			// reports
			// 
			this._ReportsLabel.AutoSize = true;
			this._ReportsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._ReportsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this._ReportsLabel.Location = new System.Drawing.Point(112, 7);
			this._ReportsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this._ReportsLabel.Name = "reports";
			this._ReportsLabel.Size = new System.Drawing.Size(106, 31);
			this._ReportsLabel.TabIndex = 4;
			this._ReportsLabel.Text = "reports";
			// 
			// ReportConsultant
			// 
			this._ReportConsultantButton.Location = new System.Drawing.Point(120, 53);
			this._ReportConsultantButton.Name = "ReportConsultant";
			this._ReportConsultantButton.Size = new System.Drawing.Size(84, 55);
			this._ReportConsultantButton.TabIndex = 1;
			this._ReportConsultantButton.Text = "Consultant Schedules";
			this._ReportConsultantButton.UseVisualStyleBackColor = true;
			this._ReportConsultantButton.Click += new System.EventHandler(this.ReportConsultantButton_Click);
			// 
			// ReportApptMonth
			// 
			this._ReportApptMonthButton.Location = new System.Drawing.Point(14, 53);
			this._ReportApptMonthButton.Name = "ReportApptMonth";
			this._ReportApptMonthButton.Size = new System.Drawing.Size(84, 55);
			this._ReportApptMonthButton.TabIndex = 0;
			this._ReportApptMonthButton.Text = "Appointment types by month";
			this._ReportApptMonthButton.UseVisualStyleBackColor = true;
			this._ReportApptMonthButton.Click += new System.EventHandler(this.ReportApptMonthButton_Click);
			// 
			// ExitBtn
			// 
			this._ExitButton.Location = new System.Drawing.Point(1009, 506);
			this._ExitButton.Margin = new System.Windows.Forms.Padding(2);
			this._ExitButton.Name = "ExitBtn";
			this._ExitButton.Size = new System.Drawing.Size(57, 31);
			this._ExitButton.TabIndex = 3;
			this._ExitButton.Text = "Exit";
			this._ExitButton.UseVisualStyleBackColor = true;
			this._ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// Scheduling
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1148, 581);
			this.Controls.Add(this._ExitButton);
			this.Controls.Add(this._ReportsGroupBox);
			this.Controls.Add(this._CustomersGroupBox);
			this.Controls.Add(this._CalendarGroupBox);
			this.Name = "Scheduling";
			this.Text = "Scheduling";
			this._CalendarGroupBox.ResumeLayout(false);
			this._CalendarGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._CalendarDataGridView)).EndInit();
			this._CustomersGroupBox.ResumeLayout(false);
			this._CustomersGroupBox.PerformLayout();
			this._ReportsGroupBox.ResumeLayout(false);
			this._ReportsGroupBox.PerformLayout();
			this.ResumeLayout(false);

					}

				#endregion

				private System.Windows.Forms.GroupBox _CalendarGroupBox;
				private System.Windows.Forms.GroupBox _CustomersGroupBox;
				private System.Windows.Forms.GroupBox _ReportsGroupBox;
				private System.Windows.Forms.Button _DeleteButton;
				private System.Windows.Forms.Button _UpdateButton;
				private System.Windows.Forms.Button _AddButton;
				private System.Windows.Forms.Label _CalendarLabel;
				private System.Windows.Forms.Label _MessageLabel;
				private System.Windows.Forms.RadioButton _MonthlyCalendarRadioButton;
				private System.Windows.Forms.RadioButton _WeeklyCalendarRadioButton;
				private System.Windows.Forms.DataGridView _CalendarDataGridView;
				private System.Windows.Forms.Button _AddApptButton;
				private System.Windows.Forms.Button _ExitButton;
				private System.Windows.Forms.Button _ReportApptMonthButton;
				private System.Windows.Forms.Label _CustomersLabel;
				private System.Windows.Forms.Label _ReportsLabel;
				private System.Windows.Forms.Button _ReportConsultantButton;
				private System.Windows.Forms.Button _ReportCustomerButton;
		private System.Windows.Forms.Button _UpdateApptButton;
		private System.Windows.Forms.Button _DeleteApptButton;
	}
	}