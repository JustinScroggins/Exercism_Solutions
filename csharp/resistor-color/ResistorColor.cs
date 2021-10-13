using System;

public static class ResistorColor
{
    public enum Color { Black, Brown, Red, Orange, Yellow, Green, Blue, Violet, Grey, White }
    public static int ColorCode(string color)
    {
        color = color.ToLower();
        foreach (char typeName in Enum.GetValues(typeof(Color)))
        {

        }
    }

    public static string[] Colors()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}