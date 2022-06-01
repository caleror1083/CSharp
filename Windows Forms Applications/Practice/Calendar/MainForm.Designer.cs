namespace Calendar
{
	partial class MainForm
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
			this.NextButton = new System.Windows.Forms.Button();
			this.SundayLabel = new System.Windows.Forms.Label();
			this.MondayLabel = new System.Windows.Forms.Label();
			this.TuesdayLabel = new System.Windows.Forms.Label();
			this.WednesdayLabel = new System.Windows.Forms.Label();
			this.DayContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.PreviousButton = new System.Windows.Forms.Button();
			this.SaturdayLabel = new System.Windows.Forms.Label();
			this.FridayLabel = new System.Windows.Forms.Label();
			this.ThursdayLabel = new System.Windows.Forms.Label();
			this.DateLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// NextButton
			// 
			this.NextButton.Location = new System.Drawing.Point(1043, 836);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(75, 23);
			this.NextButton.TabIndex = 0;
			this.NextButton.Text = "Next";
			this.NextButton.UseVisualStyleBackColor = true;
			this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
			// 
			// SundayLabel
			// 
			this.SundayLabel.AutoSize = true;
			this.SundayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SundayLabel.Location = new System.Drawing.Point(60, 83);
			this.SundayLabel.Name = "SundayLabel";
			this.SundayLabel.Size = new System.Drawing.Size(63, 20);
			this.SundayLabel.TabIndex = 1;
			this.SundayLabel.Text = "Sunday";
			// 
			// MondayLabel
			// 
			this.MondayLabel.AutoSize = true;
			this.MondayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MondayLabel.Location = new System.Drawing.Point(215, 83);
			this.MondayLabel.Name = "MondayLabel";
			this.MondayLabel.Size = new System.Drawing.Size(65, 20);
			this.MondayLabel.TabIndex = 2;
			this.MondayLabel.Text = "Monday";
			// 
			// TuesdayLabel
			// 
			this.TuesdayLabel.AutoSize = true;
			this.TuesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TuesdayLabel.Location = new System.Drawing.Point(372, 83);
			this.TuesdayLabel.Name = "TuesdayLabel";
			this.TuesdayLabel.Size = new System.Drawing.Size(69, 20);
			this.TuesdayLabel.TabIndex = 3;
			this.TuesdayLabel.Text = "Tuesday";
			// 
			// WednesdayLabel
			// 
			this.WednesdayLabel.AutoSize = true;
			this.WednesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WednesdayLabel.Location = new System.Drawing.Point(510, 83);
			this.WednesdayLabel.Name = "WednesdayLabel";
			this.WednesdayLabel.Size = new System.Drawing.Size(93, 20);
			this.WednesdayLabel.TabIndex = 6;
			this.WednesdayLabel.Text = "Wednesday";
			// 
			// DayContainer
			// 
			this.DayContainer.Location = new System.Drawing.Point(12, 119);
			this.DayContainer.Name = "DayContainer";
			this.DayContainer.Size = new System.Drawing.Size(1104, 711);
			this.DayContainer.TabIndex = 8;
			// 
			// PreviousButton
			// 
			this.PreviousButton.Location = new System.Drawing.Point(962, 836);
			this.PreviousButton.Name = "PreviousButton";
			this.PreviousButton.Size = new System.Drawing.Size(75, 23);
			this.PreviousButton.TabIndex = 9;
			this.PreviousButton.Text = "Previous";
			this.PreviousButton.UseVisualStyleBackColor = true;
			this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
			// 
			// SaturdayLabel
			// 
			this.SaturdayLabel.AutoSize = true;
			this.SaturdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SaturdayLabel.Location = new System.Drawing.Point(995, 83);
			this.SaturdayLabel.Name = "SaturdayLabel";
			this.SaturdayLabel.Size = new System.Drawing.Size(73, 20);
			this.SaturdayLabel.TabIndex = 12;
			this.SaturdayLabel.Text = "Saturday";
			// 
			// FridayLabel
			// 
			this.FridayLabel.AutoSize = true;
			this.FridayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FridayLabel.Location = new System.Drawing.Point(846, 83);
			this.FridayLabel.Name = "FridayLabel";
			this.FridayLabel.Size = new System.Drawing.Size(52, 20);
			this.FridayLabel.TabIndex = 11;
			this.FridayLabel.Text = "Friday";
			// 
			// ThursdayLabel
			// 
			this.ThursdayLabel.AutoSize = true;
			this.ThursdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ThursdayLabel.Location = new System.Drawing.Point(675, 83);
			this.ThursdayLabel.Name = "ThursdayLabel";
			this.ThursdayLabel.Size = new System.Drawing.Size(74, 20);
			this.ThursdayLabel.TabIndex = 10;
			this.ThursdayLabel.Text = "Thursday";
			// 
			// DateLabel
			// 
			this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateLabel.Location = new System.Drawing.Point(276, 9);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(557, 45);
			this.DateLabel.TabIndex = 7;
			this.DateLabel.Text = "MONTH YEAR";
			this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1132, 871);
			this.Controls.Add(this.DateLabel);
			this.Controls.Add(this.SaturdayLabel);
			this.Controls.Add(this.FridayLabel);
			this.Controls.Add(this.ThursdayLabel);
			this.Controls.Add(this.PreviousButton);
			this.Controls.Add(this.DayContainer);
			this.Controls.Add(this.WednesdayLabel);
			this.Controls.Add(this.TuesdayLabel);
			this.Controls.Add(this.MondayLabel);
			this.Controls.Add(this.SundayLabel);
			this.Controls.Add(this.NextButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "My Calendar";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.Label SundayLabel;
		private System.Windows.Forms.Label MondayLabel;
		private System.Windows.Forms.Label TuesdayLabel;
		private System.Windows.Forms.Label WednesdayLabel;
		private System.Windows.Forms.FlowLayoutPanel DayContainer;
		private System.Windows.Forms.Button PreviousButton;
		private System.Windows.Forms.Label SaturdayLabel;
		private System.Windows.Forms.Label FridayLabel;
		private System.Windows.Forms.Label ThursdayLabel;
		private System.Windows.Forms.Label DateLabel;
	}
}