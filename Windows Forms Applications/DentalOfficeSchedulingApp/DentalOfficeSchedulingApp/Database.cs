using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

// Namespaces
namespace DentalOfficeSchedulingApp
	{
		// Classes
		class Database
			{
				// Fields
				private static int user_Id;
				private static string user_Name;
				private static Dictionary<int, Hashtable> myAppointments = new Dictionary<int, Hashtable>();

				// Properties
				public static int GetUserID()
					{
						return user_Id;
					}

				public static void SetUserID(int myCurrentUserID)
					{
						user_Id = myCurrentUserID;
					}

				public static string GetUserName()
					{
						return user_Name;
					}

				public static void SetUserName(string myCurrentUserName)
					{
						user_Name = myCurrentUserName;
					}

				public static Dictionary<int, Hashtable> GetAppointments()
					{
						return myAppointments;
					}

				public static void SetAppointments(Dictionary<int, Hashtable> myCurrentAppointments)
					{
						myAppointments = myCurrentAppointments;
					}

				// Constructors

				// Methods(Parameters)
				internal static string GetConnectionString() => Properties.Resources.connectionString.ToString();

				internal static int CheckUser(string activeUser, string activePassword)
					{
						// using statement
						using (SqlConnection myConnection = new SqlConnection(GetConnectionString()))
							{
								myConnection.Open();
								SqlCommand myCommand = new SqlCommand($"SELECT userId, userName FROM user WHERE userName = @ActiveUser AND password = @ActivePassword") { Connection = myConnection };
								myCommand.Parameters.AddWithValue("@ActiveUser", $"{activeUser}");
								myCommand.Parameters.AddWithValue("@ActivePassword", $"{activePassword}");
								SqlDataReader myReader = myCommand.ExecuteReader();

								if (myReader.HasRows)
									{
										myReader.Read();
										SetUserID(Convert.ToInt32(myReader[0]));
										SetUserName(Convert.ToString(myReader[1]));
										myReader.Close();
										myConnection.Close();
										return 1;
									}
								myConnection.Close();
								return 0;
							}
					}

				// Get ID for Records
				internal static int GetID(string myTable, string myID)
					{
						SqlConnection myConnection = new SqlConnection(GetConnectionString());
						myConnection.Open();

						string myQuery = $"SELECT MAX({myID}) FROM {myTable}";

						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlDataReader myReader = myCommand.ExecuteReader();

						myReader.Read();
						if (myReader.HasRows)
							{
								if (myReader.GetString(0) == string.Empty)
									{
										return 0;
									}
								return Convert.ToInt32(myReader.GetString(0));
							}
						myReader.Close();
						return 0;
					}

				internal static DateTime GetTime() => DateTime.Now.ToUniversalTime();

				// Creates new user
				internal static void CreateUser(int myUserID, string myUserName, string myPassword, int myActive, DateTime myDateTime, string myUser)
					{
						string mySqlDate = DateSqlFormat(myDateTime);
						SqlConnection myConnection = new SqlConnection(GetConnectionString());
						myConnection.Open();

						SqlTransaction myTransaction = myConnection.BeginTransaction();
						string myQuery = $"INSERT INTO user (userId, userName, password, active, createDate, createdBy, lastUpdateBy)" +
						                 $"VALUES (@UserID, @UserName, @Password, @Active, @DateTime, @User, @User)";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						myCommand.Parameters.AddWithValue("@UserID", $"{myUserID}");
						myCommand.Parameters.AddWithValue("@UserName", $"{myUserName}");
						myCommand.Parameters.AddWithValue("@Password", $"{myPassword}");
						myCommand.Parameters.AddWithValue("@Active", $"{myActive}");
						myCommand.Parameters.AddWithValue("@DateTime", $"{mySqlDate}");
						myCommand.Parameters.AddWithValue("@User", $"{myUser}");
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
					}

				// Create Country Record
				internal static int CreateCountry(string myCountry)
					{
						int myCountryID = GetID("country", "countryID") + 1;
						string myUser = GetUserName();
						string myDateTime = DateSqlFormat(GetTime());

						SqlConnection myConnection = new SqlConnection(GetConnectionString());
						myConnection.Open();

						SqlTransaction myTransaction = myConnection.BeginTransaction();
						string myQuery = $"INSERT INTO country (countryId, country, createDate, createdBy, lastUpdateBy)" +
							             $"VALUES ('{myCountryID}', '{myCountry}', '{myDateTime}', '{myUser}', '{myUser}')";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection)
						    {
							    Transaction = myTransaction
							};
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
						return myCountryID;
					}

				// Create City Record
				public static int CreateCity(int myCountryID, string myCity)
					{
						int myCityID = GetID("city", "cityID") + 1;
						string myUser = GetUserName();
						string myDateTime = DateSqlFormat(GetTime());

						SqlConnection myConnection = new SqlConnection(GetConnectionString());
						myConnection.Open();

						SqlTransaction myTransaction = myConnection.BeginTransaction();
						string myQuery = $"INSERT INTO city (cityId, city, countryId, createDate, createdBy, lastUpdateBy)" +
							             $"VALUES ('{myCityID}', '{myCity}', '{myCountryID}', '{myDateTime}', '{myUser}', '{myUser}')";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection)
							{
								Transaction = myTransaction
							};
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
						return myCityID;
					}

				// Create Address Record
				public static int CreateAddress(int myCityID, string myAddress, string myZipCode, string myPhone)
					{
						int myAddressID = GetID("address", "addressID") + 1;
						string myUser = GetUserName();
						string myDateTime = DateSqlFormat(GetTime());

						SqlConnection myConnection = new SqlConnection(GetConnectionString());
						myConnection.Open();

						SqlTransaction myTransaction = myConnection.BeginTransaction();
						string myQuery = $"INSERT INTO address (addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy)" +
							             $"VALUES ('{myAddressID}', '{myAddress}', ' ', '{myCityID}', '{myZipCode}', '{myPhone}', '{myDateTime}', '{myUser}', '{myUser}')";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection)
							{
								Transaction = myTransaction
							};
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
						return myAddressID;
					}

				// Creates new customer
				public static void CreateCustomer(int myID, string myName, int myaddressID, int myActive, DateTime myDateTime, string myUser)
					{
						string mySqlDate = DateSqlFormat(myDateTime);
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						SqlTransaction myTransaction = myConnection.BeginTransaction();
						string myQuery = $"INSERT into customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdateBy)" +
						    $"VALUES ('{myID}', '{myName}', '{myaddressID}', '{myActive}', '{mySqlDate}', '{myUser}', '{myUser}')";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection)
							{
								Transaction = myTransaction
							};
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
					}

				// Take the CustomerID and return a list of all customer information from the database
				public static List<KeyValuePair<string, object>> FindCustomer(int myCustomerID)
					{
						List<KeyValuePair<string, object>> myList = new List<KeyValuePair<string, object>>();
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myQuery = $"SELECT * FROM customer WHERE customerId = {myCustomerID}";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlDataReader myReader = myCommand.ExecuteReader();

						try
							{
								if (myReader.HasRows)
									{
										myReader.Read();
										myList.Add(new KeyValuePair<string, object>("customerId", myReader[0]));
										myList.Add(new KeyValuePair<string, object>("customerName", myReader[1]));
										myList.Add(new KeyValuePair<string, object>("addressId", myReader[2]));
										myList.Add(new KeyValuePair<string, object>("active", myReader[3]));
										myReader.Close();
									}
								else
									{
										return null;
									}

								object myAddressID = myList.First(myKeyValuePair => myKeyValuePair.Key == "addressId").Value;
								string myAddressQuery = $"SELECT * FROM address WHERE addressId = {myAddressID}";
								myCommand.CommandText = myAddressQuery;
								myCommand.Connection = myConnection;
								SqlDataReader myAddressReader = myCommand.ExecuteReader();

								if (myAddressReader.HasRows)
									{
										myAddressReader.Read();
										myList.Add(new KeyValuePair<string, object>("address", myAddressReader[1]));
										myList.Add(new KeyValuePair<string, object>("cityId", myAddressReader[3]));
										myList.Add(new KeyValuePair<string, object>("postalCode", myAddressReader[4]));
										myList.Add(new KeyValuePair<string, object>("phone", myAddressReader[5]));
										myAddressReader.Close();
									}
								
								object myCityID = myList.First(myKeyValuePair => myKeyValuePair.Key == "cityId").Value;
								string myCityQuery = $"SELECT * FROM city WHERE cityId = {myCityID}";
								myCommand.CommandText = myCityQuery;
								myCommand.Connection = myConnection;
								SqlDataReader myCityReader = myCommand.ExecuteReader();

								if (myCityReader.HasRows)
									{
										myCityReader.Read();
										myList.Add(new KeyValuePair<string, object>("city", myCityReader[1]));
										myList.Add(new KeyValuePair<string, object>("countryId", myCityReader[2]));
										myCityReader.Close();
									}

								object myCountryID = myList.First(myKeyValuePair => myKeyValuePair.Key == "countryId").Value;
								string myCountryQuery = $"SELECT * FROM country WHERE countryId = {myCountryID}";
								myCommand.CommandText = myCountryQuery;
								myCommand.Connection = myConnection;
								SqlDataReader myCountryReader = myCommand.ExecuteReader();

								if (myCountryReader.HasRows)
									{
										myCountryReader.Read();
										myList.Add(new KeyValuePair<string, object>("country", myCountryReader[1]));
										myCountryReader.Close();
									}
								return myList;
							}
						catch (Exception myException)
							{
								MessageBox.Show("Error! " + myException);
								return null;
							}
					}

				// Update Customer
				public static void UpdateCustomer(IDictionary<string, object> myDictionary)
					{
						string myUser = GetUserName();
						DateTime myUTC = GetTime();
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						// Update Country Table
						SqlTransaction myTransaction = myConnection.BeginTransaction();
						string myCountryQuery = $"UPDATE country SET country = '{myDictionary["country"]}', lastUpdateBy = '{myUser}' WHERE countryId = '{myDictionary["countryId"]}'";
						SqlCommand myCommand = new SqlCommand(myCountryQuery, myConnection);
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();

						// Update City Table
						myTransaction = myConnection.BeginTransaction();
						string myCityQuery = $"UPDATE city SET city = '{myDictionary["city"]}', lastUpdateBy = '{myUser}' WHERE cityId = '{myDictionary["cityId"]}'";
						myCommand.CommandText = myCityQuery;
						myCommand.Connection = myConnection;
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();

						// Update Address Table
						myTransaction = myConnection.BeginTransaction();
						string myAddressQuery = $"UPDATE address SET address = '{myDictionary["address"]}', lastUpdateBy = '{myUser}', postalCode = '{myDictionary["postalCode"]}', phone = '{myDictionary["phone"]}' WHERE addressId = '{myDictionary["addressId"]}'";
						myCommand.CommandText = myAddressQuery;
						myCommand.Connection = myConnection;
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();

						// Update Customer Table
						myTransaction = myConnection.BeginTransaction();
						string myCustomerQuery = $"UPDATE customer SET customerName = '{myDictionary["customerName"]}', lastUpdateBy = '{myUser}', active = '{myDictionary["active"]}' WHERE customerId = '{myDictionary["customerId"]}'";
						myCommand.CommandText = myCustomerQuery;
						myCommand.Connection = myConnection;
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
					}

				// Update User Table
				public static void UpdateUser(IDictionary<string, object> myDictionary)
					{
						string myUser = GetUserName();
						DateTime myUTC = GetTime();
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						SqlTransaction myTransaction = myConnection.BeginTransaction();
						string myUserQuery = $"UPDATE user" +
						    $" SET userName = '{myDictionary["userName"]}', password = '{myDictionary["password"]}', active = '{myDictionary["active"]}', lastUpdateBy = '{myUser}'" +
							$" WHERE userId = '{myDictionary["userId"]}'";
						SqlCommand myCommand = new SqlCommand(myUserQuery, myConnection);
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
					}

				public static void DeleteCustomer(IDictionary<string, object> myDictionary)
					{
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						// Delete from Customer Table
						string myCustomerQuery = $"DELETE FROM customer WHERE customerId = '{myDictionary["customerId"]}'";
						SqlCommand myCommand = new SqlCommand(myCustomerQuery, myConnection);
						SqlTransaction myTransaction = myConnection.BeginTransaction();
						myCommand.CommandText = myCustomerQuery;
						myCommand.Connection = myConnection;
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();

						// Delete from Address Table
						myTransaction = myConnection.BeginTransaction();
						string myAddressQuery = $"DELETE FROM address WHERE addressId = '{myDictionary["addressId"]}'";
						myCommand.CommandText = myAddressQuery;
						myCommand.Connection = myConnection;
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();

						// Delete from City Table
						myTransaction = myConnection.BeginTransaction();
						string myCityQuery = $"DELETE FROM city WHERE cityId = '{myDictionary["cityId"]}'";
						myCommand.CommandText = myCityQuery;
						myCommand.Connection = myConnection;
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();

						// Delete from Country Table
						myTransaction = myConnection.BeginTransaction();
						string myCountryQuery = $"DELETE FROM country WHERE countryId = '{myDictionary["countryId"]}'";
						myCommand.CommandText = myCountryQuery;
						myCommand.Connection = myConnection;
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
					}
				
				public static List<KeyValuePair<string, object>> FindUser(int myUserId)
					{
						List<KeyValuePair<string, object>> myList = new List<KeyValuePair<string, object>>();
						SqlConnection myConnection = new SqlConnection(GetConnectionString());
						myConnection.Open();

						string myQuery = $"SELECT * FROM user WHERE userId = {user_Id}";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlDataReader myReader = myCommand.ExecuteReader();

						try
							{
								if (myReader.HasRows)
									{
										myReader.Read();
										myList.Add(new KeyValuePair<string, object>("userId", myReader[0]));
										myList.Add(new KeyValuePair<string, object>("userName", myReader[1]));
										myList.Add(new KeyValuePair<string, object>("password", myReader[2]));
										myList.Add(new KeyValuePair<string, object>("active", myReader[3]));
										myReader.Close();
									}
								return myList;
							}
						catch (Exception myException)
							{
								MessageBox.Show("Error!" + myException);
								return null;
							}
					}

				// Delete User
				public static void DeleteUser(string myUserId)
					{
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myUserQuery = $"DELETE FROM user WHERE userId = '{myUserId}'";
						SqlCommand myCommand = new SqlCommand(myUserQuery, myConnection);
						SqlTransaction myTransaction = myConnection.BeginTransaction();
						myCommand.CommandText = myUserQuery;
						myCommand.Connection = myConnection;
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
					}

				// Creates a new appointment for a customer
				public static void CreateAppointment(int myCustomerID, string myTitle, string myDescription, string myLocation, string myContact, string myType, DateTime myStart, DateTime myEnd)
					{
						int myAppointmentID = GetID("appointment", "appointmentId") + 1;
						int myUserID = 1;
						string mySqlStartDate = DateSqlFormat(myStart);
						string mySqlEndDate = DateSqlFormat(myEnd);
						string myDateTime = DateSqlFormat(GetTime());
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						SqlTransaction myTransaction = myConnection.BeginTransaction();
						string myQuery = $"INSERT INTO appointment (appointmentId, customerId, title, userId, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdateBy)" +
							$"VALUES ('{myAppointmentID}', '{myCustomerID}', '{myTitle}', '{GetUserID()}', '{myDescription}', '{myLocation}', '{myContact}', '{myType}', ' ', '{mySqlStartDate}', '{mySqlEndDate}', '{myDateTime}', '{myUserID}', '{myUserID}')";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
					}

				// Takes a dictionary of data supplied from text fields in the form and saves information to database
				public static void UpdateAppointment(IDictionary<string, object> myDictionary)
					{
						string myUser = GetUserName();
						DateTime myUTC = GetTime();
						DateTime myStart = Convert.ToDateTime(myDictionary["start"]);
						DateTime myEnd = Convert.ToDateTime(myDictionary["end"]);
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						SqlTransaction myTransaction = myConnection.BeginTransaction();
						string myQuery = $"UPDATE appointment SET customerId = '{myDictionary["customerId"]}', title = '{myDictionary["title"]}', description = '{myDictionary["description"]}', location = '{myDictionary["location"]}', contact = '{myDictionary["contact"]}', type = '{myDictionary["type"]}',  start = '{DateSqlFormat(myStart.ToUniversalTime())}', end = '{DateSqlFormat(myEnd.ToUniversalTime())}', url = '{myDictionary["url"]}', lastUpdate = '{DateSqlFormat(myUTC)}',  lastUpdateBy = '{myUser}' WHERE appointmentId = '{myDictionary["appointmentId"]}'";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
					}

				// Returns the appointment information based on appointmentID
				public static List<KeyValuePair<string, object>> GetAppointmentList(int myAppointmentID)
					{
						List<KeyValuePair<string, object>> myList = new List<KeyValuePair<string, object>>();
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myQuery = $"SELECT * FROM appointment WHERE appointmentId = {myAppointmentID}";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlDataReader myReader = myCommand.ExecuteReader();

						try
							{
								if (myReader.HasRows)
									{
										myReader.Read();
										myList.Add(new KeyValuePair<string, object>("appointmentId", myReader[0]));
										myList.Add(new KeyValuePair<string, object>("customerId", myReader[1]));
										myList.Add(new KeyValuePair<string, object>("title", myReader[3]));
										myList.Add(new KeyValuePair<string, object>("description", myReader[4]));
										myList.Add(new KeyValuePair<string, object>("location", myReader[5]));
										myList.Add(new KeyValuePair<string, object>("contact", myReader[6]));
										myList.Add(new KeyValuePair<string, object>("type", myReader[7]));
										myList.Add(new KeyValuePair<string, object>("start", myReader[9]));
										myList.Add(new KeyValuePair<string, object>("end", myReader[10]));
										myReader.Close();
									}
								else
									{
										return null;
									}
								return myList;
							}
						catch (Exception myException)
							{
								Console.WriteLine(myException);
								return null;
							}
					}

				public static List<KeyValuePair<string, object>> GetUserList(int myUserID)
					{
						List<KeyValuePair<string, object>> myList = new List<KeyValuePair<string, object>>();
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myQuery = $"SELECT * FROM user WHERE userId = {myUserID}";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlDataReader myReader = myCommand.ExecuteReader();

						try
							{
								if (myReader.HasRows)
									{
										myReader.Read();
										myList.Add(new KeyValuePair<string, object>("userId", myReader[0]));
										myList.Add(new KeyValuePair<string, object>("userName", myReader[1]));
										myList.Add(new KeyValuePair<string, object>("password", myReader[3]));
										myList.Add(new KeyValuePair<string, object>("enabled", myReader[4]));
										myList.Add(new KeyValuePair<string, object>("location", myReader[5]));
										myReader.Close();
									}
								else
									{
										return null;
									}
								return myList;
							}
						catch (Exception myException)
							{
								Console.WriteLine(myException);
								return null;
							}
					}

				// Returns information if customer has appointments
				public static bool CheckAppointments(string myCustomerID)
					{
						Console.WriteLine(myCustomerID);
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myQuery = $"SELECT * FROM appointment WHERE customerId = {myCustomerID}";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlDataReader myReader = myCommand.ExecuteReader();

						if (myReader.HasRows)
							{
								myReader.Read();
								return true;
							}
						return false;
					}

				// Returns information of next appointment
				public static Dictionary<string, object> GetNextAppointment()
					{
						Dictionary<string, object> myNextAppointment = new Dictionary<string, object>();
						string myUTCOffset = (TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).ToString().Substring(0, 6));
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myQuery = $"SELECT type,  start, (SELECT customerName FROM customer WHERE customerId = appointment.customerId) AS 'Name' FROM appointment WHERE start > now() ORDER BY start LIMIT 1";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlDataReader myReader = myCommand.ExecuteReader();

						if (myReader.HasRows)
							{
								myReader.Read();
								myNextAppointment.Add("type", myReader[0]);
								myNextAppointment.Add("start", Convert.ToDateTime(myReader[1]).ToLocalTime());
								myNextAppointment.Add("name", myReader[2]);
							}
						return myNextAppointment;
					}

				// Returns the amount of times the given appointment time overlaps with existing appointments
				public static int Overlap(DateTime myStart, DateTime myEnd)
					{
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myQuery = $"SELECT count(*)" +
							$"FROM `appointment`" +
							$"WHERE (('{DateSqlFormat(myStart.ToUniversalTime())}' > start AND '{DateSqlFormat(myStart.ToUniversalTime())}' < end) OR ('{DateSqlFormat(myEnd.ToUniversalTime())}'> start AND '{DateSqlFormat(myEnd.ToUniversalTime())}' < end)) AND end > now()" +
							$"ORDER BY start" +
							$"LIMIT 1;";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlDataReader myReader = myCommand.ExecuteReader();
						if (myReader.HasRows)
							{
								myReader.Read();
								string myCount = myReader[0].ToString();
								int myResult = myCount == "0" ? 0 : 1;
								return myResult;
							}
						return 0;
					}

				public static bool AppointmentOverlaps(DateTime myStart, DateTime myEnd)
					{
						foreach (Hashtable myAppointment in GetAppointments().Values)
							{
								if (myStart < DateTime.Parse(myAppointment["end"].ToString()) && DateTime.Parse(myAppointment["start"].ToString()) < myEnd)
									{
										return true;
									}
							}
						return false;
					}

				// Deletes appointments based on Customer ID
				public static void DeleteCustomerAppointments(string myCustomerID)
					{
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myQuery = $"DELETE FROM appointment WHERE customerId = '{myCustomerID}'";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlTransaction myTransaction = myConnection.BeginTransaction();
						myCommand.CommandText = myQuery;
						myCommand.Connection = myConnection;
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
					}

				// Deletes appointments based on Appointment ID
				public static void DeleteAppointment(IDictionary<string, object> myDictionary)
					{
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myQuery = $"DELETE FROM appointment WHERE appointmentId = '{myDictionary["appointmentId"]}'";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlTransaction myTransaction = myConnection.BeginTransaction();
						myCommand.CommandText = myQuery;
						myCommand.Connection = myConnection;
						myCommand.Transaction = myTransaction;
						myCommand.ExecuteNonQuery();
						myTransaction.Commit();
						myConnection.Close();
					}

				public static Dictionary<string, object> AppointmentByMonth (string myType)
					{
						Dictionary<string, object> myReport = new Dictionary<string, object>();
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myQuery = "SELECT DISTINCT" +
							$" (SELECT COUNT(type) FROM appointment WHERE type = '{myType}' and MONTH(appointment.start) = 1) as 'Jan'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = '{myType}' and MONTH(appointment.start) = 2) as 'Feb'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = '{myType}' and MONTH(appointment.start) = 3) as 'Mar'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = '{myType}' and MONTH(appointment.start) = 4) as 'Apr'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = '{myType}' and MONTH(appointment.start) = 5) as 'May'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = '{myType}' and MONTH(appointment.start) = 6) as 'Jun'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = '{myType}' and MONTH(appointment.start) = 7) as 'Jul'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = '{myType}' and MONTH(appointment.start) = 8) as 'Aug'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = '{myType}' and MONTH(appointment.start) = 9) as 'Sep'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = '{myType}' and MONTH(appointment.start) = 10) as 'Oct'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = '{myType}' and MONTH(appointment.start) = 11) as 'Nov'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = '{myType}' and MONTH(appointment.start) = 12) as 'Dec'" +
							" FROM appointment;";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlDataReader myReader = myCommand.ExecuteReader();

						if (myReader.HasRows)
							{
								myReader.Read();
								myReport.Add("Jan", myReader[0]);
								myReport.Add("Feb", myReader[1]);
								myReport.Add("Mar", myReader[2]);
								myReport.Add("Apr", myReader[3]);
								myReport.Add("May", myReader[4]);
								myReport.Add("Jun", myReader[5]);
								myReport.Add("Jul", myReader[6]);
								myReport.Add("Aug", myReader[7]);
								myReport.Add("Sep", myReader[8]);
								myReport.Add("Oct", myReader[9]);
								myReport.Add("Nov", myReader[10]);
								myReport.Add("Dec", myReader[11]);
							}
						return myReport;
					}

				public static DataTable GetAppointmentListByUser(string myID)
					{
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myQuery = $"SELECT (SELECT customerName FROM customer WHERE customerId = appointment.customerId) AS 'Customer', start AS 'Start Time', end AS 'End Time', location AS 'Location', title AS 'Title', type AS 'Type' FROM appointment WHERE createdBy = '{myID}' ORDER BY start;";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						DataTable myDataTable = new DataTable();
						myDataTable.Load(myCommand.ExecuteReader());
						
						foreach (DataRow myRow in myDataTable.Rows)
							{
								DateTime myUTCStart = Convert.ToDateTime(myRow["Start Time"]);
								DateTime myUTCEnd = Convert.ToDateTime(myRow["End Time"]);
								myRow["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(myUTCStart);
								myRow["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(myUTCEnd);
							}
						myConnection.Close();
						return myDataTable;
					}

				 public static DataTable GetAppointmentListByCustomer(string myID)
					{
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myQuery = $"SELECT title AS 'Title', start AS 'Start Time', end AS 'End Time', location AS 'Location', contact AS 'Contact', type AS 'Type' FROM appointment WHERE customerId = '{myID}' ORDER BY start;";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						DataTable myDataTable = new DataTable();
						myDataTable.Load(myCommand.ExecuteReader());

						foreach (DataRow myRow in myDataTable.Rows)
							{
								DateTime myUTCStart = Convert.ToDateTime(myRow["Start Time"]);
								DateTime myUTCEnd = Convert.ToDateTime(myRow["End Time"]);
								myRow["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(myUTCStart);
								myRow["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(myUTCEnd);
							}
						myConnection.Close();
						return myDataTable;
					}

				public static Dictionary<string, object> AppointmentByTypeCount()
					{
						Dictionary<string, object> myReport = new Dictionary<string, object>();
						SqlConnection myConnection = new SqlConnection(Properties.Resources.connectionString.ToString());
						myConnection.Open();

						string myQuery = "SELECT DISTINCT" +
							$" (SELECT COUNT(type) FROM appointment WHERE type = 'Cleaning') AS 'Cleaning'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = 'Cavities') AS 'Cavities'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = 'Wisdom Teeth') AS 'Wisdom Teeth'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = 'Consultation') AS 'Consultation'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = 'Root Canal') AS 'Root Canal'," +
							$" (SELECT COUNT(type) FROM appointment WHERE type = 'Other') AS 'Other'" +
							"FROM appointment";
						SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
						SqlDataReader myReader = myCommand.ExecuteReader();

						if (myReader.HasRows)
							{
								myReader.Read();
								myReport.Add("cleaning", myReader[0]);
								myReport.Add("cavities", myReader[1]);
								myReport.Add("wisdomTeeth", myReader[2]);
								myReport.Add("consultation", myReader[3]);
								myReport.Add("rootCanals", myReader[4]);
								myReport.Add("other", myReader[5]);
							}
						return myReport;
					}

				private static string DateSqlFormat(DateTime myDateValue)
					{
						string mySqlDateTime = myDateValue.ToString("yyyy-MM-dd HH:mm");
						return mySqlDateTime;
					}
			}
	}