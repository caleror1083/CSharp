/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem
	{
		public partial class ModifyPart : Form
			{
				public int partNumber;				

				public ModifyPart(int selectRow)
					{
						InitializeComponent();
						idTxt.Text = selectRow.ToString();
						partNumber = selectRow;
					}

				private void ModifyPart_Load(object sender, EventArgs e)
					{
                        nameTxt.Text = Inventory.allParts[partNumber].getName();
                        inventoryTxt.Text = Inventory.allParts[partNumber].getInStock().ToString();
                        priceTxt.Text = Inventory.allParts[partNumber].getPrice().ToString();
                        maxTxt.Text = Inventory.allParts[partNumber].getMax().ToString();
                        minTxt.Text = Inventory.allParts[partNumber].getMin().ToString();
                        companyNameTxt.Text = Inventory.allParts[partNumber].getTypeInfo();

                        if (Inventory.allParts[partNumber].getType() == "inhouse")
                            {
                                inhouseRadBtn.Checked = true;
                            }
                        else if (Inventory.allParts[partNumber].getType() == "outsourced")
                            {
                                outsourcedRadBtn.Checked = true;
                            }
					}

                private void inhouseRadBtn_CheckedChanged(object sender, EventArgs e)
                    {
                        companyNameLbl.Text = "Machine ID";
                        companyNameLbl.Location = new Point(51, 213);
                        companyNameTip.SetToolTip(companyNameTxt, "Machine ID required");

                        if (string.IsNullOrWhiteSpace(companyNameTxt.Text) || (inhouseRadBtn.Checked && !(int.TryParse(companyNameTxt.Text, out int n))))
                            {
                                companyNameTxt.BackColor = Color.PaleGreen;
                                saveBtn.Enabled = false;
                                companyNameTip.Active = true;       // If the field is incorrect, ToolTip is displayed
                            }
                        else
                            {
                                companyNameTxt.BackColor = Color.White;
                                companyNameTip.Active = false;
                            }
                    }

                private void outsourcedRadBtn_CheckedChanged(object sender, EventArgs e)
                    {
                        companyNameLbl.Text = "Company Name";
                        companyNameLbl.Location = new Point(31, 213);
                        companyNameTip.SetToolTip(companyNameTxt, "Company Name required");

                        if (string.IsNullOrWhiteSpace(companyNameTxt.Text) || int.TryParse(nameTxt.Text, out int s))
                            {
                                companyNameTxt.BackColor = Color.PaleGreen;
                                saveBtn.Enabled = false;
                                companyNameTip.Active = true;       // If the field is incorrect, ToolTip is displayed
                            }
                        else
                            {
                                companyNameTxt.BackColor = Color.White;
                                companyNameTip.Active = false;
                            }
                    }

                private void nameTxt_TextChanged(object sender, EventArgs e)
                    {
						if (string.IsNullOrWhiteSpace(nameTxt.Text) || int.TryParse(nameTxt.Text, out int n))	// If TextBox is empty or a number is entered, color will be PaleGreen
							{
								nameTxt.BackColor = Color.PaleGreen;
								saveBtn.Enabled = false;
								nameTip.Active = true;		// If the field is incorrect, ToolTip is displayed
							}
						else
							{
								nameTxt.BackColor = Color.White;
								nameTip.Active = false;
							}

						if (nameTxt.BackColor == Color.White && inventoryTxt.BackColor == Color.White && priceTxt.BackColor == Color.White && maxTxt.BackColor == Color.White && minTxt.BackColor == Color.White && companyNameTxt.BackColor == Color.White)
							{
								saveBtn.Enabled = true;		// If info in all TextBoxes is valid, button is enabled
							}
                    }

                private void inventoryTxt_TextChanged(object sender, EventArgs e)
                    {
						if (string.IsNullOrWhiteSpace(inventoryTxt.Text) || !(int.TryParse(inventoryTxt.Text, out int n)))	// If TextBox is empty or a letter is entered, color will be PaleGreen
							{
								inventoryTxt.BackColor = Color.PaleGreen;
								saveBtn.Enabled = false;
								inventoryTip.Active = true;		// If the field is incorrect, ToolTip is displayed
							}
						else
							{
								inventoryTxt.BackColor = Color.White;
								inventoryTip.Active = false;
							}

						if (nameTxt.BackColor == Color.White && inventoryTxt.BackColor == Color.White && priceTxt.BackColor == Color.White && maxTxt.BackColor == Color.White && minTxt.BackColor == Color.White && companyNameTxt.BackColor == Color.White)
							{
								saveBtn.Enabled = true;		// If info in all TextBoxes is valid, button is enabled
							}
                    }

                private void priceTxt_TextChanged(object sender, EventArgs e)
                    {
						if (string.IsNullOrWhiteSpace(priceTxt.Text) || !(decimal.TryParse(priceTxt.Text, out decimal n)))	// If TextBox is empty or a letter is entered, color will be PaleGreen
							{
								priceTxt.BackColor = Color.PaleGreen;
								saveBtn.Enabled = false;
								priceTip.Active = true;		// If the field is incorrect, ToolTip is displayed
							}
						else
							{
								priceTxt.BackColor = Color.White;
								priceTip.Active = false;
							}

						if (nameTxt.BackColor == Color.White && inventoryTxt.BackColor == Color.White && priceTxt.BackColor == Color.White && maxTxt.BackColor == Color.White && minTxt.BackColor == Color.White && companyNameTxt.BackColor == Color.White)
							{
								saveBtn.Enabled = true;		// If info in all TextBoxes is valid, button is enabled
							}
                    }

                private void maxTxt_TextChanged(object sender, EventArgs e)
                    {
						if (string.IsNullOrWhiteSpace(maxTxt.Text) || !(int.TryParse(maxTxt.Text, out int n)))				// If TextBox is empty or a letter is entered, color will be PaleGreen
							{
								maxTxt.BackColor = Color.PaleGreen;
								saveBtn.Enabled = false;
								maxTip.Active = true;		// If the field is incorrect, ToolTip is displayed
							}
						else
							{
								maxTxt.BackColor = Color.White;
								maxTip.Active = false;
							}

						if (nameTxt.BackColor == Color.White && inventoryTxt.BackColor == Color.White && priceTxt.BackColor == Color.White && maxTxt.BackColor == Color.White && minTxt.BackColor == Color.White && companyNameTxt.BackColor == Color.White)
							{
								saveBtn.Enabled = true;		// If info in all TextBoxes is valid, button is enabled
							}
                    }

                private void minTxt_TextChanged(object sender, EventArgs e)
                    {
						if (string.IsNullOrWhiteSpace(minTxt.Text) || !(int.TryParse(minTxt.Text, out int n)))			// If TextBox is empty or a letter is entered, color will be PaleGreen
							{
								minTxt.BackColor = Color.PaleGreen;
								saveBtn.Enabled = false;
								minTip.Active = true;		// If the field is incorrect, ToolTip is displayed
							}
						else
							{
								minTxt.BackColor = Color.White;
								minTip.Active = false;
							}

						if (nameTxt.BackColor == Color.White && inventoryTxt.BackColor == Color.White && priceTxt.BackColor == Color.White && maxTxt.BackColor == Color.White && minTxt.BackColor == Color.White && companyNameTxt.BackColor == Color.White)
							{
								saveBtn.Enabled = true;		// If info in all TextBoxes is valid, button is enabled
							}
                    }

                private void companyNameTxt_TextChanged(object sender, EventArgs e)
                    {
						// In house parts only accept integer machine ids
						if (string.IsNullOrWhiteSpace(companyNameTxt.Text) || (inhouseRadBtn.Checked && !(int.TryParse(companyNameTxt.Text, out int n))) || (outsourcedRadBtn.Checked && int.TryParse(nameTxt.Text, out int s)))
							{
								companyNameTxt.BackColor = Color.PaleGreen;
								saveBtn.Enabled = false;

								if (inhouseRadBtn.Checked)
									{
										companyNameTip.SetToolTip(companyNameTxt, "Machine ID requires a number");
									}
								else if (outsourcedRadBtn.Checked)
									{
										companyNameTip.SetToolTip(companyNameTxt, "Company Name requires a value");
									}
								companyNameTip.Active = true;
							}
						else
							{
								companyNameTxt.BackColor = Color.White;
								companyNameTip.Active = false;
							}

						if (nameTxt.BackColor == Color.White && inventoryTxt.BackColor == Color.White && priceTxt.BackColor == Color.White && maxTxt.BackColor == Color.White && minTxt.BackColor == Color.White && companyNameTxt.BackColor == Color.White)
							{
								saveBtn.Enabled = true;		// If info in all TextBoxes is valid, button is enabled
							}
                    }

                private void saveBtn_Click(object sender, EventArgs e)
                    {
                        MainScreen mainScreenSave = new MainScreen();
                        Inhouse inhousePart;
                        Outsourced outsourcedPart;

						if (Convert.ToInt32(maxTxt.Text) > Convert.ToInt32(minTxt.Text))
							{
                                if (inhouseRadBtn.Checked)
                                    {
                                        inhousePart = new Inhouse();
                                        inhousePart.setPartID(partNumber);
                                        inhousePart.setName(nameTxt.Text.ToString());
                                        inhousePart.setPrice(Convert.ToDecimal(priceTxt.Text));
                                        inhousePart.setInStock(Convert.ToInt32(inventoryTxt.Text));
                                        inhousePart.setMin(Convert.ToInt32(minTxt.Text));
                                        inhousePart.setMax(Convert.ToInt32(maxTxt.Text));
                                        inhousePart.setMachineID(Convert.ToInt32(companyNameTxt.Text));
                                        Inventory.updatePart(partNumber, inhousePart);
                                    }
                                else if (outsourcedRadBtn.Checked)
                                    {
                                        outsourcedPart = new Outsourced();
                                        outsourcedPart.setPartID(partNumber);
                                        outsourcedPart.setName(nameTxt.Text.ToString());
                                        outsourcedPart.setPrice(Convert.ToDecimal(priceTxt.Text));
                                        outsourcedPart.setInStock(Convert.ToInt32(inventoryTxt.Text));
                                        outsourcedPart.setMin(Convert.ToInt32(minTxt.Text));
                                        outsourcedPart.setMax(Convert.ToInt32(maxTxt.Text));
                                        outsourcedPart.setCompanyName(companyNameTxt.Text);
                                        Inventory.updatePart(partNumber, outsourcedPart);
                                    }
                                this.Hide();
                                mainScreenSave.ShowDialog();
                            }
						else
							{
								MessageBox.Show("Min value is greater than the max value", "Error");
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