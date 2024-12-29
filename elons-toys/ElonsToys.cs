using System;

class RemoteControlCar
{
    public int TotalDistance { get; set; } = 0;
    public int BatteryPercentage { get; set; } = 100;
    
    public RemoteControlCar() { }

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {TotalDistance} meters";
    }

    public string BatteryDisplay()
    {
        if (BatteryPercentage == 0)
        {
            return "Battery empty";
        }
        return $"Battery at {BatteryPercentage}%";
    }

    public void Drive()
    {
        if (BatteryPercentage > 0)
        {
            TotalDistance += 20;
            BatteryPercentage -= 1;
        }
    }
}
