using System;
using System.Collections.Generic;

public static class ScrabbleScore
{
    public static Dictionary<char, int> count = new Dictionary<char, int>();
    public static string OnePoint { get; } = "a,e,i,o,u,l,n,r,s,t";
    public static string TwoPoints { get; } = "d,g";
    public static string ThreePoints { get; } = "b,c,m,p";
    public static string FourPoints { get; } = "f,h,v,w,y";
    public static string FivePoints { get; } = "k";
    public static string EightPoints { get; } = "j,x";
    public static string TenPoints { get; } = "q,z";

    public static int Score(string input)
    {
        int score = 0;
        char[] letters = input.ToCharArray();
        foreach (char letter in letters)
        {
            
        }
        return score;
    }
}