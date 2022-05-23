/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem
	{
		public partial class AddProduct : Form
			{
				Product newProduct = new Product();

				public AddProduct()
					{
						InitializeComponent();
					}

				private void AddProduct_Load(object sender, EventArgs e)
					{
						allPartsDGV.DataSource = Inventory.GetAllPartsDT();
						associatedPartsDGV.DataSource = newProduct.getAssociatedPartsDT();
					}

				private void nameTxt_TextChanged(object sender, EventArgs e)
					{
						if (string.IsNullOrWhiteSpace(nameTxt.Text) || int.TryParse(nameTxt.Text, out int n))	// If TextBox is empty or a number is entered, color will be Salmond, color will be Salmon
							{
								nameTxt.BackColor = Color.Salmon;
								saveBtn.Enabled = false;
							}
						else
							{
								nameTxt.BackColor = Color.White;
							}

						if (nameTxt.BackColor == Color.White && inventoryTxt.BackColor == Color.White && priceTxt.BackColor == Color.White && maxTxt.BackColor == Color.White && minTxt.BackColor == Color.White)
							{
								saveBtn.Enabled = true;		// If info in all TextBoxes is valid, button is enabled
							}
					}

				private void inventoryTxt_TextChanged(object sender, EventArgs e)
					{
						if (string.IsNullOrWhiteSpace(inventoryTxt.Text) || !(int.TryParse(inventoryTxt.Text, out int n)))	// If TextBox is empty or a letter is entered, color will be Salmon
							{
								inventoryTxt.BackColor = Color.Salmon;
								saveBtn.Enabled = false;
							}
						else
							{
								inventoryTxt.BackColor = Color.White;
							}

						if (nameTxt.BackColor == Color.White && inventoryTxt.BackColor == Color.White && priceTxt.BackColor == Color.White && maxTxt.BackColor == Color.White && minTxt.BackColor == Color.White)
							{
								saveBtn.Enabled = true;		// If info in all TextBoxes is valid, button is enabled
							}
					}

				private void priceTxt_TextChanged(object sender, EventArgs e)
					{
						if (string.IsNullOrWhiteSpace(priceTxt.Text) || !(decimal.TryParse(priceTxt.Text, out decimal n)))	// If TextBox is empty or a letter is entered, color will be Salmon
							{
								priceTxt.BackColor = Color.Salmon;
								saveBtn.Enabled = false;
							}
						else
							{
								priceTxt.BackColor = Color.White;
							}

						if (nameTxt.BackColor == Color.White && inventoryTxt.BackColor == Color.White && priceTxt.BackColor == Color.White && maxTxt.BackColor == Color.White && minTxt.BackColor == Color.White)
							{
								saveBtn.Enabled = true;		// If info in all TextBoxes is valid, button is enabled
							}
					}

				private void maxTxt_TextChanged(object sender, EventArgs e)
					{
						if (string.IsNullOrWhiteSpace(maxTxt.Text) || !(int.TryParse(maxTxt.Text, out int n)))				// If TextBox is empty or a letter is entered, color will be Salmon
							{
								maxTxt.BackColor = Color.Salmon;
								saveBtn.Enabled = false;
							}
						else
							{
								maxTxt.BackColor = Color.White;
							}

						if (nameTxt.BackColor == Color.White && inventoryTxt.BackColor == Color.White && priceTxt.BackColor == Color.White && maxTxt.BackColor == Color.White && minTxt.BackColor == Color.White)
							{
								saveBtn.Enabled = true;		// If info in all TextBoxes is valid, button is enabled
							}
					}

				private void minTxt_TextChanged(object sender, EventArgs e)
					{
						if (string.IsNullOrWhiteSpace(minTxt.Text) || !(int.TryParse(minTxt.Text, out int n)))		// If TextBox is empty or an integer value is entered, color will be Salmon
							{
								minTxt.BackColor = Color.Salmon;
								saveBtn.Enabled = false;
							}
						else
							{
								minTxt.BackColor = Color.White;
							}

						if (nameTxt.BackColor == Color.White && inventoryTxt.BackColor == Color.White && priceTxt.BackColor == Color.White && maxTxt.BackColor == Color.White && minTxt.BackColor == Color.White)
							{
								saveBtn.Enabled = true;		// If info in all TextBoxes is valid, button is enabled
							}
					}

				private void searchPartTxt_TextChanged(object sender, EventArgs e)
				{
						if (string.IsNullOrWhiteSpace(searchPartTxt.Text) || !(int.TryParse(searchPartTxt.Text, out int n)))		// TextBox enabled if number is entered
							{
								searchPartBtn.Enabled = false;
								searchPartTxt.BackColor = Color.Salmon;
							}
						else
							{
								searchPartBtn.Enabled = true;
								searchPartTxt.BackColor = Color.White;
							}
				}

				private void searchPartBtn_Click(object sender, EventArgs e)
				{
						int searchPartID = Convert.ToInt32(searchPartTxt.Text);

						if (Inventory.LookupPart(searchPartID) != null)
							{
								allPartsDGV.Rows[Inventory.LookupPart(searchPartID).GetPartID()].Selected = true;
 							}
						else
							{
								MessageBox.Show("Part ID in Part Grid not found", "Not Found");
							}
				}

				private void addPartBtn_Click(object sender, EventArgs e)
					{
					    int selectPart = Convert.ToInt32(allPartsDGV.Rows[allPartsDGV.CurrentCell.RowIndex].Cells[0].Value);
						newProduct.addAssociatedPart(Inventory.LookupPart(selectPart));
					}

				private void deletePartBtn_Click(object sender, EventArgs e)
					{
					    DialogResult deletePartDR = MessageBox.Show("Are you sure?", "Delete Part", MessageBoxButtons.YesNo);

						if (deletePartDR == DialogResult.Yes)
							{
								int selectPart = Convert.ToInt32(associatedPartsDGV.Rows[associatedPartsDGV.CurrentCell.RowIndex].Cells[0].Value);		// Gets the part id number for the row selected
								newProduct.removeAssociatedPart(selectPart);
							}
						else if (deletePartDR == DialogResult.No)
							{
								// N/A
							}
					}

				private void saveBtn_Click(object sender, EventArgs e)
					{
						MainScreen mainScreenSave = new MainScreen();

						if (Convert.ToInt32(maxTxt.Text) < Convert.ToInt32(minTxt.Text))
							{

								MessageBox.Show("Min value is greater than the max value", "Error");
                
							}
						else if (newProduct.associatedPartsEmpty())
							{
								MessageBox.Show("You must add at least one associated part.", "Error");
							}
						else
							{
								newProduct.setName(nameTxt.Text);
								newProduct.setPrice(Convert.ToDecimal(priceTxt.Text));
								newProduct.setInStock(Convert.ToInt32(inventoryTxt.Text));
								newProduct.setMin(Convert.ToInt32(minTxt.Text));
								newProduct.setMax(Convert.ToInt32(maxTxt.Text));
								Inventory.addProduct(newProduct);
								this.Hide();
								mainScreenSave.ShowDialog();
							}
					}

				private void cancelBtn_Click(object sender, EventArgs e)
					{
						this.Hide();
						MainScreen mainScreenCancel = new MainScreen();
						mainScreenCancel.ShowDialog();
					}
			}
	}