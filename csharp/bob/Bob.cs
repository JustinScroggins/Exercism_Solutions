using System;
using System.Collections.Generic;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.EndsWith('?'))
        {
            return "Sure.";
        }
        else if (statement == statement.ToUpper())
        {
            return "Whoa, chill out!";
        }
        else if (statement == statement.ToUpper() && statement.EndsWith('?'))
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (statement.Contains(""))
        {
            return "Fine. Be that way!";
        }
        else
        {
            return "Whatever.";
        }
    }
}