/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem
	{
		public partial class MainScreen : Form    // MainScreen class inherits from the Form base class
			{
				// Constructor
				public MainScreen()
					{
						InitializeComponent();
					}

				private void MainScreen_Load(object sender, EventArgs e)    // Event triggered when MainScreen loads
					{
					    PartDGV.DataSource = Inventory.GetAllPartsDT();
						ProductDGV.DataSource = Inventory.GetProductsDT();
					}

				private void AddPart_Click(object sender, EventArgs e)
					{
						Hide();
						AddPart addPartRedirect = new AddPart();
						addPartRedirect.ShowDialog();
					}

				private void DeletePart_Click(object sender, EventArgs e)
					{
						if (Inventory._AllParts.Any())
							{
								DialogResult deletePartDR = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
								if (deletePartDR == DialogResult.Yes)
									{
										int selectPart = Convert.ToInt32(PartDGV.Rows[PartDGV.CurrentCell.RowIndex].Cells[0].Value);	// Gets the value of the selected Part - Part ID
										Inventory.DeletePart(Inventory.LookupPart(selectPart));
									}
								else if (deletePartDR == DialogResult.No)
									{
									}
							}
						else
							{
								MessageBox.Show("No parts to delete", "Error");
							}
					}

				private void SearchPartTxt_TextChanged(object sender, EventArgs e)
					{
						if (string.IsNullOrWhiteSpace(SearchPartTxt.Text) || !int.TryParse(SearchPartTxt.Text, out int _))		// TextBox enabled if number is entered
							{
								SearchPartBtn.Enabled = false;
								SearchPartTxt.BackColor = Color.Salmon;
							}
						else
							{
								SearchPartBtn.Enabled = true;
								SearchPartTxt.BackColor = Color.White;
							}
					}

				private void SearchPartBtn_Click(object sender, EventArgs e)
					{
						int searchPartID = Convert.ToInt32(SearchPartTxt.Text);
						
						if (Inventory.LookupPart(searchPartID) != null)
							{
								PartDGV.Rows[Inventory.LookupPart(searchPartID).GetPartID()].Selected = true;
							}
						else
							{
								MessageBox.Show("Part ID in Part Grid not found", "Not Found");
							}
					}

				private void SearchProductBtn_Click(object sender, EventArgs e)
					{
						int searchProductID = Convert.ToInt32(SearchProductTxt.Text);
						if (Inventory.LookupPart(searchProductID) != null)
							{
								ProductDGV.Rows[Inventory.LookupProduct(searchProductID).GetProductID()].Selected = true;
							}
						else
							{
								MessageBox.Show("Part ID in Product Grid not found", "Not Found");
							}
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						Environment.Exit(1);		// Closes the application
					}

				private void AddProduct_Click(object sender, EventArgs e)
					{
						Hide();					
						AddProduct addProductRedirect = new AddProduct();
						addProductRedirect.ShowDialog();
					}

				private void DeleteProduct_Click(object sender, EventArgs e)
					{
						if (Inventory._Products.Any())
							{
								DialogResult deleteProductDR = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
								if (deleteProductDR == DialogResult.Yes)
									{
										int selectProduct = Convert.ToInt32(ProductDGV.Rows[ProductDGV.CurrentCell.RowIndex].Cells[0].Value);	// Gets the value of the selected Product - Part ID
										Inventory.RemoveProduct(selectProduct);
									}
								else if (deleteProductDR == DialogResult.No)
									{
										// N/A
									}
							}
						else
							{
								MessageBox.Show("No products to delete", "Error");
							}
					}

				private void PartDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
					{
						int selectPart = Convert.ToInt32(PartDGV.Rows[PartDGV.CurrentCell.RowIndex].Cells[0].Value);		//Gets the Part ID number for the row selected
						Label1.Text = selectPart.ToString();
					}

				private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
					{
						int selectProduct = Convert.ToInt32(ProductDGV.Rows[ProductDGV.CurrentCell.RowIndex].Cells[0].Value);		//Gets the Part ID number for the row selected
						Label1.Text = selectProduct.ToString();
					}

				private void ModifyPart_Click(object sender, EventArgs e)
					{
						if (Inventory._AllParts.Any())
							{
								int selectPart = Convert.ToInt32(PartDGV.Rows[PartDGV.CurrentCell.RowIndex].Cells[0].Value);	// Gets the value of the selected Part ID from Part DataGrid
								Hide();
								ModifyPart modifyPartRedirect = new ModifyPart(selectPart);
								modifyPartRedirect.ShowDialog();
							}
						else
							{
								MessageBox.Show("No parts to modify", "Error");
							}
					}

				private void ModifyProduct_Click(object sender, EventArgs e)
					{
						if (Inventory._Products.Any())
							{
								int selectProduct = Convert.ToInt32(ProductDGV.Rows[ProductDGV.CurrentCell.RowIndex].Cells[0].Value);	// Gets the value of the selected Part ID from Product DataGrid
								Hide();
								ModifyProduct modifyProductRedirect = new ModifyProduct(selectProduct);
								modifyProductRedirect.ShowDialog();
							}
						else
							{
								MessageBox.Show("No products to modify.", "Error");
							}
					}

				private void SearchProductTxt_TextChanged(object sender, EventArgs e)
					{
						// TextBox enabled if number is entered
						if (string.IsNullOrWhiteSpace(SearchProductTxt.Text) || !int.TryParse(SearchProductTxt.Text, out int _))
							{
								SearchProductBtn.Enabled = false;
								SearchProductTxt.BackColor = Color.Salmon;
							}
						else
							{
								SearchProductBtn.Enabled = true;
								SearchProductTxt.BackColor = Color.White;
							}
					}
			}
	}