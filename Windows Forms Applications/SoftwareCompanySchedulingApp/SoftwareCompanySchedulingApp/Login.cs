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

// Namespaces
namespace SoftwareCompanySchedulingApp
	{
		// Classes
		public partial class Login : Form
			{
				// Constructors
				public Login()
					{
						InitializeComponent();
					    // Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es-ES");  // Spanish translation
					}

				// Methods(Parameters)
				private static bool UserLogin(string username, string password)
					{
						using (SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString()))
							{
								SqlCommand myCommand = new SqlCommand("SELECT * FROM [user] WHERE [userName] = @userName AND [password] = @password")
									{
										Connection = myConnection
									};
								myCommand.Parameters.AddWithValue("@username", username);
								myCommand.Parameters.AddWithValue("@password", password);
								DataSet myDataSet = new DataSet();
								SqlDataAdapter myDataAdapter = new SqlDataAdapter(myCommand);
								myDataAdapter.Fill(myDataSet);

								bool successful = (myDataSet.Tables.Count > 0) && (myDataSet.Tables[0].Rows.Count > 0);

								if (successful)
									{
										LoginControl.SetUserID(Convert.ToInt32(myDataSet.Tables[0].Rows[0].ItemArray[0]));
										LoginControl.SetUserName(myDataSet.Tables[0].Rows[0].ItemArray[1].ToString());
										return true;
									}
								else
									{
										return false;
									}								
							}
					}

				private void LoginButton_Click(object sender, EventArgs e)
					{
						LoginError.Text = "";

						if (UserLogin(UsernameTxt.Text, PasswordTxt.Text))
							{
								Hide();
								Scheduling scheduling = new Scheduling();
								Log.Login(UsernameTxt.Text);
								scheduling.Show();
							}
						else
							{
								LoginError.Text = Properties.translations.res_login_error;
								UsernameTxt.Text = "";
								PasswordTxt.Text = "";
							}
					}

				private void ExitButton_Click(object sender, EventArgs e)
					{
						MessageBox.Show(Properties.translations.res_login_exit);
						Application.Exit();
					}
			}
	}