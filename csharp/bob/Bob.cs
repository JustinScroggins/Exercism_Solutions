using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        bool HasDigits = statement.All(char.IsDigit);
        statement = statement.TrimEnd();
        statement = statement.Trim('\n', '\r', '\t');
        if (!HasDigits)
        {
            if (statement.EndsWith('?'))
            {
                return "Sure.";
            }
            else if (statement.Any(c => char.IsUpper(c)))
            {
                return "Whoa, chill out!";
            }
            else if (statement == statement.ToUpper() && statement.EndsWith('?'))
            {
                return "Calm down, I know what I'm doing!";
            }
            else statement.Contains("");
            {
                return "Fine. Be that way!";
            }
        }
        else
        {
            return "Whatever.";
        }

    }
}