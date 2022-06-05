using System;
using System.Globalization;
using System.Windows.Forms;

// Namespaces
namespace DentalOfficeSchedulingApp
	{
		// Classes
		public partial class Login : Form
			{
				// Fields
				private string _CredentialsError = "The username and password did not match.";
				private string _ApplicationExit = "Are you sure you wish to exit the application?";

				// Constructors(Parameters)
				public Login()
					{
						InitializeComponent();
						CheckLanguage(CultureInfo.CurrentUICulture.LCID);
					}

				// Methods(Parameters)
				private void CheckLanguage(int myLCID)
					{
						if (myLCID == 1034)
							{
								Text = "Acceso";
								UserNameLbl.Text = "Nombre de usario";
								PasswordLbl.Text = "Contraseña";
								LoginBtn.Text = "Iniciar sesión";
								ExitBtn.Text = "Salida";
								_CredentialsError = "El nombre de usuario y la contraseña no coinciden.";
								_ApplicationExit = "Quieres salir de la aplicación?";
							}
					}

				private void LoginBtn_Click(object sender, EventArgs e)
					{
						if (Database.CheckUser(UserNameTxt.Text, PasswordTxt.Text) == 1)  // Checks the database to confirm username and password credentials are correct
							{								
								Log.Login(Database.GetUserName());  // Login to application
								Form scheduling = new Scheduling();
								Log.Reminder();  // Saving username and current time to text file
								scheduling.Show();  // Open main page
								Hide();
							}
						else
							{
								MessageBox.Show(_CredentialsError);
							}
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						var confirmation = MessageBox.Show(_ApplicationExit, Text, MessageBoxButtons.YesNo);

						if (confirmation == DialogResult.Yes)
							{
								Close();
							}
					}
			}
	}