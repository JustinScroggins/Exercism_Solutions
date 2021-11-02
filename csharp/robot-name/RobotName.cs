using System;
using System.Linq;
using System.Text;

public class Robot
{
    Random random = new Random();
    public Robot()
    {
        _name = this.RandomString();
    }

    private string _name;

    public string Name
    {
        get { return _name; }
        set { Name = value; }
    }


    public void Reset()
    {
        _name = "";
    }

    private string RandomString()
    {
        Random rand = new Random();
        int nums = random.Next(000, 1000);
        var val = nums.ToString("000");
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string letters = new string(Enumerable.Repeat(chars, 2)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        string name = $"{letters}{val}";
        return name;
    }
}
