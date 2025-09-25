static class AssemblyLine
{
    static int production = 221;
    
    public static double SuccessRate(int speed)
    {
        if (speed >=1 && speed <=4){
            return 1.00;
        }else if (speed >=5 && speed <=8){
            return 0.90;
        }else if (speed == 9){
            return 0.80;
        }else if (speed == 10){
            return 0.77;
        }else{
            return 0;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return ((double)speed * (double)production) * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed)/60;
    }
}
