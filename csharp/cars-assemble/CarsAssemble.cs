using System;

static class AssemblyLine
{
    public static double ProductionRatePerHour(int speed)
    {
        int carsPerHour = 221;
        switch (speed)
        {
            case 1:
                return speed * carsPerHour;
            case 2:
                return speed * carsPerHour;
            case 3:
                return speed * carsPerHour;
            case 4:
                return speed * carsPerHour;
            case 5:
                return speed * (Convert.ToDouble(carsPerHour) * 0.9);
            case 6:
                return speed * (Convert.ToDouble(carsPerHour) * 0.9);
            case 7:
                return speed * (Convert.ToDouble(carsPerHour) * 0.9);
            case 8:
                return speed * (Convert.ToDouble(carsPerHour) * 0.9);
            case 9:
                return speed * (Convert.ToDouble(carsPerHour) * 0.8);
            case 10:
                return speed * (Convert.ToDouble(carsPerHour) * 0.77);
        }
        return 0;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double ratePerHour = ProductionRatePerHour(speed);
        var result = ratePerHour / 60;
        return (int) result;
    }
}
