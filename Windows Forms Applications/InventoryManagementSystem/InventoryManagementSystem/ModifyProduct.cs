/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem
	{
		public partial class ModifyProduct : Form
			{
				public int productNumber;

				public ModifyProduct(int selectRow)
					{
                        InitializeComponent();
                        idTxt.Text = selectRow.ToString();
                        productNumber = selectRow;
					}

		        private void ModifyProduct_Load(object sender, EventArgs e)
		            {
                        allPartsDGV.DataSource = Inventory.GetAllPartsDT();
                        associatedPartsDGV.DataSource = Inventory.Products[productNumber].getAssociatedPartsDT();
                        nameTxt.Text = Inventory.Products[productNumber].getName();
                        inventoryTxt.Text = Inventory.Products[productNumber].getInStock().ToString();
                        priceTxt.Text = Inventory.Products[productNumber].getPrice().ToString();
                        maxTxt.Text = Inventory.Products[productNumber].getMax().ToString();
                        minTxt.Text = Inventory.Products[productNumber].getMin().ToString();
		            }

		        private void nameTxt_TextChanged(object sender, EventArgs e)
		            {
                        if (string.IsNullOrWhiteSpace(nameTxt.Text) || int.TryParse(nameTxt.Text, out int n))   // If TextBox is empty or a number is entered, color will be PaleGreen
                            {
                                nameTxt.BackColor = Color.PaleGreen;
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
                        if (string.IsNullOrWhiteSpace(inventoryTxt.Text) || !(int.TryParse(inventoryTxt.Text, out int n)))   // If TextBox is empty or a letter is entered, color will be PaleGreen
                            {
                                inventoryTxt.BackColor = Color.PaleGreen;
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
                        if (string.IsNullOrWhiteSpace(priceTxt.Text) || !(decimal.TryParse(priceTxt.Text, out decimal n)))   // If TextBox is empty or a letter is entered, color will be PaleGreen
                            {
                                priceTxt.BackColor = Color.PaleGreen;
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
                        if (string.IsNullOrWhiteSpace(maxTxt.Text) || !(int.TryParse(maxTxt.Text, out int n)))   // If TextBox is empty or a letter is entered, color will be PaleGreen
                            {
                                maxTxt.BackColor = Color.PaleGreen;
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
                        if (string.IsNullOrWhiteSpace(minTxt.Text) || !(int.TryParse(minTxt.Text, out int n)))     // If TextBox is empty or a letter is entered, color will be PaleGreen
                            {
                                minTxt.BackColor = Color.PaleGreen;
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

                private void searchProductTxt_TextChanged(object sender, EventArgs e)
                {
						if (string.IsNullOrWhiteSpace(searchProductTxt.Text) || !(int.TryParse(searchProductTxt.Text, out int n)))		// If TextBox is empty or a letter is entered, color will be PaleGreen
							{
								searchProductBtn.Enabled = false;
								searchProductTxt.BackColor = Color.PaleGreen;
							}
						else
							{
								searchProductBtn.Enabled = true;
								searchProductTxt.BackColor = Color.White;
							}
                }

		        private void searchProductBtn_Click(object sender, EventArgs e)
		            {
                        int searchPartID = Convert.ToInt32(searchProductTxt.Text);

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
                        Inventory.Products[productNumber].addAssociatedPart(Inventory.LookupPart(selectPart));
		            }

		        private void deletePartBtn_Click(object sender, EventArgs e)
		            {
                        DialogResult deletePartDR = MessageBox.Show("Are you sure?", "Delete Part", MessageBoxButtons.YesNo);

                            if (deletePartDR == DialogResult.Yes)
                                {
                                    int selectPart = Convert.ToInt32(associatedPartsDGV.Rows[associatedPartsDGV.CurrentCell.RowIndex].Cells[0].Value);    // Gets the part id number for the row selected
                                    Inventory.Products[productNumber].removeAssociatedPart(selectPart);
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
                        else if (Inventory.Products[productNumber].associatedPartsEmpty())
                            {
                                MessageBox.Show("You must add at least one associated part.", "Error");
                            }
                        else
                            {
                                Inventory.Products[productNumber].setName(nameTxt.Text);
                                Inventory.Products[productNumber].setPrice(Convert.ToDecimal(priceTxt.Text));
                                Inventory.Products[productNumber].setInStock(Convert.ToInt32(inventoryTxt.Text));
                                Inventory.Products[productNumber].setMin(Convert.ToInt32(minTxt.Text));
                                Inventory.Products[productNumber].setMax(Convert.ToInt32(maxTxt.Text));
                                Inventory.updateProduct(productNumber, Inventory.Products[productNumber]);
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