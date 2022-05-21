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
				readonly string connectionString;
		
				public MainForm()
					{
						InitializeComponent();

						// When the form is created, initialize the connectionString to the database
						connectionString = ConfigurationManager.ConnectionStrings["Cookbook.Properties.Settings.CookbookConnectionString"].ConnectionString;
					}

				private void MainForm_Load(object sender, EventArgs e)
					{
						PopulateRecipes();						
					}

				public void PopulateRecipes()
					{
						string recipeQuery = "SELECT * FROM Recipe";

						//  Use a using statement with an object like SqlConnection because it implements IDisposable, it auto closes the object
						using (connection = new SqlConnection(connectionString))    // initializes the connection
						using (dataAdapter = new SqlDataAdapter(recipeQuery, connection))     // SqlDataAdapter also implements IDisposable and also opens the connection
							{
								DataTable recipeTable = new DataTable();    // Holds the data returned by the SQL query
								dataAdapter.Fill(recipeTable);    // Fills the table with the data in the DataTable
								lstRecipes.DisplayMember = "Name";    // Displays the value of Name
								lstRecipes.ValueMember = "Id";    // reference the value by the ID column
								lstRecipes.DataSource = recipeTable;    // hook up listbox recipes to recipe DataTable
							}
					}

				public void PopulateIngredients()
					{
						string ingredientQuery = "SELECT a.Name " + 
						                         "FROM Ingredient a " +
													"INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId " +
												 "WHERE b.RecipeId = @RecipeId";    // @RecipeId is syntax for parameter

						//  Use a using statement with an object like SqlConnection because it implements IDisposable, it auto closes the object
						using (connection = new SqlConnection(connectionString))    // initializes the connection
						using (command = new SqlCommand(ingredientQuery, connection))
						using (dataAdapter = new SqlDataAdapter(command))     // SqlDataAdapter also implements IDisposable and also opens the connection
							{
								command.Parameters.AddWithValue("@RecipeId", lstRecipes.SelectedValue);    // Whatever recipe is selected in the listbox, get the value of it and pass it into the ingredientQuery which will return the ingredients that are tied to that recipe
								DataTable ingredientTable = new DataTable();    // Holds the data returned by the SQL query
								dataAdapter.Fill(ingredientTable);    // Fills the table with the data in the DataTable
								lstIngredients.DisplayMember = "Name";    // Displays the value of Name
								lstIngredients.ValueMember = "Id";    // reference the value by the ID column
								lstIngredients.DataSource = ingredientTable;    // hook up listbox recipes to recipe DataTable
							}
					}

				private void LstRecipes_SelectedIndexChanged(object sender, EventArgs e)
					{
						PopulateIngredients();
					}
			}
	}