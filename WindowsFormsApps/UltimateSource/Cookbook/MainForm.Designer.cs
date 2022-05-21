namespace Cookbook
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
			this.cookbookDataSet = new Cookbook.CookbookDataSet();
			this.lblRecipes = new System.Windows.Forms.Label();
			this.lstRecipes = new System.Windows.Forms.ListBox();
			this.lstIngredients = new System.Windows.Forms.ListBox();
			this.lblIngredients = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// cookbookDataSet
			// 
			this.cookbookDataSet.DataSetName = "CookbookDataSet";
			this.cookbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// lblRecipes
			// 
			this.lblRecipes.AutoSize = true;
			this.lblRecipes.Location = new System.Drawing.Point(13, 13);
			this.lblRecipes.Name = "lblRecipes";
			this.lblRecipes.Size = new System.Drawing.Size(46, 13);
			this.lblRecipes.TabIndex = 0;
			this.lblRecipes.Text = "Recipes";
			// 
			// lstRecipes
			// 
			this.lstRecipes.FormattingEnabled = true;
			this.lstRecipes.Location = new System.Drawing.Point(16, 30);
			this.lstRecipes.Name = "lstRecipes";
			this.lstRecipes.Size = new System.Drawing.Size(120, 199);
			this.lstRecipes.TabIndex = 1;
			this.lstRecipes.SelectedIndexChanged += new System.EventHandler(this.LstRecipes_SelectedIndexChanged);
			// 
			// lstIngredients
			// 
			this.lstIngredients.FormattingEnabled = true;
			this.lstIngredients.Location = new System.Drawing.Point(155, 30);
			this.lstIngredients.Name = "lstIngredients";
			this.lstIngredients.Size = new System.Drawing.Size(120, 199);
			this.lstIngredients.TabIndex = 3;
			// 
			// lblIngredients
			// 
			this.lblIngredients.AutoSize = true;
			this.lblIngredients.Location = new System.Drawing.Point(152, 13);
			this.lblIngredients.Name = "lblIngredients";
			this.lblIngredients.Size = new System.Drawing.Size(96, 13);
			this.lblIngredients.TabIndex = 2;
			this.lblIngredients.Text = "Recipe Ingredients";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 241);
			this.Controls.Add(this.lstIngredients);
			this.Controls.Add(this.lblIngredients);
			this.Controls.Add(this.lstRecipes);
			this.Controls.Add(this.lblRecipes);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cookbook";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.cookbookDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CookbookDataSet cookbookDataSet;
		private System.Windows.Forms.Label lblRecipes;
		private System.Windows.Forms.ListBox lstRecipes;
		private System.Windows.Forms.ListBox lstIngredients;
		private System.Windows.Forms.Label lblIngredients;
	}
}

