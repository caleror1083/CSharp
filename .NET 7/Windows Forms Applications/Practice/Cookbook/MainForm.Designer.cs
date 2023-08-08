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
			this.RecipesLabel = new System.Windows.Forms.Label();
			this.RecipesListbox = new System.Windows.Forms.ListBox();
			this.IngredientsListbox = new System.Windows.Forms.ListBox();
			this.IngredientsLabel = new System.Windows.Forms.Label();
			this.AddRecipeButton = new System.Windows.Forms.Button();
			this.RecipeNameTextbox = new System.Windows.Forms.TextBox();
			this.UpdateRecipeButton = new System.Windows.Forms.Button();
			this.CounterIngredientsListbox = new System.Windows.Forms.ListBox();
			this.CounterIngredientsLabel = new System.Windows.Forms.Label();
			this.AddIngredientButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// RecipesLabel
			// 
			this.RecipesLabel.AutoSize = true;
			this.RecipesLabel.Location = new System.Drawing.Point(40, 264);
			this.RecipesLabel.Name = "RecipesLabel";
			this.RecipesLabel.Size = new System.Drawing.Size(46, 13);
			this.RecipesLabel.TabIndex = 0;
			this.RecipesLabel.Text = "Recipes";
			// 
			// RecipesListbox
			// 
			this.RecipesListbox.FormattingEnabled = true;
			this.RecipesListbox.Location = new System.Drawing.Point(43, 281);
			this.RecipesListbox.Name = "RecipesListbox";
			this.RecipesListbox.Size = new System.Drawing.Size(120, 199);
			this.RecipesListbox.TabIndex = 1;
			this.RecipesListbox.SelectedIndexChanged += new System.EventHandler(this.RecipesListbox_SelectedIndexChanged);
			// 
			// IngredientsListbox
			// 
			this.IngredientsListbox.FormattingEnabled = true;
			this.IngredientsListbox.Location = new System.Drawing.Point(182, 281);
			this.IngredientsListbox.Name = "IngredientsListbox";
			this.IngredientsListbox.Size = new System.Drawing.Size(120, 199);
			this.IngredientsListbox.TabIndex = 3;
			// 
			// IngredientsLabel
			// 
			this.IngredientsLabel.AutoSize = true;
			this.IngredientsLabel.Location = new System.Drawing.Point(179, 264);
			this.IngredientsLabel.Name = "IngredientsLabel";
			this.IngredientsLabel.Size = new System.Drawing.Size(96, 13);
			this.IngredientsLabel.TabIndex = 2;
			this.IngredientsLabel.Text = "Recipe Ingredients";
			// 
			// AddRecipeButton
			// 
			this.AddRecipeButton.Location = new System.Drawing.Point(88, 512);
			this.AddRecipeButton.Name = "AddRecipeButton";
			this.AddRecipeButton.Size = new System.Drawing.Size(75, 23);
			this.AddRecipeButton.TabIndex = 4;
			this.AddRecipeButton.Text = "Add Recipe";
			this.AddRecipeButton.UseVisualStyleBackColor = true;
			this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
			// 
			// RecipeNameTextbox
			// 
			this.RecipeNameTextbox.Location = new System.Drawing.Point(88, 487);
			this.RecipeNameTextbox.Name = "RecipeNameTextbox";
			this.RecipeNameTextbox.Size = new System.Drawing.Size(156, 20);
			this.RecipeNameTextbox.TabIndex = 5;
			// 
			// UpdateRecipeButton
			// 
			this.UpdateRecipeButton.Location = new System.Drawing.Point(169, 512);
			this.UpdateRecipeButton.Name = "UpdateRecipeButton";
			this.UpdateRecipeButton.Size = new System.Drawing.Size(75, 23);
			this.UpdateRecipeButton.TabIndex = 6;
			this.UpdateRecipeButton.Text = "Update Recipe";
			this.UpdateRecipeButton.UseVisualStyleBackColor = true;
			this.UpdateRecipeButton.Click += new System.EventHandler(this.UpdateRecipeButton_Click);
			// 
			// CounterIngredientsListbox
			// 
			this.CounterIngredientsListbox.FormattingEnabled = true;
			this.CounterIngredientsListbox.Location = new System.Drawing.Point(101, 26);
			this.CounterIngredientsListbox.Name = "CounterIngredientsListbox";
			this.CounterIngredientsListbox.Size = new System.Drawing.Size(135, 199);
			this.CounterIngredientsListbox.TabIndex = 8;
			// 
			// CounterIngredientsLabel
			// 
			this.CounterIngredientsLabel.AutoSize = true;
			this.CounterIngredientsLabel.Location = new System.Drawing.Point(98, 9);
			this.CounterIngredientsLabel.Name = "CounterIngredientsLabel";
			this.CounterIngredientsLabel.Size = new System.Drawing.Size(131, 13);
			this.CounterIngredientsLabel.TabIndex = 7;
			this.CounterIngredientsLabel.Text = "Ingredients on the counter";
			// 
			// AddIngredientButton
			// 
			this.AddIngredientButton.Location = new System.Drawing.Point(125, 231);
			this.AddIngredientButton.Name = "AddIngredientButton";
			this.AddIngredientButton.Size = new System.Drawing.Size(84, 23);
			this.AddIngredientButton.TabIndex = 9;
			this.AddIngredientButton.Text = "Add to Recipe";
			this.AddIngredientButton.UseVisualStyleBackColor = true;
			this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(338, 547);
			this.Controls.Add(this.AddIngredientButton);
			this.Controls.Add(this.CounterIngredientsListbox);
			this.Controls.Add(this.CounterIngredientsLabel);
			this.Controls.Add(this.UpdateRecipeButton);
			this.Controls.Add(this.RecipeNameTextbox);
			this.Controls.Add(this.AddRecipeButton);
			this.Controls.Add(this.IngredientsListbox);
			this.Controls.Add(this.IngredientsLabel);
			this.Controls.Add(this.RecipesListbox);
			this.Controls.Add(this.RecipesLabel);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cookbook";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label RecipesLabel;
		private System.Windows.Forms.ListBox RecipesListbox;
		private System.Windows.Forms.ListBox IngredientsListbox;
		private System.Windows.Forms.Label IngredientsLabel;
		private System.Windows.Forms.Button AddRecipeButton;
		private System.Windows.Forms.TextBox RecipeNameTextbox;
		private System.Windows.Forms.Button UpdateRecipeButton;
		private System.Windows.Forms.ListBox CounterIngredientsListbox;
		private System.Windows.Forms.Label CounterIngredientsLabel;
		private System.Windows.Forms.Button AddIngredientButton;
	}
}

