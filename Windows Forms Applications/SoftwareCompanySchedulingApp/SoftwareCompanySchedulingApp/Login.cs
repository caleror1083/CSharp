/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace SoftwareCompanySchedulingApp
	{
		public partial class Login : Form
			{
				public Login()
					{
						// Translation testing
					    // Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es-ES");
						InitializeComponent();
					}

				private bool loginUser(string username, string password)
					{
						using (MySqlConnection myConnection = new MySqlConnection(Properties.Resources.connectionString.ToString()))
							{
								MySqlCommand myCommand = new MySqlCommand($"SELECT * FROM user WHERE userName = '{username}' AND password = '{password}'");
								myCommand.Connection = myConnection;
								myConnection.Open();

								DataSet myDataSet = new DataSet();
								MySqlDataAdapter myDataAdapter = new MySqlDataAdapter(myCommand);
								myDataAdapter.Fill(myDataSet);
								myConnection.Close();

								bool successful = ((myDataSet.Tables.Count > 0) && (myDataSet.Tables[0].Rows.Count > 0));

								if (successful)
									{
										LoginControl.SetUserId(Convert.ToInt32(myDataSet.Tables[0].Rows[0].ItemArray[0]));
										LoginControl.SetUserName(myDataSet.Tables[0].Rows[0].ItemArray[1].ToString());
										return true;
									}
								else
									{
										return false;
									}								
							}
					}

				private void loginBtn_Click(object sender, EventArgs e)
					{
						loginError.Text = "";

						if (loginUser(usernameTxt.Text, passwordTxt.Text))
							{
								this.Hide();
								Scheduling scheduling = new Scheduling();
								Log.Login(usernameTxt.Text);
								scheduling.Show();
							}
						else
							{
								loginError.Text = Properties.translations.res_login_error;
								usernameTxt.Text = "";
								passwordTxt.Text = "";
							}
					}

				private void exitBtn_Click(object sender, EventArgs e)
					{
						MessageBox.Show(Properties.translations.res_login_exit);
						Application.Exit();
					}
			}
	}