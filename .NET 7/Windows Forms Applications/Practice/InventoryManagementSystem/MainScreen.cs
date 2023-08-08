using System;
using System.Windows.Forms;

namespace InventoryManagementSystem;

// MainScreen class inherits from the Form base class
public partial class MainScreen : Form
{
    // Constructor for the MainScreen class
    public MainScreen()
    {
        InitializeComponent();
    }

    // Event triggered when the MainScreen form is loaded
    private void MainScreen_Load(object sender, EventArgs e) { }

    private void AddPart_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private void AddProduct_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private void DeletePart_Click(object sender, EventArgs e) { }

    private void DeleteProduct_Click(object sender, EventArgs e) { }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        // Close the application
        Environment.Exit(0);
    }

    private void ModifyPart_Click(object sender, EventArgs e) { }

    private void ModifyProduct_Click(object sender, EventArgs e) { }

    private void PartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

    private void SearchPart_Click(object sender, EventArgs e) { }

    private void SearchPartTxt_TextChanged(object sender, EventArgs e) { }
}