/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

namespace SoftwareCompanySchedulingApp
	{
		partial class UpdateAppt
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
			this.ApptIdTxt = new System.Windows.Forms.TextBox();
			this.appointmentID = new System.Windows.Forms.Label();
			this.NameTxt = new System.Windows.Forms.TextBox();
			this.customerName = new System.Windows.Forms.Label();
			this.ExitBtn = new System.Windows.Forms.Button();
			this.EndDT = new System.Windows.Forms.DateTimePicker();
			this.StartDT = new System.Windows.Forms.DateTimePicker();
			this.end = new System.Windows.Forms.Label();
			this.start = new System.Windows.Forms.Label();
			this.CustomerIdTxt = new System.Windows.Forms.TextBox();
			this.customerID = new System.Windows.Forms.Label();
			this.TypeTxt = new System.Windows.Forms.TextBox();
			this.type = new System.Windows.Forms.Label();
			this.UpdateBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ApptIdTxt
			// 
			this.ApptIdTxt.Location = new System.Drawing.Point(121, 95);
			this.ApptIdTxt.Name = "ApptIdTxt";
			this.ApptIdTxt.ReadOnly = true;
			this.ApptIdTxt.Size = new System.Drawing.Size(101, 20);
			this.ApptIdTxt.TabIndex = 136;
			// 
			// appointmentID
			// 
			this.appointmentID.AutoSize = true;
			this.appointmentID.Location = new System.Drawing.Point(12, 98);
			this.appointmentID.Name = "appointmentID";
			this.appointmentID.Size = new System.Drawing.Size(80, 13);
			this.appointmentID.TabIndex = 135;
			this.appointmentID.Text = "Appointment ID";
			// 
			// NameTxt
			// 
			this.NameTxt.Location = new System.Drawing.Point(121, 21);
			this.NameTxt.Name = "NameTxt";
			this.NameTxt.ReadOnly = true;
			this.NameTxt.Size = new System.Drawing.Size(101, 20);
			this.NameTxt.TabIndex = 134;
			// 
			// customerName
			// 
			this.customerName.AutoSize = true;
			this.customerName.Location = new System.Drawing.Point(12, 28);
			this.customerName.Name = "customerName";
			this.customerName.Size = new System.Drawing.Size(82, 13);
			this.customerName.TabIndex = 133;
			this.customerName.Text = "Customer Name";
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(160, 264);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 35);
			this.ExitBtn.TabIndex = 5;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// EndDT
			// 
			this.EndDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.EndDT.Location = new System.Drawing.Point(121, 215);
			this.EndDT.Name = "EndDT";
			this.EndDT.Size = new System.Drawing.Size(200, 20);
			this.EndDT.TabIndex = 3;
			this.EndDT.ValueChanged += new System.EventHandler(this.EndDT_ValueChanged);
			// 
			// StartDT
			// 
			this.StartDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.StartDT.Location = new System.Drawing.Point(121, 174);
			this.StartDT.Name = "StartDT";
			this.StartDT.Size = new System.Drawing.Size(200, 20);
			this.StartDT.TabIndex = 2;
			this.StartDT.ValueChanged += new System.EventHandler(this.StartDT_ValueChanged);
			// 
			// end
			// 
			this.end.AutoSize = true;
			this.end.Location = new System.Drawing.Point(12, 221);
			this.end.Name = "end";
			this.end.Size = new System.Drawing.Size(91, 13);
			this.end.TabIndex = 113;
			this.end.Text = "Appointment End:";
			// 
			// start
			// 
			this.start.AutoSize = true;
			this.start.Location = new System.Drawing.Point(12, 181);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(94, 13);
			this.start.TabIndex = 112;
			this.start.Text = "Appointment Start:";
			// 
			// CustomerIdTxt
			// 
			this.CustomerIdTxt.Location = new System.Drawing.Point(121, 58);
			this.CustomerIdTxt.Name = "CustomerIdTxt";
			this.CustomerIdTxt.ReadOnly = true;
			this.CustomerIdTxt.Size = new System.Drawing.Size(101, 20);
			this.CustomerIdTxt.TabIndex = 111;
			// 
			// customerID
			// 
			this.customerID.AutoSize = true;
			this.customerID.Location = new System.Drawing.Point(12, 65);
			this.customerID.Name = "customerID";
			this.customerID.Size = new System.Drawing.Size(65, 13);
			this.customerID.TabIndex = 110;
			this.customerID.Text = "Customer ID";
			// 
			// TypeTxt
			// 
			this.TypeTxt.Location = new System.Drawing.Point(121, 134);
			this.TypeTxt.Name = "TypeTxt";
			this.TypeTxt.Size = new System.Drawing.Size(100, 20);
			this.TypeTxt.TabIndex = 1;
			// 
			// type
			// 
			this.type.AutoSize = true;
			this.type.Location = new System.Drawing.Point(12, 141);
			this.type.Name = "type";
			this.type.Size = new System.Drawing.Size(31, 13);
			this.type.TabIndex = 108;
			this.type.Text = "Type";
			// 
			// UpdateBtn
			// 
			this.UpdateBtn.Location = new System.Drawing.Point(64, 264);
			this.UpdateBtn.Name = "UpdateBtn";
			this.UpdateBtn.Size = new System.Drawing.Size(75, 35);
			this.UpdateBtn.TabIndex = 4;
			this.UpdateBtn.Text = "Update Appointment";
			this.UpdateBtn.UseVisualStyleBackColor = true;
			this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
			// 
			// UpdateAppt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 357);
			this.Controls.Add(this.UpdateBtn);
			this.Controls.Add(this.ApptIdTxt);
			this.Controls.Add(this.appointmentID);
			this.Controls.Add(this.NameTxt);
			this.Controls.Add(this.customerName);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.EndDT);
			this.Controls.Add(this.StartDT);
			this.Controls.Add(this.end);
			this.Controls.Add(this.start);
			this.Controls.Add(this.CustomerIdTxt);
			this.Controls.Add(this.customerID);
			this.Controls.Add(this.TypeTxt);
			this.Controls.Add(this.type);
			this.Name = "UpdateAppt";
			this.Text = "Update Appt";
			this.Load += new System.EventHandler(this.UpdateAppt_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

					}

				#endregion
				private System.Windows.Forms.TextBox ApptIdTxt;
				private System.Windows.Forms.Label appointmentID;
				private System.Windows.Forms.TextBox NameTxt;
				private System.Windows.Forms.Label customerName;
				private System.Windows.Forms.Button ExitBtn;
				private System.Windows.Forms.DateTimePicker EndDT;
				private System.Windows.Forms.DateTimePicker StartDT;
				private System.Windows.Forms.Label end;
				private System.Windows.Forms.Label start;
				private System.Windows.Forms.TextBox CustomerIdTxt;
				private System.Windows.Forms.Label customerID;
				private System.Windows.Forms.TextBox TypeTxt;
				private System.Windows.Forms.Label type;
		private System.Windows.Forms.Button UpdateBtn;
	}
	}