/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

namespace WGU_C969
	{
		partial class AppointmentTypeReport
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
			this.PrintDocument = new System.Drawing.Printing.PrintDocument();
			this.PrintDialog = new System.Windows.Forms.PrintDialog();
			this.OutputDGV = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.OutputDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// ExitBtn
			// 
			this.ExitBtn.Location = new System.Drawing.Point(145, 394);
			this.ExitBtn.Name = "ExitBtn";
			this.ExitBtn.Size = new System.Drawing.Size(75, 23);
			this.ExitBtn.TabIndex = 1;
			this.ExitBtn.Text = "Exit";
			this.ExitBtn.UseVisualStyleBackColor = true;
			this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// PrintDialog
			// 
			this.PrintDialog.UseEXDialog = true;
			// 
			// OutputDGV
			// 
			this.OutputDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OutputDGV.Location = new System.Drawing.Point(12, 12);
			this.OutputDGV.Name = "OutputDGV";
			this.OutputDGV.Size = new System.Drawing.Size(345, 354);
			this.OutputDGV.TabIndex = 2;
			// 
			// AppointmentTypeReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 450);
			this.Controls.Add(this.OutputDGV);
			this.Controls.Add(this.ExitBtn);
			this.Name = "AppointmentTypeReport";
			this.Text = "AppointmentTypeReport";
			((System.ComponentModel.ISupportInitialize)(this.OutputDGV)).EndInit();
			this.ResumeLayout(false);

				}

				#endregion
				private System.Windows.Forms.Button ExitBtn;
				private System.Drawing.Printing.PrintDocument PrintDocument;
				private System.Windows.Forms.PrintDialog PrintDialog;
		private System.Windows.Forms.DataGridView OutputDGV;
	}
	}