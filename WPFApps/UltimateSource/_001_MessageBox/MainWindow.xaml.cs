using Microsoft.Data.Sqlite;
using System;
using System.Windows;

namespace _001_MessageBox
	{
		public partial class MainWindow : Window
			{
				public MainWindow()
					{
						InitializeComponent();
					}

				private void Btn1_Click(object sender, RoutedEventArgs e)
					{
						// create a new SQLite database connection
						SqliteConnection sqlite_conn = new SqliteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");

						// open the connection
						try {
						sqlite_conn.Open(); }
						catch (Exception ex) { }

						// create a new SQL command
						SqliteCommand sqlite_cmd = sqlite_conn.CreateCommand();

						// let the SQLiteCommand object know our SQL query
						sqlite_cmd.CommandText = "CREATE TABLE test (id integer primary key, text varchar(100));";

						sqlite_cmd.ExecuteNonQuery();

						sqlite_cmd.CommandText = "INSERT INTO test (id, text) VALUES (1, 'Test Text 1');";

						sqlite_cmd.ExecuteNonQuery();

						sqlite_cmd.CommandText = "INSERT INTO test (id, text) VALUES (2, 'Test Text 2');";

						sqlite_cmd.ExecuteNonQuery();

						sqlite_cmd.CommandText = "SELECT * FROM test";

						SqliteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();

						while (sqlite_datareader.Read())
							{
								// System.Console.WriteLine(sqlite_datareader["text"]);
								string data = sqlite_datareader.GetString(1);
								MessageBox.Show(data);
							}

						sqlite_conn.Close();

						MessageBox.Show("Hello");  // Displays a message when the button is clicked
					}
			}
	}