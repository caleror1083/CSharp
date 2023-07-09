using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cookbook
	{
		public partial class MainForm : Form
			{
				SqlConnection connection;    // Provides the connection to the database
				SqlDataAdapter dataAdapter;
				SqlCommand command;    // Another form to handle SELECT queries and support parameters
				private readonly string connectionString;
		
				public MainForm()
					{
						InitializeComponent();						
						connectionString = ConfigurationManager.ConnectionStrings["Cookbook.Properties.Settings.Cookbook"].ConnectionString;  // When the form is created, initialize the connectionString to the database
					}

				private void MainForm_Load(object sender, EventArgs e)
					{
						PopulateCounterIngredients();
						PopulateRecipes();
					}

				void PopulateCounterIngredients()
					{
						string counterQuery = $"SELECT * " +
						                      $"FROM Ingredient";

						using (connection = new SqlConnection(connectionString))
						using (dataAdapter = new SqlDataAdapter(counterQuery, connection))
							{
								DataTable ingredientTable = new DataTable();
								dataAdapter.Fill(ingredientTable);
								CounterIngredientsListbox.DisplayMember = "Name";
								CounterIngredientsListbox.ValueMember = "Id";
								CounterIngredientsListbox.DataSource = ingredientTable;
							}
					}

				void PopulateRecipes()
					{
						string recipeQuery = $"SELECT * " +
						                     $"FROM Recipe";

						//  Use a using statement with an object like SqlConnection because it implements IDisposable, it auto closes the object
						using (connection = new SqlConnection(connectionString))    // initializes the connection
						using (dataAdapter = new SqlDataAdapter(recipeQuery, connection))     // SqlDataAdapter also implements IDisposable and also opens the connection
							{
								DataTable recipeTable = new DataTable();    // Holds the data returned by the SQL query
								dataAdapter.Fill(recipeTable);    // Fills the table with the data in the DataTable
								RecipesListbox.DisplayMember = "Name";    // Displays the value of Name
								RecipesListbox.ValueMember = "Id";    // reference the value by the ID column
								RecipesListbox.DataSource = recipeTable;    // hook up recipe listbox to recipe DataTable
							}
					}

				void AddRecipeButton_Click(object sender, EventArgs e)
					{
						string addRecipeQuery = $"INSERT INTO Recipe " +
						                        $"VALUES (@RecipeName, 80, 'Many instructions')";

						using (connection = new SqlConnection(connectionString))
						using (command = new SqlCommand(addRecipeQuery, connection))
							{
								connection.Open(); // When no DataAdapter is called, you must open the connection manually
								command.Parameters.AddWithValue("@RecipeName", RecipeNameTextbox.Text);
								command.ExecuteNonQuery();
							}
						PopulateRecipes();
					}

				void AddIngredientButton_Click(object sender, EventArgs e)
					{
						string addRecipeQuery = $"INSERT INTO RecipeIngredient " +
						                        $"VALUES (@RecipeId, @IngredientId)";  // @RecipeId is syntax for parameter

						using (connection = new SqlConnection(connectionString))
						using (command = new SqlCommand(addRecipeQuery, connection))
							{
								connection.Open();
								command.Parameters.AddWithValue("@RecipeId", RecipesListbox.SelectedValue);  // Whatever recipe is selected in the listbox, get the value of it and pass it into the ingredientQuery which will return the ingredients that are tied to that recipe
								command.Parameters.AddWithValue("@IngredientId", CounterIngredientsListbox.SelectedValue);
								command.ExecuteNonQuery();
							}
						PopulateRecipes();
					}

				void UpdateRecipeButton_Click(object sender, EventArgs e)
					{
						string addRecipeQuery = $"UPDATE Recipe " +
						                        $"SET Name = @RecipeName " +
												$"WHERE Id = @RecipeId";

						using (connection = new SqlConnection(connectionString))
						using (command = new SqlCommand(addRecipeQuery, connection))
							{
								connection.Open();
								command.Parameters.AddWithValue("@RecipeName", RecipeNameTextbox.Text);
								command.Parameters.AddWithValue("@RecipeId", RecipesListbox.SelectedValue);
								command.ExecuteNonQuery();
							}
						PopulateRecipes();
					}

				void RecipesListbox_SelectedIndexChanged(object sender, EventArgs e)
					{
						PopulateIngredients();
					}

				void PopulateIngredients()
					{
						string ingredientQuery = $"SELECT a.Name " + 
						                         $"FROM Ingredient a " +
												 $"INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId " +
												 $"WHERE b.RecipeId = @RecipeId";

						using (connection = new SqlConnection(connectionString))
						using (command = new SqlCommand(ingredientQuery, connection))
						using (dataAdapter = new SqlDataAdapter(command))
							{
								command.Parameters.AddWithValue("@RecipeId", RecipesListbox.SelectedValue);
								DataTable ingredientTable = new DataTable();
								dataAdapter.Fill(ingredientTable);
								IngredientsListbox.DisplayMember = "Name";
								IngredientsListbox.ValueMember = "Id";
								IngredientsListbox.DataSource = ingredientTable;  // hook up ingredients listbox recipes to ingredients DataTable
							}
					}
			}
	}