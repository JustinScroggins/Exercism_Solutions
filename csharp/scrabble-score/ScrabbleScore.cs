using System;

public enum Letters
{
    A, E, I, O, U, L, N, R, S, T = 1,
    D, G = 2,
    B, C, M, P = 3,
    F, H, V, W, Y = 4,
    K = 5,
    J, X = 8,
    Q, Z = 10
}
public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int score = 0;
        char[] letters = input.ToCharArray();
        foreach (char letter in letters)
        {
            bool isMatch = Enum.IsDefined(typeof(Letters), letter.ToString());
            if (isMatch)
            {
                score += (int)Letters[letter];
            }
        }
        return score;
    }
}