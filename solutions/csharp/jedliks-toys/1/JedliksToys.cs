class RemoteControlCar
{
    int MetersDriven = 0;
    int BatteryPercent = 100;
    
    public static RemoteControlCar Buy()
    {
         return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {MetersDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (BatteryPercent == 0){
            return "Battery empty";
        }else{
            return $"Battery at {BatteryPercent}%";
        }
    }

    public void Drive()
    {
        if (BatteryPercent > 0){
            MetersDriven += 20;
            BatteryPercent -= 1;
        }
    }
}
