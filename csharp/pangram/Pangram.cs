using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        // Arrange data
        string alphabet = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
        string[] letters = alphabet.Split(',');
        Dictionary<string, bool> dictionaryAlphabet = new Dictionary<string, bool>();
        
        if (!String.IsNullOrEmpty(input.ToLower()))
        {
            // Iterate through array of alphabet letters
            foreach (string letter in letters)
            {
                // Add letters to Dictionary
                dictionaryAlphabet.Add(letter, false);
            }
            
            
            foreach (char letter in input)
            {
                // Check if dictionary contains each value each iteration through the input 
                // and if so, setting the value pair for it to false
                if (dictionaryAlphabet.ContainsKey(letter.ToString()))
                {
                    dictionaryAlphabet[letter.ToString()] = false;
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