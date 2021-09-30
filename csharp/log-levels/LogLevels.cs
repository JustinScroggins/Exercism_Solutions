using System;
using System.Linq;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] logs = logLine.Split(":");

        // Target the collection not each instance
            
            var trimLog = logs[1].ToString().Trim();

        return trimLog;
    }

    public static string LogLevel(string logLine)
    {
        string[] logs = logLine.Split(":");
        // Trim out the text inside the brackets
        if (logs[0].Contains("[ERROR]"))
        {
            return "error";
        }
        else if (logs[0].Contains("[WARNING]"))
        {
            return "warning";
        }
        else return "info";
    }

    public static string Reformat(string logLine)
    {
        string[] logs = logLine.Split(":");
        foreach (var log in logs)
        {
            string errorType = log[0].ToString();
            string errorBody = log[1].ToString();
            return ($"{errorBody} ({errorType})");
        }
        return $"EOL";
    }
}
