using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string alphabet = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
        string[] letters = alphabet.Split(',');
        Dictionary<string, bool> dictionaryAlphabet = new Dictionary<string, bool>();
        
        if (!String.IsNullOrEmpty(input.ToLower()))
        {
            foreach (string letter in letters)
            {
                dictionaryAlphabet.Add(letter, false);
            }
             
            foreach (char letter in input.ToLower())
            {
                if (dictionaryAlphabet.ContainsKey(letter.ToString()))
                    {
                        dictionaryAlphabet[letter.ToString()] = true;
                    }
                }
            
            if (dictionaryAlphabet.ContainsValue(false))
            {
                return false;
            }
            return true;
        }
        else return false;
    }
}