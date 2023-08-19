using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareCompanyScheduling;

public partial class Login : Form
{
    public Login()
    {
        // Translation testing
        // Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es-ES");
        InitializeComponent();
    }

    private bool LoginUser(string username, string password)
    {
        using (var myConnection = new SqlConnection(Properties.Resources.connectionString.ToString()))
        {
            var mySqlCommand = new SqlCommand($"SELECT * FROM [user] WHERE [userName] = @userName AND [password] = @password")
            {
                Connection = myConnection
            };

            mySqlCommand.Parameters.AddWithValue("@userName", username);
            mySqlCommand.Parameters.AddWithValue("@password", password);
            var myDataSet = new DataSet();
            var myDataAdapter = new SqlDataAdapter(mySqlCommand);
            myDataAdapter.Fill(myDataSet);
            myConnection.Close();

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

    private void LoginBtn_Click(object sender, EventArgs e)
    {
        LoginErrorLbl.Text = "";

        if (LoginUser(UsernameTxt.Text, PasswordTxt.Text))
        {
            Hide();
            var scheduling = new Scheduling();
            Log.Login(UsernameTxt.Text);
            scheduling.Show();
        }
        else
        {
            LoginErrorLbl.Text = Properties.Translations.res_login_error;
            UsernameTxt.Text = "";
            PasswordTxt.Text = "";
        }
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        MessageBox.Show(Properties.Translations.res_login_exit);
        Application.Exit();
    }
}