using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AddressBook
	{
		public partial class MainForm : Form
			{
				readonly DataTable dt = new DataTable();
				int currentRow = 0;

				public MainForm()
					{
						InitializeComponent();
					}

				private void FormLoad(object sender, EventArgs e)
					{
						// SQL Server: ROB-DESKTOP\SQLEXPRESS
						// Database: AddressBook
						// Table: AddressBookTable
						string connectionString = @"Data Source=ROB-DESKTOP\SQLEXPRESS;Initial Catalog=AddressBook;Integrated Security=True;";
						string queryString = "SELECT * FROM AddressBookTable";
						SqlDataAdapter da = new SqlDataAdapter(queryString, connectionString);

						try
							{
								da.Fill(dt);
							}
						catch
							{
								MessageBox.Show("Error occurred!");
							}
						DisplayData(currentRow);
					}

				private void DisplayData(int currentRowParam)
					{
						txtName.Text = dt.Rows[currentRowParam]["Name"].ToString();
						txtAddress.Text = dt.Rows[currentRowParam]["Address"].ToString();
						txtPhone.Text = dt.Rows[currentRowParam]["PhoneNumber"].ToString();
					}

				private void ButtonNext(object sender, EventArgs e)
					{
						currentRow++;

						if (currentRow > dt.Rows.Count - 1)
							{
								currentRow = 0;
							}
						DisplayData(currentRow);
			
					}

				private void ButtonPrevious(object sender, EventArgs e)
					{
						currentRow--;

						if (currentRow < 0)
						{
							currentRow = dt.Rows.Count - 1;
						}
						DisplayData(currentRow);
					}

				private void ButtonExit(object sender, EventArgs e)
					{
						Close();
					}
			}
	}