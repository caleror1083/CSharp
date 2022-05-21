namespace MessageBoxes
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
			this.btnMessage = new System.Windows.Forms.Button();
			this.btnMessageTitle = new System.Windows.Forms.Button();
			this.btnStringVariable = new System.Windows.Forms.Button();
			this.btnIntVariable = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnMessage
			// 
			this.btnMessage.Location = new System.Drawing.Point(13, 13);
			this.btnMessage.Name = "btnMessage";
			this.btnMessage.Size = new System.Drawing.Size(75, 23);
			this.btnMessage.TabIndex = 0;
			this.btnMessage.Text = "Message";
			this.btnMessage.UseVisualStyleBackColor = true;
			this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
			// 
			// btnMessageTitle
			// 
			this.btnMessageTitle.Location = new System.Drawing.Point(95, 13);
			this.btnMessageTitle.Name = "btnMessageTitle";
			this.btnMessageTitle.Size = new System.Drawing.Size(106, 23);
			this.btnMessageTitle.TabIndex = 1;
			this.btnMessageTitle.Text = "Message With Title";
			this.btnMessageTitle.UseVisualStyleBackColor = true;
			this.btnMessageTitle.Click += new System.EventHandler(this.btnMessageTitle_Click);
			// 
			// btnStringVariable
			// 
			this.btnStringVariable.Location = new System.Drawing.Point(208, 13);
			this.btnStringVariable.Name = "btnStringVariable";
			this.btnStringVariable.Size = new System.Drawing.Size(89, 23);
			this.btnStringVariable.TabIndex = 2;
			this.btnStringVariable.Text = "String Variable";
			this.btnStringVariable.UseVisualStyleBackColor = true;
			this.btnStringVariable.Click += new System.EventHandler(this.btnStringVariable_Click);
			// 
			// btnIntVariable
			// 
			this.btnIntVariable.Location = new System.Drawing.Point(304, 13);
			this.btnIntVariable.Name = "btnIntVariable";
			this.btnIntVariable.Size = new System.Drawing.Size(89, 23);
			this.btnIntVariable.TabIndex = 3;
			this.btnIntVariable.Text = "Integer Variable";
			this.btnIntVariable.UseVisualStyleBackColor = true;
			this.btnIntVariable.Click += new System.EventHandler(this.btnIntVariable_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 65);
			this.Controls.Add(this.btnIntVariable);
			this.Controls.Add(this.btnStringVariable);
			this.Controls.Add(this.btnMessageTitle);
			this.Controls.Add(this.btnMessage);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnMessage;
		private System.Windows.Forms.Button btnMessageTitle;
		private System.Windows.Forms.Button btnStringVariable;
		private System.Windows.Forms.Button btnIntVariable;
	}
}

