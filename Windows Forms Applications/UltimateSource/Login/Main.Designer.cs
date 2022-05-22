namespace Login
{
	partial class Main
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
			this.MainButtonExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// MainButtonExit
			// 
			this.MainButtonExit.Location = new System.Drawing.Point(13, 13);
			this.MainButtonExit.Name = "MainButtonExit";
			this.MainButtonExit.Size = new System.Drawing.Size(75, 23);
			this.MainButtonExit.TabIndex = 0;
			this.MainButtonExit.Text = "Exit";
			this.MainButtonExit.UseVisualStyleBackColor = true;
			this.MainButtonExit.Click += new System.EventHandler(this.MainButtonExit_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(182, 57);
			this.Controls.Add(this.MainButtonExit);
			this.Name = "Main";
			this.Text = "Main";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button MainButtonExit;
	}
}