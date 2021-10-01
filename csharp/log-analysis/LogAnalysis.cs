using System;
using System.Collections.Generic;
using System.Linq;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string text, string delimeter)
    {
        string[] pieces = text.Split(delimeter);
        return pieces[1];
    }

    public static string SubstringBetween(this string text, string delim1, string delim2)
    {
        string[] contents = text.Split(": ");
        contents[0] = contents[0].Trim(delim1.ToCharArray());
        contents[0] = contents[0].Trim(delim2.ToCharArray());
        return contents[0];
    }

    public static string Message(this string text)
    {
        string[] contents = text.Split(": ");
        return contents[1];
    }
    public static string LogLevel(this string text)
    {
        string[] contents = text.Split(": ");
        contents[0] = contents[0].Trim('[');
        contents[0] = contents[0].Trim(']');
        return contents[0];
    }
}