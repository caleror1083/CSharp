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
			this.lblExit = new System.Windows.Forms.Label();
			this.lblNum1 = new System.Windows.Forms.Label();
			this.lblNum2 = new System.Windows.Forms.Label();
			this.lblSum = new System.Windows.Forms.Label();
			this.DayContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.PreviousButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
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
			// 
			// lblExit
			// 
			this.lblExit.AutoSize = true;
			this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExit.Location = new System.Drawing.Point(60, 83);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(63, 20);
			this.lblExit.TabIndex = 1;
			this.lblExit.Text = "Sunday";
			// 
			// lblNum1
			// 
			this.lblNum1.AutoSize = true;
			this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNum1.Location = new System.Drawing.Point(215, 83);
			this.lblNum1.Name = "lblNum1";
			this.lblNum1.Size = new System.Drawing.Size(65, 20);
			this.lblNum1.TabIndex = 2;
			this.lblNum1.Text = "Monday";
			// 
			// lblNum2
			// 
			this.lblNum2.AutoSize = true;
			this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNum2.Location = new System.Drawing.Point(372, 83);
			this.lblNum2.Name = "lblNum2";
			this.lblNum2.Size = new System.Drawing.Size(69, 20);
			this.lblNum2.TabIndex = 3;
			this.lblNum2.Text = "Tuesday";
			// 
			// lblSum
			// 
			this.lblSum.AutoSize = true;
			this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSum.Location = new System.Drawing.Point(510, 83);
			this.lblSum.Name = "lblSum";
			this.lblSum.Size = new System.Drawing.Size(93, 20);
			this.lblSum.TabIndex = 6;
			this.lblSum.Text = "Wednesday";
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
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(995, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "Saturday";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(846, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Friday";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(675, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "Thursday";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1132, 871);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.PreviousButton);
			this.Controls.Add(this.DayContainer);
			this.Controls.Add(this.lblSum);
			this.Controls.Add(this.lblNum2);
			this.Controls.Add(this.lblNum1);
			this.Controls.Add(this.lblExit);
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
		private System.Windows.Forms.Label lblExit;
		private System.Windows.Forms.Label lblNum1;
		private System.Windows.Forms.Label lblNum2;
		private System.Windows.Forms.Label lblSum;
		private System.Windows.Forms.FlowLayoutPanel DayContainer;
		private System.Windows.Forms.Button PreviousButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}