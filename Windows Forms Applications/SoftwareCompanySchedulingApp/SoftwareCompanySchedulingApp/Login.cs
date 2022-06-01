/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace SoftwareCompanySchedulingApp
	{
		public partial class Login : Form
			{
				public Login()
					{
						InitializeComponent();
					    // Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es-ES");  // Translation testing
					}

				bool UserLogin(string username, string password)
					{
						using (SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString()))
							{
								SqlCommand myCommand = new SqlCommand($"SELECT * FROM [user] WHERE userName = {username} AND password = {password}");
								myCommand.Connection = myConnection;
								DataSet myDataSet = new DataSet();
								SqlDataAdapter myDataAdapter = new SqlDataAdapter(myCommand);
								myDataAdapter.Fill(myDataSet);

								bool successful = (myDataSet.Tables.Count > 0) && (myDataSet.Tables[0].Rows.Count > 0);

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

				void LoginButton_Click(object sender, EventArgs e)
					{
						loginError.Text = "";

						if (UserLogin(usernameTxt.Text, passwordTxt.Text))
							{
								Hide();
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

				private void ExitButton_Click(object sender, EventArgs e)
					{
						MessageBox.Show(Properties.translations.res_login_exit);
						Application.Exit();
					}
			}
	}