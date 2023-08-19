using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCompanyScheduling;

internal class LoginControl
{
    private static int _UserID;
    private static string _UserName;
    private static Dictionary<int, Hashtable> _Appts = new();

    public static int GetUserId()
    {
        return _UserID;
    }

    public static void SetUserId(int value)
    {
        _UserID = value;
    }

    public static string GetUserName()
    {
        return _UserName;
    }

    public static void SetUserName(string value)
    {
        _UserName = value;
    }

    public static Dictionary<int, Hashtable> GetAppts()
    {
        return _Appts;
    }

    public static void SetAppts(Dictionary<int, Hashtable> value)
    {
        _Appts = value;
    }

    public static int NewId(List<int> listId)
    {
        int mainId = 0;

        foreach (int id in listId)
        {
            if (id > mainId)
            {
                mainId = id;
            }
        }

        return mainId + 1;
    }

    public static string CreateStamp()
    {
        return DateTime.Now.ToString("u");
    }

    public static int CreateID(string tbl)
    {
        var myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
        myConnection.Open();
        var myCommand = new SqlCommand($"SELECT {tbl + "Id"} FROM {tbl}", myConnection);
        SqlDataReader myReader = myCommand.ExecuteReader();
        var listId = new List<int>();

        while (myReader.Read())
        {
            listId.Add(Convert.ToInt32(myReader[0]));
        }

        myReader.Close();
        myConnection.Close();
        return NewId(listId);
    }

    public static int CreateRec(string stamp, string user_name, string tbl, string query, int user_Id = 0)
    {
        var recordId = CreateID(tbl);
        string insert;
        
        if (user_Id == 0)
        {
            insert = $"INSERT INTO {tbl} VALUES ({recordId}, {query}, '{stamp}', '{user_name}', '{stamp}', '{user_name}')";
        }
        else
        {
            insert = $"INSERT INTO {tbl} (appointmentId, customerId, start, end, type, userId, createDate, createdBy, lastUpdate, lastUpdateBy)" + $"VALUES ({recordId}, {query}, '{user_Id}' '{stamp}', '{user_name}', '{stamp}', '{user_name}')";
        }

        var myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
        myConnection.Open();
        var myCommand = new SqlCommand(insert, myConnection);
        myCommand.ExecuteNonQuery();
        myConnection.Close();

        return recordId;
    }

    public static int FindCust(string find)
    {
        int custId;
        string myQuery;

        if (int.TryParse(find, out custId))
        {
            myQuery = $"SELECT customerId FROM customer WHERE customerId = {find.ToString()}";
        }
        else
        {
            myQuery = $"SELECT customerId FROM customer WHERE customerName LIKE '{find}'";
        }

        var myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
        myConnection.Open();
        var myCommand = new SqlCommand(myQuery, myConnection);
        SqlDataReader myReader = myCommand.ExecuteReader();

        if (myReader.HasRows)
        {
            myReader.Read();
            custId = Convert.ToInt32(myReader[0]);
            myReader.Close();
            myConnection.Close();
            return custId;
        }

        return 0;
    }

    public static Dictionary<string, string> CustDetails(int custId)
    {
        string myQuery = $"SELECT * FROM customer WHERE customerId = {custId.ToString()}";
        var myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
        myConnection.Open();
        var myCommand = new SqlCommand(myQuery, myConnection);
        SqlDataReader myReader = myCommand.ExecuteReader();
        myReader.Read();
        var custDict = new Dictionary<string, string>();

        // Customer Table Details
        custDict.Add("customerId", myReader[0].ToString());
        custDict.Add("customerName", myReader[1].ToString());
        custDict.Add("addressId", myReader[2].ToString());
        custDict.Add("active", myReader[3].ToString());
        myReader.Close();
        myQuery = $"SELECT * FROM address WHERE addressId = {custDict["addressId"]}";
        myCommand = new SqlCommand(myQuery, myConnection);
        myReader = myCommand.ExecuteReader();
        myReader.Read();

        // Address Table Details
        custDict.Add("address", myReader[1].ToString());
        custDict.Add("cityId", myReader[3].ToString());
        custDict.Add("postalCode", myReader[4].ToString());
        custDict.Add("phone", myReader[5].ToString());
        myReader.Close();
        myQuery = $"SELECT * FROM city WHERE cityId = {custDict["cityId"]}";
        myCommand = new SqlCommand(myQuery, myConnection);
        myReader = myCommand.ExecuteReader();
        myReader.Read();

        // City Table Details
        custDict.Add("city", myReader[1].ToString());
        custDict.Add("countryId", myReader[2].ToString());
        myReader.Close();
        myQuery = $"SELECT * FROM country WHERE countryId = {custDict["countryId"]}";
        myCommand = new SqlCommand(myQuery, myConnection);
        myReader = myCommand.ExecuteReader();
        myReader.Read();

        // Country Table Details
        custDict.Add("country", myReader[1].ToString());
        myReader.Close();
        myConnection.Close();
        return custDict;
    }

    public static Dictionary<string, string> ApptDetails(string apptId)
    {
        string myQuery = $"SELECT * FROM appointment WHERE appointmentId = {apptId}";
        var myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
        myConnection.Open();
        var myCommand = new SqlCommand(myQuery, myConnection);
        SqlDataReader myReader = myCommand.ExecuteReader();
        myReader.Read();
        var apptDict = new Dictionary<string, string>();

        // Appointment Table Details
        apptDict.Add("appointmentId", apptId);
        apptDict.Add("customerId", myReader[1].ToString());
        apptDict.Add("type", myReader[7].ToString());
        apptDict.Add("start", myReader[9].ToString());
        apptDict.Add("end", myReader[10].ToString());
        myReader.Close();
        return apptDict;
    }

    public static string ConvertToTimezone(string time)
    {
        DateTime utcTime = DateTime.Parse(time.ToString());
        DateTime localTime = utcTime.ToLocalTime();
        return localTime.ToString("MM/dd/yyyy hh:mm tt");
    }
}