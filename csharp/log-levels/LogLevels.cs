using System;
using System.Linq;

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
        string logType = LogLevel(logLine);
        string formatted = $"{logs[1].Trim()} ({logType})";
        return formatted;
    }
}
