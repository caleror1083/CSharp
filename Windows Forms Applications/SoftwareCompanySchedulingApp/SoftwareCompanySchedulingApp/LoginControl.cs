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

namespace SoftwareCompanySchedulingApp
	{
		class LoginControl
			{
                private static int user_Id;
                private static string user_Name;
                private static Dictionary<int, Hashtable> _appts = new Dictionary<int, Hashtable>();

                public static int GetUserId()
                    {
                        return user_Id;
                    }

                public static void SetUserId(int userId)
                    {
                        user_Id = userId;
                    }

                public static string GetUserName()
                    {
                        return user_Name;
                    }

                internal static void SetUserName(string userName)
                    {
                        user_Name = userName;
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
                        SqlCommand myCommand = new SqlCommand($"SELECT {tbl + "Id"} " +
                                                                  $"FROM {tbl}", myConnection);
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

                static public int CreateRec(string stamp, string user_Name, string tbl, string query, int user_Id = 0)
                    {
                        int recordId = CreateID(tbl);
                        string insert;
                        if (user_Id == 0)
                            {
                                insert = $"INSERT INTO {tbl} " +
                                         $"VALUES ('{recordId}', {query}, '{stamp}', '{user_Name}', '{stamp}', '{user_Name}')";
                            }
                        else
                            {
                                insert = $"INSERT INTO {tbl} (appointmentId, customerId, start, end, type, userId, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                                         $"VALUES ('{recordId}', {query}, '{user_Id}', '{stamp}', '{user_Name}', '{stamp}', '{user_Name}')";
                            }
                        SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
                        myConnection.Open();
                        SqlCommand myCommand = new SqlCommand(insert, myConnection);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();

                        return recordId;
                    }     

                static public int FindCust(string find)
                    {
                        int custId;
                        string myQuery;
                        
                        if (int.TryParse(find, out custId))
                            {
                                myQuery = $"SELECT customerId " +
                                          $"FROM customer " +
                                          $"WHERE customerId = '{find}'";
                            }
                        else
                            {
                                myQuery = $"SELECT customerId " +
                                          $"FROM customer " +
                                          $"WHERE customerName LIKE '{find}'";
                            }
                        SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
                        myConnection.Open();
                        SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
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

                static public Dictionary<string, string> CustDetails(int custId)
                    {
                        string myQuery = $"SELECT * " +
                                         $"FROM customer " +
                                         $"WHERE customerId = '{custId}'";
                        SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
                        myConnection.Open();
                        SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
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
                                  $"FROM address " +
                                  $"WHERE addressId = '{custDict["addressId"]}'";
                        myCommand = new SqlCommand(myQuery, myConnection);
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();

                        // Address Table Details
                        custDict.Add("address", myReader[1].ToString());
                        custDict.Add("cityId", myReader[3].ToString());
                        custDict.Add("postalCode", myReader[4].ToString());
                        custDict.Add("phone", myReader[5].ToString());
                        myReader.Close();

                        myQuery = $"SELECT * " +
                                  $"FROM city " +
                                  $"WHERE cityId = '{custDict["cityId"]}'";
                        myCommand = new SqlCommand(myQuery, myConnection);
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();

                        // City Table Details
                        custDict.Add("city", myReader[1].ToString());
                        custDict.Add("countryId", myReader[2].ToString());
                        myReader.Close();

                        myQuery = $"SELECT * " +
                                  $"FROM country " +
                                  $"WHERE countryId = '{custDict["countryId"]}'";
                        myCommand = new SqlCommand(myQuery, myConnection);
                        myReader = myCommand.ExecuteReader();
                        myReader.Read();

                        // Country Table Details
                        custDict.Add("country", myReader[1].ToString());
                        myReader.Close();
                        myConnection.Close();
                        return custDict;
                    }

                static public Dictionary<string, string> ApptDetails(string apptId)
                    {
                        string myQuery = $"SELECT * " +
                                         $"FROM appointment " +
                                         $"WHERE appointmentId = '{apptId}'";
                        SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
                        myConnection.Open();
                        SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
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

                static public string ConvertToTimezone(string time)
                    {
                        DateTime utcTime = DateTime.Parse(time.ToString());
                        DateTime localTime = utcTime.ToLocalTime();
                        
                        return localTime.ToString("MM/dd/yyyy hh:mm tt");
                    }
            }
	}