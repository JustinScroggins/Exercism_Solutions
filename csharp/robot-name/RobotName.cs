using System;
using System.Reflection;
using System.Text.RegularExpressions;

public class Robot
{

    private string name;

    public string Name
    {
        get
        {
            Regex regex = new Regex("[0-9]+[a-zA-Z][a-zA-Z][a-zA-Z]", RegexOptions.IgnoreCase);
            string name = regex.ToString();
            return name;
        }
        set { name = value; }
    }


    public void Reset()
    {
        Robot robot = new Robot();
        robot.Name = "";
    }
}