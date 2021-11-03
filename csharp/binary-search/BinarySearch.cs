using System;
using System.Linq;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        for (int i = 0; i < input.Length; i++)
        {
            var binary = (input.Length / 2);
            if (input[i] == value)
            {
                return i;
                if (i < binary)
                {
                    i = binary;
                }
            }
        }
        return -1;
    }
}