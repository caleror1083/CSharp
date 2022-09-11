namespace _001_Multithreading
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
			this.TimeConsumingButton = new System.Windows.Forms.Button();
			this.PrintButton = new System.Windows.Forms.Button();
			this.NumbersListbox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// TimeConsumingButton
			// 
			this.TimeConsumingButton.Location = new System.Drawing.Point(26, 33);
			this.TimeConsumingButton.Name = "TimeConsumingButton";
			this.TimeConsumingButton.Size = new System.Drawing.Size(195, 23);
			this.TimeConsumingButton.TabIndex = 0;
			this.TimeConsumingButton.Text = "Do Time Consuming Work";
			this.TimeConsumingButton.UseVisualStyleBackColor = true;
			this.TimeConsumingButton.Click += new System.EventHandler(this.TimeConsumingButton_Click);
			// 
			// PrintButton
			// 
			this.PrintButton.Location = new System.Drawing.Point(78, 62);
			this.PrintButton.Name = "PrintButton";
			this.PrintButton.Size = new System.Drawing.Size(88, 23);
			this.PrintButton.TabIndex = 1;
			this.PrintButton.Text = "Print Numbers";
			this.PrintButton.UseVisualStyleBackColor = true;
			this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
			// 
			// NumbersListbox
			// 
			this.NumbersListbox.FormattingEnabled = true;
			this.NumbersListbox.Location = new System.Drawing.Point(67, 91);
			this.NumbersListbox.Name = "NumbersListbox";
			this.NumbersListbox.Size = new System.Drawing.Size(120, 147);
			this.NumbersListbox.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(245, 255);
			this.Controls.Add(this.NumbersListbox);
			this.Controls.Add(this.PrintButton);
			this.Controls.Add(this.TimeConsumingButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button TimeConsumingButton;
		private System.Windows.Forms.Button PrintButton;
		private System.Windows.Forms.ListBox NumbersListbox;
	}
}

