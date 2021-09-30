using System;
using System.Linq;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] logs = logLine.Split(":");
        foreach (var log in logs.Skip(0))
        {
            return log;
        }
        return "EOL";
    }

    public static string LogLevel(string logLine)
    {
        string[] logs = logLine.Split(":");
        if (logs[0].Contains("[ERROR]"))
        {
            return "error";
        }
        else if (logs[0].Contains("[WARNING]"))
        {
            return "warning";
        }
        else return "invalid";
    }

    public static string Reformat(string logLine)
    {
        string[] logs = logLine.Split(":");
        foreach (var log in logs)
        {
            string errorType = log[0].ToString();
        }
    }
}
