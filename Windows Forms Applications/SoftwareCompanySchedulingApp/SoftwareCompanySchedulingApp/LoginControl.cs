/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

// Namespaces
namespace SoftwareCompanySchedulingApp
	{
        // Classes
		class LoginControl
			{
                // Fields
                private static int _UserID;
                private static string _UserName;
                private static Dictionary<int, Hashtable> _appts = new Dictionary<int, Hashtable>();

                // Properties
                public static int UserID { get; }
                public static string UserName { get; }

                // Methods(Parameters)
                public static void SetUserID(int userId)
                    {
                        _UserID = userId;
                    }

                public static void SetUserName(string userName)
                    {
                        _UserName = userName;
                    }

                public static Dictionary<int, Hashtable> GetAppts()
                    {
                        return _appts;
                    }

                public static void SetAppts(Dictionary<int, Hashtable> appts)
                    {
                        _appts = appts;
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
                        SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
                        myConnection.Open();
                        SqlCommand myCommand = new SqlCommand("SELECT @TblId FROM @Table", myConnection);
                        myCommand.Parameters.AddWithValue("@Table", tbl);
                        myCommand.Parameters.AddWithValue("@TblId", tbl + "Id");
                        SqlDataReader myReader = myCommand.ExecuteReader();
                        List<int> listId = new List<int>();
                        while (myReader.Read())
                            {
                                listId.Add(Convert.ToInt32(myReader[0]));
                            }
                        myReader.Close();
                        myConnection.Close();
                        return NewId(listId);
                    }

                public static int CreateRec(string stamp, string user_Name, string tbl, string query, int user_Id = 0)
                    {
                        int recordId = CreateID(tbl);
                        string insert;
                        if (user_Id == 0)
                            {
                                insert = $"INSERT INTO @Table " +
                                         $"VALUES (@RecordID, @Query, @Stamp, @UserName, @Stamp, @UserName)";
                            }
                        else
                            {
                                insert = $"INSERT INTO @Table ([appointmentId], [customerId], [start], [end], [type], [userId], [createDate], [createdBy], [lastUpdate], [lastUpdateBy]) " +
                                         $"VALUES (@RecordID, @Query, @UserId, @Stamp, @UserName, @Stamp, @UserName)";
                            }
                        SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
                        myConnection.Open();
                        SqlCommand myCommand = new SqlCommand(insert, myConnection);
                        myCommand.Parameters.AddWithValue("@Table", tbl);
                        myCommand.Parameters.AddWithValue("@RecordID", recordId);
                        myCommand.Parameters.AddWithValue("@Query", query);
                        myCommand.Parameters.AddWithValue("@UserId", user_Id);
                        myCommand.Parameters.AddWithValue("@Stamp", stamp);
                        myCommand.Parameters.AddWithValue("@UserName", user_Name);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();

                        return recordId;
                    }     

                public static int FindCust(string find)
                    {
                        string myQuery;
                        
                        if (int.TryParse(find, out int custId))
                            {
                                myQuery = $"SELECT [customerId] " +
                                          $"FROM [customer] " +
                                          $"WHERE [customerId] = @Find";
                            }
                        else
                            {
                                myQuery = $"SELECT [customerId] " +
                                          $"FROM [customer] " +
                                          $"WHERE [customerName] LIKE @Find";
                            }
                        SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
                        myConnection.Open();
                        SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
                        myCommand.Parameters.AddWithValue("@Find", find);
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
                        string myQuery = $"SELECT * " +
                                         $"FROM [customer] " +
                                         $"WHERE [customerId] = @CustID";
                        SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
                        myConnection.Open();
                        SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
                        myCommand.Parameters.AddWithValue("@CustID", custId);
                        SqlDataReader myReader = myCommand.ExecuteReader();
                        myReader.Read();

                        Dictionary<string, string> custDict = new Dictionary<string, string>();

                        // Customer Table Details
						custDict.Add("customerId", myReader[0].ToString());
						custDict.Add("customerName", myReader[1].ToString());
						custDict.Add("addressId", myReader[2].ToString());
						custDict.Add("active", myReader[3].ToString());
                        myReader.Close();

                        myQuery = $"SELECT * " +
                                  $"FROM [address] " +
                                  $"WHERE [addressId] = @CustDict";
                        myCommand = new SqlCommand(myQuery, myConnection);
                        myReader = myCommand.ExecuteReader();
                        myCommand.Parameters.AddWithValue("@CustDict", custDict["addressId"]);
                        myReader.Read();

                        // Address Table Details
                        custDict.Add("address", myReader[1].ToString());
                        custDict.Add("cityId", myReader[3].ToString());
                        custDict.Add("postalCode", myReader[4].ToString());
                        custDict.Add("phone", myReader[5].ToString());
                        myReader.Close();

                        myQuery = $"SELECT * " +
                                  $"FROM [city] " +
                                  $"WHERE [cityId] = @CityID";
                        myCommand = new SqlCommand(myQuery, myConnection);
                        myReader = myCommand.ExecuteReader();
                        myCommand.Parameters.AddWithValue("@CityID", custDict["cityId"]);
                        myReader.Read();

                        // City Table Details
                        custDict.Add("city", myReader[1].ToString());
                        custDict.Add("countryId", myReader[2].ToString());
                        myReader.Close();

                        myQuery = $"SELECT * " +
                                  $"FROM [country] " +
                                  $"WHERE [countryId] = @CountryID";
                        myCommand = new SqlCommand(myQuery, myConnection);
                        myReader = myCommand.ExecuteReader();
                        myCommand.Parameters.AddWithValue("@CountryID", custDict["countryId"]);
                        myReader.Read();

                        // Country Table Details
                        custDict.Add("country", myReader[1].ToString());
                        myReader.Close();
                        myConnection.Close();
                        return custDict;
                    }

                public static Dictionary<string, string> ApptDetails(string apptId)
                    {
                        string myQuery = $"SELECT * " +
                                         $"FROM [appointment] " +
                                         $"WHERE [appointmentId] = @ApptID";
                        SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
                        myConnection.Open();
                        SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
                        myCommand.Parameters.AddWithValue("@ApptID", apptId);
                        SqlDataReader myReader = myCommand.ExecuteReader();
                        myReader.Read();

                        Dictionary<string, string> apptDict = new Dictionary<string, string>();

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
	}