namespace Properties
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
			this.btnText = new System.Windows.Forms.Button();
			this.btnEnabled = new System.Windows.Forms.Button();
			this.btnHeight = new System.Windows.Forms.Button();
			this.btnTextBox = new System.Windows.Forms.Button();
			this.txtTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnText
			// 
			this.btnText.Location = new System.Drawing.Point(13, 13);
			this.btnText.Name = "btnText";
			this.btnText.Size = new System.Drawing.Size(76, 23);
			this.btnText.TabIndex = 0;
			this.btnText.Text = "Change Text";
			this.btnText.UseVisualStyleBackColor = true;
			this.btnText.Click += new System.EventHandler(this.btnText_Click);
			// 
			// btnEnabled
			// 
			this.btnEnabled.Location = new System.Drawing.Point(96, 13);
			this.btnEnabled.Name = "btnEnabled";
			this.btnEnabled.Size = new System.Drawing.Size(75, 23);
			this.btnEnabled.TabIndex = 1;
			this.btnEnabled.Text = "Enabled";
			this.btnEnabled.UseVisualStyleBackColor = true;
			this.btnEnabled.Click += new System.EventHandler(this.btnEnabled_Click);
			// 
			// btnHeight
			// 
			this.btnHeight.Location = new System.Drawing.Point(178, 13);
			this.btnHeight.Name = "btnHeight";
			this.btnHeight.Size = new System.Drawing.Size(75, 23);
			this.btnHeight.TabIndex = 2;
			this.btnHeight.Text = "Height";
			this.btnHeight.UseVisualStyleBackColor = true;
			this.btnHeight.Click += new System.EventHandler(this.btnHeight_Click);
			// 
			// btnTextBox
			// 
			this.btnTextBox.Location = new System.Drawing.Point(12, 42);
			this.btnTextBox.Name = "btnTextBox";
			this.btnTextBox.Size = new System.Drawing.Size(75, 23);
			this.btnTextBox.TabIndex = 3;
			this.btnTextBox.Text = "TextBox";
			this.btnTextBox.UseVisualStyleBackColor = true;
			this.btnTextBox.Click += new System.EventHandler(this.btnTextBox_Click);
			// 
			// txtTextBox
			// 
			this.txtTextBox.Location = new System.Drawing.Point(93, 42);
			this.txtTextBox.Name = "txtTextBox";
			this.txtTextBox.Size = new System.Drawing.Size(125, 20);
			this.txtTextBox.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtTextBox);
			this.Controls.Add(this.btnTextBox);
			this.Controls.Add(this.btnHeight);
			this.Controls.Add(this.btnEnabled);
			this.Controls.Add(this.btnText);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnText;
		private System.Windows.Forms.Button btnEnabled;
		private System.Windows.Forms.Button btnHeight;
		private System.Windows.Forms.Button btnTextBox;
		private System.Windows.Forms.TextBox txtTextBox;
	}
}

