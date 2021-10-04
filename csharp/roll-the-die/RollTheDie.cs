using System;

public class Player
{
    public int RollDie()
    {
        Random rnd = new Random();
        int random = rnd.Next(1, 18);
        return random;
    }

    public double GenerateSpellStrength()
    {
        Random rnd = new Random();
        int strength = rnd.Next(0, 100);
        return (double) strength;
    }
}
