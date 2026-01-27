class NeedForSpeed {

    private int speed;
    private int batteryDrain;
    private int battery = 100;
    private int metersDriven = 0;
    
    NeedForSpeed(int speed, int batteryDrain) {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public boolean batteryDrained() {
        return battery < batteryDrain;
    }

    public int distanceDriven() {
        return metersDriven;   
    }

    public void drive() {
        if(battery >= batteryDrain){
            metersDriven += speed;
            battery -= batteryDrain;   
        }
    }

    public static NeedForSpeed nitro() {
        return new NeedForSpeed(50,4);
    }
}

class RaceTrack {
    
        int distance;
    
    RaceTrack(int distance) {
        this.distance = distance;
    }

    public boolean canFinishRace(NeedForSpeed car) {
        while (!car.batteryDrained()){
            car.drive();
        }
        if (car.distanceDriven() < distance){
            return false;
        }else {
            return true;
        }
    }
}
