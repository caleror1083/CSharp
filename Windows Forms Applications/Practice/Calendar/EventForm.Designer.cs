namespace Calendar
{
	partial class EventForm
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
			this.EventTextbox = new System.Windows.Forms.TextBox();
			this.DateTextbox = new System.Windows.Forms.TextBox();
			this.DateLabel = new System.Windows.Forms.Label();
			this.EventLabel = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// EventTextbox
			// 
			this.EventTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EventTextbox.Location = new System.Drawing.Point(45, 127);
			this.EventTextbox.Name = "EventTextbox";
			this.EventTextbox.Size = new System.Drawing.Size(299, 26);
			this.EventTextbox.TabIndex = 0;
			// 
			// DateTextbox
			// 
			this.DateTextbox.Enabled = false;
			this.DateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateTextbox.Location = new System.Drawing.Point(45, 53);
			this.DateTextbox.Name = "DateTextbox";
			this.DateTextbox.Size = new System.Drawing.Size(299, 26);
			this.DateTextbox.TabIndex = 1;
			// 
			// DateLabel
			// 
			this.DateLabel.AutoSize = true;
			this.DateLabel.Location = new System.Drawing.Point(51, 37);
			this.DateLabel.Name = "DateLabel";
			this.DateLabel.Size = new System.Drawing.Size(30, 13);
			this.DateLabel.TabIndex = 2;
			this.DateLabel.Text = "Date";
			// 
			// EventLabel
			// 
			this.EventLabel.AutoSize = true;
			this.EventLabel.Location = new System.Drawing.Point(51, 101);
			this.EventLabel.Name = "EventLabel";
			this.EventLabel.Size = new System.Drawing.Size(35, 13);
			this.EventLabel.TabIndex = 3;
			this.EventLabel.Text = "Event";
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(269, 183);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(75, 23);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// EventForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 242);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.EventLabel);
			this.Controls.Add(this.DateLabel);
			this.Controls.Add(this.DateTextbox);
			this.Controls.Add(this.EventTextbox);
			this.Name = "EventForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EventForm";
			this.Load += new System.EventHandler(this.EventForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox EventTextbox;
		private System.Windows.Forms.TextBox DateTextbox;
		private System.Windows.Forms.Label DateLabel;
		private System.Windows.Forms.Label EventLabel;
		private System.Windows.Forms.Button SaveButton;
	}
}