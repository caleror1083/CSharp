using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareCompanyScheduling;

internal class Log
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