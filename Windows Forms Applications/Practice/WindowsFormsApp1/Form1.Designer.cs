namespace Calendar
{
	partial class Form1
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
			this.btnExit = new System.Windows.Forms.Button();
			this.lblExit = new System.Windows.Forms.Label();
			this.lblNum1 = new System.Windows.Forms.Label();
			this.lblNum2 = new System.Windows.Forms.Label();
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.lblSum = new System.Windows.Forms.Label();
			this.txtSum = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(26, 195);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(82, 23);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblExit
			// 
			this.lblExit.AutoSize = true;
			this.lblExit.Location = new System.Drawing.Point(23, 151);
			this.lblExit.Name = "lblExit";
			this.lblExit.Size = new System.Drawing.Size(0, 13);
			this.lblExit.TabIndex = 1;
			// 
			// lblNum1
			// 
			this.lblNum1.AutoSize = true;
			this.lblNum1.Location = new System.Drawing.Point(25, 26);
			this.lblNum1.Name = "lblNum1";
			this.lblNum1.Size = new System.Drawing.Size(0, 13);
			this.lblNum1.TabIndex = 2;
			// 
			// lblNum2
			// 
			this.lblNum2.AutoSize = true;
			this.lblNum2.Location = new System.Drawing.Point(23, 70);
			this.lblNum2.Name = "lblNum2";
			this.lblNum2.Size = new System.Drawing.Size(0, 13);
			this.lblNum2.TabIndex = 3;
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(145, 18);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 20);
			this.txtNum1.TabIndex = 4;
			this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(145, 62);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 20);
			this.txtNum2.TabIndex = 5;
			this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
			// 
			// lblSum
			// 
			this.lblSum.AutoSize = true;
			this.lblSum.Location = new System.Drawing.Point(25, 113);
			this.lblSum.Name = "lblSum";
			this.lblSum.Size = new System.Drawing.Size(0, 13);
			this.lblSum.TabIndex = 6;
			// 
			// txtSum
			// 
			this.txtSum.Location = new System.Drawing.Point(145, 105);
			this.txtSum.Name = "txtSum";
			this.txtSum.Size = new System.Drawing.Size(100, 20);
			this.txtSum.TabIndex = 7;
			this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 229);
			this.Controls.Add(this.txtSum);
			this.Controls.Add(this.lblSum);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Controls.Add(this.lblNum2);
			this.Controls.Add(this.lblNum1);
			this.Controls.Add(this.lblExit);
			this.Controls.Add(this.btnExit);
			this.Name = "Form1";
			this.Text = "WinApps";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblExit;
		private System.Windows.Forms.Label lblNum1;
		private System.Windows.Forms.Label lblNum2;
		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.Label lblSum;
		private System.Windows.Forms.TextBox txtSum;
	}
}