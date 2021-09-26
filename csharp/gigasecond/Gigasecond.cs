using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        TimeSpan span = new TimeSpan(0, 0, 1000000000);

        if (moment != null)
        {
            DateTime result = moment.Add(span);
            return result;
        }
        // Code smell
        return DateTime.Now;
    }
}