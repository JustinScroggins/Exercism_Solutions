using System;
using System.Text;

public class Robot
{
    Random random = new Random();
    private string name;
    public string Name
    {
        get
        {
            int value = random.Next(0, 1000);
            string name = $"{RandomString()}{value}";
            return name;
        }

        private set { }
    }

    public void Reset()
    {
        name = "";
    }

    private string RandomString()
    {
        StringBuilder builder = new StringBuilder();
        char ch;
        for (int i = 0; i < 3; i++)
        {
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
            builder.Append(ch);
        }
        return builder.ToString();
    }
}
