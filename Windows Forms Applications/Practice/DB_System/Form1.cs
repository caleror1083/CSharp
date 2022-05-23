using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBsystem
{
	public partial class Form1 : Form
	{
		SqlConnection ConnectionToDB = new SqlConnection(@"Data Source=THEGAME1083;Initial Catalog=Practice;Integrated Security=True");

		public Form1()
		{
		InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			ConnectionToDB.Open();
			SqlCommand InsertCommand = ConnectionToDB.CreateCommand();
			InsertCommand.CommandType = CommandType.Text;
			InsertCommand.CommandText = "INSERT INTO [Table] (Name, Surname, Address) VALUES ('"+textBox1.Text+"', '"+textBox2.Text+"', '"+textBox3.Text+"')";
			InsertCommand.ExecuteNonQuery();
			ConnectionToDB.Close();

			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			Display_Data();
			MessageBox.Show("Data inserted successfully");
		}
	// To display data
	public void Display_Data()
		{
			ConnectionToDB.Open();
			SqlCommand DisplayCommand = ConnectionToDB.CreateCommand();
			DataTable DisplayTable = new DataTable();
			SqlDataAdapter DisplayData = new SqlDataAdapter(DisplayCommand);
			DisplayCommand.CommandType = CommandType.Text;
			DisplayCommand.CommandText = "SELECT * FROM [Table]";
			DisplayData.Fill(DisplayTable);
			dataGridView1.DataSource = DisplayTable;
			ConnectionToDB.Close();

		}

		private void button5_Click(object sender, EventArgs e)
		{
			Display_Data();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ConnectionToDB.Open();
			SqlCommand DeleteCommand = ConnectionToDB.CreateCommand();
			DeleteCommand.CommandType = CommandType.Text;
			DeleteCommand.CommandText = "DELETE FROM [Table] WHERE name = '" + textBox1.Text + "'";
			DeleteCommand.ExecuteNonQuery();
			ConnectionToDB.Close();

			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			Display_Data();
			MessageBox.Show("Data deleted successfully");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ConnectionToDB.Open();
			SqlCommand UpdateCommand = ConnectionToDB.CreateCommand();
			UpdateCommand.CommandType = CommandType.Text;
			UpdateCommand.CommandText = "UPDATE [Table] SET name = '" + textBox1.Text + "' WHERE name = '"+textBox2.Text+"'";
			UpdateCommand.ExecuteNonQuery();
			ConnectionToDB.Close();

			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			Display_Data();
			MessageBox.Show("Data updated successfully");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			ConnectionToDB.Open();
			SqlCommand SearchCommand = ConnectionToDB.CreateCommand();
			DataTable DisplayTable = new DataTable();
			SqlDataAdapter DisplayData = new SqlDataAdapter(SearchCommand);
			SearchCommand.CommandType = CommandType.Text;
			SearchCommand.CommandText = "SELECT * FROM [Table] WHERE name = '" + textBox4.Text + "'";
			SearchCommand.ExecuteNonQuery();
			DisplayData.Fill(DisplayTable);
			dataGridView1.DataSource = DisplayTable;
			ConnectionToDB.Close();

			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
		}
	}
}
