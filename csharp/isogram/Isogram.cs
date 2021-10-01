using System;
using System.Collections.Generic;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (word.Length < 1)
        {
            return true;

        }

        Dictionary<string, bool> alphabet = new Dictionary<string, bool>();
        string alphabetString = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
        string[] formattedAlphabet = alphabetString.Split(",");
        foreach (string letter in formattedAlphabet)
        {
            alphabet.Add(letter, false);
        }

        foreach (char letter in word)
        {
            if (alphabet.ContainsKey(letter.ToString()))
            {
                bool oldVal;
                alphabet.TryGetValue(letter.ToString(), out oldVal);
                alphabet[letter.ToString()] = true;
                return oldVal;
            }
        }
        return false;
    }
}
