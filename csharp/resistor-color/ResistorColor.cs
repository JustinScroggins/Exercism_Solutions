using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColor
{
    public enum Color { Black, Brown, Red, Orange, Yellow, Green, Blue, Violet, Grey, White }
    public static int ColorCode(string color)
    {
        int count = 0;
        List<string> colors = GetColorsAsString();
        foreach (string c in colors)
        {
            if (color == c.ToLower())
            {
                return count;
            }
            count++;
        }
        return count;
    }

    public static string[] Colors()
    {
        List<string> colors = new List<string>();
        foreach (int colorNumber in Enum.GetValues(typeof(Color)))
        {
            string name = ((Color)colorNumber).ToString();
            colors.Add(name.ToLower());
        }
        var colorArray = colors.ToArray();
        return colorArray;
    }

    public static List<string> GetColorsAsString()
    {
        return Enum.GetNames(typeof(Color)).ToList();
    }

}