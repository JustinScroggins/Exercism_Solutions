using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = { 0, 2, 5, 3, 7, 8, 4 };
        return lastWeek;
    }

    public int Today()
    {
        int last = birdsPerDay.Last();
        return last;
    }

    public void IncrementTodaysCount()
    {
        int today = Today();
        today++;
        birdsPerDay[^1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int day in birdsPerDay)
        {
            if (day == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        //int birdsPerDay[numberOfDays];
        //for (int i = 0; i < birdsPerDay[numberOfDays]; i++)
        // still implementing
        return 0;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int day in birdsPerDay)
        {
            if (day >= 5)
            {
                busyDays++;
            }
        }
        return busyDays;
    }
}
