namespace Calendar
{
	partial class UserControlDays
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DaysLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// DaysLabel
			// 
			this.DaysLabel.AutoSize = true;
			this.DaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DaysLabel.Location = new System.Drawing.Point(14, 15);
			this.DaysLabel.Name = "DaysLabel";
			this.DaysLabel.Size = new System.Drawing.Size(27, 20);
			this.DaysLabel.TabIndex = 0;
			this.DaysLabel.Text = "00";
			// 
			// UserControlDays
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.DaysLabel);
			this.Name = "UserControlDays";
			this.Size = new System.Drawing.Size(150, 108);
			this.Load += new System.EventHandler(this.UserControlDays_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label DaysLabel;
	}
}
