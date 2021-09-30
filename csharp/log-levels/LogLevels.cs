using System;
using System.Linq;

string trimStart = string.Empty;
static class LogLine
{
    public static string Message(string logLine)
    {
        string[] logs = logLine.Split(":");
        var trimLog = logs[1].ToString().Trim();
        return trimLog;
    }

    public static string LogLevel(string logLine)
    {
        string[] logs = logLine.Split(":");
        logs[0] = logs[0].TrimStart('[');
        logs[0] = logs[0].TrimEnd(']');
        return logs[0].ToLower();
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
