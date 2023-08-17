using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cookbook;

public partial class MainForm : Form
{
    private SqlConnection connection;  // Provides the connection to the database
	private SqlDataAdapter dataAdapter;
	private SqlCommand command;  // Another form to handle SELECT queries and support parameters
	private readonly string connectionString;

    public MainForm()
    {
        InitializeComponent();

		// When the form is created, initialize the connectionString to the database
		connectionString = Properties.Settings.Default.connectionString;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
            PopulateCounterIngredients();
            PopulateRecipes();
    }

    private void PopulateCounterIngredients()
    {
        string counterQuery = $"SELECT * FROM Ingredient";

        using (connection = new SqlConnection(connectionString))
        using (dataAdapter = new SqlDataAdapter(counterQuery, connection))
        {
            var counterTable = new DataTable();
            dataAdapter.Fill(counterTable);
            CounterIngredientsListbox.DisplayMember = "Name";
            CounterIngredientsListbox.ValueMember = "Id";
            CounterIngredientsListbox.DataSource = counterTable;
        }
    }

	private void PopulateRecipes()
    {
        string recipeQuery = $"SELECT * FROM Recipe";

        // Use a using statement with an object like SqlConnection because it implements IDosposable it auto closes the object
        using (connection = new SqlConnection(connectionString))  // initialize the connection
        using (dataAdapter = new SqlDataAdapter(recipeQuery, connection))  // SqlDataAdapter also implements IDisposable and also opens the connection
        {
            var recipeTable = new DataTable(); // Holds the data returned by the SQL query
            dataAdapter.Fill(recipeTable);  // Fills the table with the data in the DataTable
            RecipesListbox.DisplayMember = "Name";  // Displays the value of Name
            RecipesListbox.ValueMember = "Id";  // Reference the value by the ID column
            RecipesListbox.DataSource = recipeTable;  // Hook up listbox reciped to recipe DataTable
        }
    }

    private void AddRecipeButton_Click(object sender, EventArgs e)
    {
        var addRecipeQuery = $"INSERT INTO Recipe " +
                             $"VALUES (@RecipeName, 80, 'Many instructions')";

        using (connection = new SqlConnection(connectionString))
        using (command = new SqlCommand(addRecipeQuery, connection))
        {
            connection.Open();  // When no DataAdapter is called, you must open the connection manually
            command.Parameters.AddWithValue("@RecipeName", RecipeNameTextbox.Text);
            command.ExecuteNonQuery();
        }

        PopulateRecipes();
    }

    private void AddIngredientButton_Click(object sender, EventArgs e)
    {
        var addRecipeQuery = $"INSERT INTO RecipeIngredient " +
                             $"VALUES (@RecipeId, @IngredientId)";

        using (connection = new SqlConnection(connectionString))
        using (command = new SqlCommand(addRecipeQuery, connection))
        {
            connection.Open();

            // Whatever recipe is selected in the listbox
            // get the value of it and pass it into the ingredientQuery which will return the ingredients that are tied to that recipe
            command.Parameters.AddWithValue("@RecipeId", RecipesListbox.SelectedValue);
            command.Parameters.AddWithValue("@IngredientId", CounterIngredientsListbox.SelectedValue);
            command.ExecuteNonQuery();
        }

        PopulateRecipes();
    }

    private void UpdateRecipeButton_Click(object sender, EventArgs e)
    {
        var updateRecipeQuery = $"UPDATE Recipe " +
                                $"SET Name = @RecipeName " +
                                $"WHERE Id = @RecipeId";

        using (connection = new SqlConnection(connectionString))
        using (command = new SqlCommand(updateRecipeQuery, connection))
        {
            connection.Open();
            command.Parameters.AddWithValue("@RecipeName", RecipeNameTextbox.Text);
            command.Parameters.AddWithValue("@RecipeId", RecipesListbox.SelectedValue);
            command.ExecuteNonQuery();
        }

        PopulateRecipes();
    }

    private void RecipesListbox_SelectedIndexChanged(object sender, EventArgs e)
    {
        PopulateIngredients();
    }

    private void PopulateIngredients()
    {
        // @RecipeId is syntax for parameter
        var ingredientQuery = $"SELECT a.Name " +
                              $"FROM Ingredient a " +
                              $"INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId " +
                              $"WHERE b.RecipeId = @RecipeId";

        using (connection = new SqlConnection(connectionString))
        using (command = new SqlCommand(ingredientQuery, connection))
        using (dataAdapter = new SqlDataAdapter(command))
        {
            // Whatever recipe is selected in the listbox, get the value of it and pass it into the ingredientQuery which will return the ingredients that are tied to that recipe
            command.Parameters.AddWithValue("@RecipeId", RecipesListbox.SelectedValue);
            var ingredientTable = new DataTable();
            dataAdapter.Fill(ingredientTable);
            IngredientsListbox.DisplayMember = "Name";
            IngredientsListbox.ValueMember = "Id";
            IngredientsListbox.DataSource = ingredientTable;
        }
    }
}