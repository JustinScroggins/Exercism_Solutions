using System;
using System.Collections.Generic;
using System.Linq;

public static class ResistorColor
{
    public enum Color { Black, Brown, Red, Orange, Yellow, Green, Blue, Violet, Grey, White }
    public static int ColorCode(string color)
    {
        int count = 0;
        foreach (int colorNumber in Enum.GetValues(typeof(Color)))
        {
            var colorName = colorNumber.ToString();
            if (color == colorName)
            {
                return count;
            }
            count++;
        }
        return 0;
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

}