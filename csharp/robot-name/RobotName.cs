using System;

public class Robot
{
    public string Name
    {
        get
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            char letterOne = (char) random.Next(0, chars.Length);
            char letterTwo = (char) random.Next(0, chars.Length);
            int min = 001;
            int max = 999;
            int number = random.Next(min, max);
            string name = $"{letterOne}{letterTwo}{number}";
            return name;
        }
    }

    public void Reset()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}