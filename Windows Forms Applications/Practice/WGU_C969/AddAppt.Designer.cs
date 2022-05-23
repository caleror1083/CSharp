/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

namespace WGU_C969
	{
		partial class AddAppt
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
			this.ExitBtn = new System.Windows.Forms.Button();
			this.AddBtn = new System.Windows.Forms.Button();
			this.EndDT = new System.Windows.Forms.DateTimePicker();
			this.StartDT = new System.Windows.Forms.DateTimePicker();
			this.end = new System.Windows.Forms.Label();
			this.start = new System.Windows.Forms.Label();
			this.CustomerIdTxt = new System.Windows.Forms.TextBox();
			this.customerID = new System.Windows.Forms.Label();
			this.TypeTxt = new System.Windows.Forms.TextBox();
			this.type = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.Label();
			this.NameBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(203, 278);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 35);
			this.ExitBtn.TabIndex = 6;
			this.ExitBtn.Text = "Cancel";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// AddBtn
			// 
			this.AddBtn.Location = new System.Drawing.Point(82, 278);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(75, 35);
			this.AddBtn.TabIndex = 5;
			this.AddBtn.Text = "Add Appointment";
			this.AddBtn.UseVisualStyleBackColor = true;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// EndDT
			// 
			this.EndDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.EndDT.Location = new System.Drawing.Point(119, 217);
			this.EndDT.Name = "EndDT";
			this.EndDT.Size = new System.Drawing.Size(200, 20);
			this.EndDT.TabIndex = 4;
			this.EndDT.ValueChanged += new System.EventHandler(this.EndDT_ValueChanged);
			// 
			// StartDT
			// 
			this.StartDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.StartDT.Location = new System.Drawing.Point(119, 170);
			this.StartDT.Name = "StartDT";
			this.StartDT.Size = new System.Drawing.Size(200, 20);
			this.StartDT.TabIndex = 3;
			this.StartDT.ValueChanged += new System.EventHandler(this.StartDT_ValueChanged);
			// 
			// end
			// 
			this.end.AutoSize = true;
			this.end.Location = new System.Drawing.Point(19, 217);
			this.end.Name = "end";
			this.end.Size = new System.Drawing.Size(91, 13);
			this.end.TabIndex = 64;
			this.end.Text = "Appointment End:";
			// 
			// start
			// 
			this.start.AutoSize = true;
			this.start.Location = new System.Drawing.Point(19, 176);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(94, 13);
			this.start.TabIndex = 63;
			this.start.Text = "Appointment Start:";
			// 
			// CustomerIdTxt
			// 
			this.CustomerIdTxt.Location = new System.Drawing.Point(119, 91);
			this.CustomerIdTxt.Name = "CustomerIdTxt";
			this.CustomerIdTxt.ReadOnly = true;
			this.CustomerIdTxt.Size = new System.Drawing.Size(100, 20);
			this.CustomerIdTxt.TabIndex = 62;
			// 
			// customerID
			// 
			this.customerID.AutoSize = true;
			this.customerID.Location = new System.Drawing.Point(22, 98);
			this.customerID.Name = "customerID";
			this.customerID.Size = new System.Drawing.Size(65, 13);
			this.customerID.TabIndex = 61;
			this.customerID.Text = "Customer ID";
			// 
			// TypeTxt
			// 
			this.TypeTxt.Location = new System.Drawing.Point(119, 134);
			this.TypeTxt.Name = "TypeTxt";
			this.TypeTxt.Size = new System.Drawing.Size(100, 20);
			this.TypeTxt.TabIndex = 2;
			// 
			// type
			// 
			this.type.AutoSize = true;
			this.type.Location = new System.Drawing.Point(22, 141);
			this.type.Name = "type";
			this.type.Size = new System.Drawing.Size(31, 13);
			this.type.TabIndex = 59;
			this.type.Text = "Type";
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Location = new System.Drawing.Point(22, 52);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(85, 13);
			this.name.TabIndex = 56;
			this.name.Text = "Customer Name:";
			// 
			// NameBox
			// 
			this.NameBox.FormattingEnabled = true;
			this.NameBox.Location = new System.Drawing.Point(119, 49);
			this.NameBox.Name = "NameBox";
			this.NameBox.Size = new System.Drawing.Size(100, 21);
			this.NameBox.TabIndex = 1;
			this.NameBox.SelectedIndexChanged += new System.EventHandler(this.NameBox_SelectedIndexChanged);
			// 
			// AddAppt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 345);
			this.Controls.Add(this.NameBox);
			this.Controls.Add(this.ExitBtn);
			this.Controls.Add(this.AddBtn);
			this.Controls.Add(this.EndDT);
			this.Controls.Add(this.StartDT);
			this.Controls.Add(this.end);
			this.Controls.Add(this.start);
			this.Controls.Add(this.CustomerIdTxt);
			this.Controls.Add(this.customerID);
			this.Controls.Add(this.TypeTxt);
			this.Controls.Add(this.type);
			this.Controls.Add(this.name);
			this.Name = "AddAppt";
			this.Text = "Add Appt";
			this.Load += new System.EventHandler(this.AddAppt_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

					}

				#endregion
				private System.Windows.Forms.Button ExitBtn;
				private System.Windows.Forms.Button AddBtn;
				private System.Windows.Forms.DateTimePicker EndDT;
				private System.Windows.Forms.DateTimePicker StartDT;
				private System.Windows.Forms.Label end;
				private System.Windows.Forms.Label start;
				private System.Windows.Forms.TextBox CustomerIdTxt;
				private System.Windows.Forms.Label customerID;
				private System.Windows.Forms.TextBox TypeTxt;
				private System.Windows.Forms.Label type;
				private System.Windows.Forms.Label name;
		private System.Windows.Forms.ComboBox NameBox;
	}
	}