// Robert Calero
// Login Form - C# - Windows Form Application .NET Framework

using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
    {
            public partial class LoginForm : Form
                {
                    public LoginForm()
                        {
                            InitializeComponent();
                        }

                    private void Exit_Click(object sender, System.EventArgs e)
                        {
                            Application.Exit();                        // Closes the application
                        }

                    private void LoginMain_Click(object sender, System.EventArgs e)
                        {
                            SqlConnection MyConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\THEGAME1083\SOURCE\REPOS\PROJECTS\DATABASE FILES\MICROSOFT SQL SERVER\DATA.MDF;Integrated Security=True;Connect Timeout=30"); // Connects to Database file
                            SqlDataAdapter FetchData = new SqlDataAdapter("Select Count(*) From LoginTable Where UserName='" + UserNameInfo.Text + "' and Password='" + PasswordInfo.Text + "'", MyConnection); // Runs SQL query from Table data in Database file
                            DataTable DTable = new DataTable(); // if any information is correct, count will be 1. If incorrect it will be 0

                            FetchData.Fill(DTable);
                            if (DTable.Rows[0][0].ToString() == "1")
                                {
                                    Hide();                         // Hides the LoginForm when the button is clicked
                                    Main LinkToMain = new Main();   // Creates an object of the Main class

                                    LinkToMain.Show();              // Displays the Main form
                                }
                            else
                                {
                                    MessageBox.Show("Invalid Username and/or Password credentials", "Error");
                                }
                         }

                    private void LoginMainMySql_Click(object sender, System.EventArgs e)
                        {
                            MySqlConnection MySqlConnectionTest = new MySqlConnection(@"server=localhost;user id=root;database=mysqldata"); // Connects to Database file
                            MySqlDataAdapter FetchMySqlData = new MySqlDataAdapter("Select Count(*) From loginform Where UserName='" + UserNameInfo.Text + "' and Password='" + PasswordInfo.Text + "'", MySqlConnectionTest); // Runs MySQL query from Table data in Database file
                            DataTable MySqlDTable = new DataTable(); // if any information is correct, count will be 1. If incorrect it will be 0

                            FetchMySqlData.Fill(MySqlDTable);
                            if (MySqlDTable.Rows[0][0].ToString() == "1")
                                {
                                    Hide();                         // Hides the LoginForm when the button is clicked
                                    Main LinkToMain = new Main();   // Creates an object of the Main class

                                    LinkToMain.Show();              // Displays the Main form
                                }
                            else
                                {
                                    MessageBox.Show("Invalid Username and/or Password credentials", "Error");
                                }
                        }
                }
    }