class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int distanceDriven;
    private int battery = 100;
    
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
    
    public bool BatteryDrained()
    {
        return this.battery < this.batteryDrain;

    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained()){
        this.distanceDriven += speed;    
        this.battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50,4);
    }
}

class RaceTrack
{
    private int distance;
    
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance){
        this.distance = distance;
    }
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        bool finish = false;
        while(!car.BatteryDrained()){
           car.Drive();
           if(car.DistanceDriven() >= this.distance){
               finish = true;
               break;
           }
       }
        return finish;
    }
}
