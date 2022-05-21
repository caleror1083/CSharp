/*
	C868 Software Development Capstone
	Robert Calero
	Student ID# 000998416
*/

using System;
using System.Globalization;
using System.Windows.Forms;

namespace WGU_C868
	{
		public partial class Login : Form
			{
				public string credentialsError = "The username and password did not match.";
				public string applicationExit = "Are you sure you wish to exit the application?";

				public Login()
					{
						InitializeComponent();
						CheckLanguage(CultureInfo.CurrentUICulture.LCID);
					}

				private void CheckLanguage(int myLCID)
					{
						if (myLCID == 1034)
							{
								this.Text = "Acceso";
								UserNameLbl.Text = "Nombre de usario";
								PasswordLbl.Text = "Contraseña";
								LoginBtn.Text = "Iniciar sesión";
								ExitBtn.Text = "Salida";
								credentialsError = "El nombre de usuario y la contraseña no coinciden.";
								applicationExit = "Quieres salir de la aplicación?";
							}
					}

				private void LoginBtn_Click(object sender, EventArgs e)
					{
						// Checks the database to confirm username and password credentials are correct
						if (Database.CheckUser(UserNameTxt.Text, PasswordTxt.Text) == 1)
							{
								// Login to application, saving username and current time to text file, open main page
								Log.Login(Database.GetUserName());
								Form scheduling = new Scheduling();
								Log.Reminder();
								scheduling.Show();
								this.Hide();
							}
						else
							{
								MessageBox.Show(credentialsError);
							}
					}

				private void ExitBtn_Click(object sender, EventArgs e)
					{
						var confirmation = MessageBox.Show(applicationExit, this.Text, MessageBoxButtons.YesNo);

						if (confirmation == DialogResult.Yes)
							{
								this.Close();
							}
					}
			}
	}