using System;
using System.IO;

namespace DentalOfficeSchedulingApp;

public static class Log
{
    private static DateTime? _loginTime;
    private static readonly string LogDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DentalOfficeSchedulingApp");
    private static readonly string LogFile = Path.Combine(LogDirectory, "logs.txt");
    public static DateTime? LoginTime => _loginTime;

    public static void Login(string userName)
    {
        _loginTime = DateTime.Now;
        Write($"Login time = {_loginTime:yyyy-MM-dd HH:mm:ss}, " + $"userName = {userName}");
    }

    public static void Logout(string userName)
    {
        Write($"Logout time = {DateTime.Now:yyyy-MM-dd HH:mm:ss}, " + $"userName = {userName}");
        _loginTime = null;
    }

    private static void Write(string message)
    {
        Directory.CreateDirectory(LogDirectory);
        File.AppendAllText(LogFile, message + Environment.NewLine);
    }
}