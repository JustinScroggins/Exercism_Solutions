using System;
using System.Collections.Generic;

public static class ResistorColor
{
    public enum Color { Black, Brown, Red, Orange, Yellow, Green, Blue, Violet, Grey, White }
    public static int ColorCode(string color)
    {
        color = color.ToLower();
        foreach (int colorNumber in Enum.GetValues(typeof(Color)))
        {
            if (color == colorNumber.ToString())
            {
                return colorNumber;
            }
        }
        return 0;
    }

    public static string[] Colors()
    {
        foreach (string colorName in Enum.GetValues(typeof(Color)))
        {
            List<string> colors = new List<string>();
            colors.Add(colorName);
            var colorArray = colors.ToArray();
            return colorArray;
        }
        return null;
    }
}