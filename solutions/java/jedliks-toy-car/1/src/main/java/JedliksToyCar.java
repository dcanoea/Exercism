public class JedliksToyCar {
    
    private int metersDriven = 0;
    private int battery = 100;
    
    public static JedliksToyCar buy() {
        return new JedliksToyCar();
    }

    public String distanceDisplay() {
        return "Driven " + metersDriven + " meters";
    }

    public String batteryDisplay() {
        if (battery <= 0){
            return "Battery empty";
        }else{
            return "Battery at " + battery + "%";
        }  
    }

    public void drive() {
        if (battery > 0) {
        metersDriven = metersDriven + 20;
        battery--;
        }
    }
}
