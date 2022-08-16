using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Namespaces
namespace DentalOfficeSchedulingApp
	{
		// Classes
		class Log
			{
				// Fields
				private static DateTime? _myTime;

				// Methods(Parameters)
				public static DateTime? GetTime() => _myTime;
				public static void SetTime(DateTime? currentTime) => _myTime = currentTime;

				public static void Login(string currentUserName)
					{
						DateTime myTime = DateTime.Now.ToLocalTime();
						Dictionary<DateTime, string> myDictionary = new Dictionary<DateTime, string> { {myTime, currentUserName} };
						SetTime(myTime);

						foreach (KeyValuePair<DateTime, string> myKeyValue in myDictionary)
							{
								string myLog = string.Format("Login time = {0}, userName = {1}", myKeyValue.Key, myKeyValue.Value);
								StringBuilder myStringBuilder = new StringBuilder();
								myStringBuilder.Append(myLog + Environment.NewLine);
								File.AppendAllText(Application.StartupPath + "_logs.txt", myStringBuilder.ToString());
								myStringBuilder.Clear();
							}
					}

				public static void Reminder()
					{
						try
							{
								Dictionary<string, object> myList = Database.GetNextAppointment();
								IDictionary<string, object> myDictionary = myList.ToDictionary(myPair => myPair.Key, myPair => myPair.Value);
								DateTime? theCurrentTime = GetTime();
								string myType = myDictionary["type"].ToString();
								DateTime? theNextAppointment = Convert.ToDateTime(myDictionary["start"]);
								string myName = myDictionary["name"].ToString();

								if (theCurrentTime != null && theNextAppointment != null)
									{
										DateTime myDateTime = theCurrentTime.Value;
										DateTime myDateTime2 = theNextAppointment.Value;
										string myDateString = theNextAppointment.Value.ToString("h:mm tt");
										TimeSpan myDifference = myDateTime2.Subtract(myDateTime);

										if (myDifference.Minutes < 15)
											{
												MessageBox.Show("Reminder: " + myName + " has a " + myType +" appointment at " + myDateString + "");
											}
									}
							}
						catch (Exception myException)
							{
								Console.WriteLine(myException);
							}
					}

				public static void Logout(string currentUserName)
					{
						Dictionary<DateTime, string> myDictionary = new Dictionary<DateTime, string>();
						myDictionary.Add(DateTime.Now, currentUserName);

						foreach (KeyValuePair<DateTime, string> myKeyValue in myDictionary)
							{
								string myLog = string.Format("Logout time = {0}, userName = {1}", myKeyValue.Key, myKeyValue.Value);
								StringBuilder myStringBuilder = new StringBuilder();
								myStringBuilder.Append(myLog + Environment.NewLine);
								File.AppendAllText(Application.StartupPath + "_logs.txt", myStringBuilder.ToString());
								myStringBuilder.Clear();
							}
					}
			}
	}