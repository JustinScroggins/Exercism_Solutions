using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

public class Robot
{
    public Robot()
    {
        Name = NextName();
    }

    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }


    public void Reset()
    {
        Name = NextName();
    }


    static string[] Names = Enumerable
      .Range(0, 26 * 26)
      .SelectMany(letters => Enumerable
         .Range(0, 1000)
         .Select(i => $"{(char)('A' + letters / 26)}{(char)('A' + letters % 26)}{i:000}"))
      .OrderBy(item => Guid.NewGuid())
      .ToArray();

    static int currentIndex = -1;

    static string NextName() =>
      Names[Interlocked.Increment(ref currentIndex) % Names.Length];
}
