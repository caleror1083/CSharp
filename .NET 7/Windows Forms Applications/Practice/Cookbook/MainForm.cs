using Cookbook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Cookbook;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
            PopulateCounterIngredients();
            PopulateRecipes();
    }

	private static CookbookContext GetContext()
	{
         return new CookbookContext();
	}

    private void PopulateCounterIngredients()
    {
        // read all the ingredients from the database and display them in the listbox
        using var context = GetContext();
        CounterIngredientsListbox.DisplayMember = "Name";
        CounterIngredientsListbox.ValueMember = "Id";
        CounterIngredientsListbox.DataSource = context.Ingredients.ToList();
    }

	void PopulateRecipes()
    {
        // read all the recipes from the database and display them in the listbox
        using var context = GetContext();
        RecipesListbox.DisplayMember = "Name";
        RecipesListbox.ValueMember = "Id";
        RecipesListbox.DataSource = context.Recipes.ToList();
    }

	void AddRecipeButton_Click(object sender, EventArgs e)
		{
			// insert into the recipe table the value of the recipeName parameter
			using var context = GetContext();
			var recipe = new Recipe
            {
                Name = RecipeNameTextbox.Text,
				PrepTime = 80,
				Instructions = "Many Instructions"
            };
			context.Recipes.Add(recipe);
			context.SaveChanges();
			PopulateRecipes();
		}

	void AddIngredientButton_Click(object sender, EventArgs e)
		{
			// insert into the recipeingredient table the value of the recipeId and ingredientId parameters
			using var context = GetContext();
			var recipeIngredient = new RecipeIngredient
            {
                RecipeId = (int)RecipesListbox.SelectedValue,
                IngredientId = (int)CounterIngredientsListbox.SelectedValue
            };
			context.RecipeIngredients.Add(recipeIngredient);
			context.SaveChanges();
			PopulateRecipes();
		}

	void UpdateRecipeButton_Click(object sender, EventArgs e)
		{
			// update the recipe table with the value of the recipe name textbox where the recipe id matches the selected recipe id in the listbox
			using var context = GetContext();
			var recipe = context.Recipes.Find(RecipesListbox.SelectedValue);
			recipe.Name = RecipeNameTextbox.Text;
			context.SaveChanges();
			PopulateRecipes();
		}

	void RecipesListbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			PopulateIngredients();
		}

	void PopulateIngredients()
		{
			// read all the ingredients from the database and display them in the listbox where the recipe id matches the selected recipe id in the listbox
			using var context = GetContext();
			IngredientsListbox.DisplayMember = "Name";
			IngredientsListbox.ValueMember = "Id";
				
			var recipeId = (int)RecipesListbox.SelectedValue;
			var ingredients = context.RecipeIngredients
                .Where(ri => ri.RecipeId == recipeId)
                .Select(ri => ri.Ingredient)
                .ToList();
				IngredientsListbox.DataSource = ingredients;
		}
}