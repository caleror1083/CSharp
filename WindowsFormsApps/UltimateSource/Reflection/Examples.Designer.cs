namespace Reflection
{
	partial class Examples
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TypeNameTextBox = new System.Windows.Forms.TextBox();
			this.DiscoverTypeInformationButton = new System.Windows.Forms.Button();
			this.ConstructorsListBox = new System.Windows.Forms.ListBox();
			this.MethodsListBox = new System.Windows.Forms.ListBox();
			this.PropertiesListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Type Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(87, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Constructors";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(362, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Methods";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(630, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Properties";
			// 
			// TypeNameTextBox
			// 
			this.TypeNameTextBox.Location = new System.Drawing.Point(90, 7);
			this.TypeNameTextBox.Name = "TypeNameTextBox";
			this.TypeNameTextBox.Size = new System.Drawing.Size(424, 20);
			this.TypeNameTextBox.TabIndex = 4;
			// 
			// DiscoverTypeInformationButton
			// 
			this.DiscoverTypeInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DiscoverTypeInformationButton.Location = new System.Drawing.Point(548, 5);
			this.DiscoverTypeInformationButton.Name = "DiscoverTypeInformationButton";
			this.DiscoverTypeInformationButton.Size = new System.Drawing.Size(177, 23);
			this.DiscoverTypeInformationButton.TabIndex = 5;
			this.DiscoverTypeInformationButton.Text = "Discover Type Information";
			this.DiscoverTypeInformationButton.UseVisualStyleBackColor = true;
			this.DiscoverTypeInformationButton.Click += new System.EventHandler(this.DiscoverTypeInformationButton_Click);
			// 
			// ConstructorsListBox
			// 
			this.ConstructorsListBox.FormattingEnabled = true;
			this.ConstructorsListBox.Location = new System.Drawing.Point(30, 87);
			this.ConstructorsListBox.Name = "ConstructorsListBox";
			this.ConstructorsListBox.Size = new System.Drawing.Size(225, 329);
			this.ConstructorsListBox.TabIndex = 6;
			// 
			// MethodsListBox
			// 
			this.MethodsListBox.FormattingEnabled = true;
			this.MethodsListBox.Location = new System.Drawing.Point(289, 87);
			this.MethodsListBox.Name = "MethodsListBox";
			this.MethodsListBox.Size = new System.Drawing.Size(225, 329);
			this.MethodsListBox.TabIndex = 7;
			// 
			// PropertiesListBox
			// 
			this.PropertiesListBox.FormattingEnabled = true;
			this.PropertiesListBox.Location = new System.Drawing.Point(548, 87);
			this.PropertiesListBox.Name = "PropertiesListBox";
			this.PropertiesListBox.Size = new System.Drawing.Size(225, 329);
			this.PropertiesListBox.TabIndex = 8;
			// 
			// Examples
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.PropertiesListBox);
			this.Controls.Add(this.MethodsListBox);
			this.Controls.Add(this.ConstructorsListBox);
			this.Controls.Add(this.DiscoverTypeInformationButton);
			this.Controls.Add(this.TypeNameTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Examples";
			this.Text = "Examples";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TypeNameTextBox;
		private System.Windows.Forms.Button DiscoverTypeInformationButton;
		private System.Windows.Forms.ListBox ConstructorsListBox;
		private System.Windows.Forms.ListBox MethodsListBox;
		private System.Windows.Forms.ListBox PropertiesListBox;
	}
}

