// Robert Calero - App displaying DB System
using System;
using System.Data;
using System.Data.SqlClient;

class Example    // Class declaration - a class defines the variables and methods used by objects
	{
		SqlConnection ConnectionToDB = new SqlConnection(@"Data Source=THEGAME1083;Initial Catalog=Practice;Integrated Security=True");		

		public void Results()
			{
				ConnectionToDB.Open();
				SqlCommand DisplayCommand = ConnectionToDB.CreateCommand();
				DataTable DisplayTable = new DataTable();
				SqlDataAdapter DisplayData = new SqlDataAdapter(DisplayCommand);
				DisplayCommand.CommandType = CommandType.Text;
				DisplayCommand.CommandText = "SELECT * FROM [Table]";
				DisplayData.Fill(DisplayTable);
				Console.WriteLine(DisplayTable);
				ConnectionToDB.Close();	
			}
	}