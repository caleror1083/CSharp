/*
    C969 Software II - Advanced C#
    Robert Calero
    Student ID# 000998416
*/

using System;
using System.Collections.Generic;
using System.IO;

namespace WGU_C969
	{
		class Log
			{
				public static void Login(string user)
					{
						var logEvent = new List<string>();
						logEvent.Add(user);
						logEvent.Add(DateTime.Now.ToString());
						
						File.AppendAllText("Appts.txt", "USER LOGIN: ");
						
						foreach (var logItem in logEvent)
							{
								File.AppendAllText("Appts.txt", logItem + " ");
							}
						File.AppendAllText("Appts.txt", Environment.NewLine);
					}
			}
	}