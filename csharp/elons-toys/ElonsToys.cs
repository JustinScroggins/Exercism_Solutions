using System;

class RemoteControlCar
{
    public double DistanceDriven { get; set; }
    public int BatteryLife { get; set; } = 100;
    public static RemoteControlCar Buy()
    {
        RemoteControlCar newCar = new RemoteControlCar();
        return newCar;
    }

    public string DistanceDisplay()
    {
        return $"Driven {DistanceDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (BatteryLife == 0)
        {
            return $"Battery empty";
        }
        return $"Battery at {BatteryLife}%";
    }

    public void Drive()
    {
        if (BatteryLife == 0)
        {
            return;
        }
        BatteryLife--;
        DistanceDriven += 20;
    }
}
