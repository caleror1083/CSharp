using System;
using System.Data.SqlClient;
using System.Text;

class Program
	{
		static void Main()
			{
				Console.WriteLine("Getting Connection ...");
				string myConnectionString = @"Data Source=ROB-DESKTOP\SQLEXPRESS;Integrated Security=True";    // The database connection string

				SqlConnection myConnection = new SqlConnection(myConnectionString);    // Creates an instance of the database connection

				try
					{
						Console.WriteLine("Opening Connection ...");
						myConnection.Open();    // Open connection to database

						Console.WriteLine("Connection successful!");
						
						// Create a new SQL Query using StringBuilder
						//StringBuilder myStringBuilder = new StringBuilder();
						//myStringBuilder.Append("INSERT INTO StudentDetails (Name, Email, Class) VALUES");
						//myStringBuilder.Append("('Robert', 'caleror1083@gmail.com', 'Software I'),");
						//myStringBuilder.Append("('Lance', 'lance84@gmail.com', 'Software II')");

						//string sqlQuery = myStringBuilder.ToString();

						//using (SqlCommand myCommand = new SqlCommand(sqlQuery, myConnection))
						//	{
						//		myCommand.ExecuteNonQuery();
						//		Console.WriteLine("Query Executed!");
						//	}
					}
				catch (Exception e)
					{
						Console.WriteLine("Error: " + e.Message);
					}
			}
	}