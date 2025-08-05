public class CarsAssemble {

    public double productionRatePerHour(int speed) {
        int carsPerHour = 221;
        double production = 0;

        if (speed >=0 && speed <=4){
            production = (carsPerHour * speed);
        }else if (speed >4 && speed <=8){
            production = (carsPerHour * speed) * 0.90;
        }else if (speed == 9){
            production = (carsPerHour * speed) * 0.80;
        }else if (speed >= 10){
            production = (carsPerHour * speed) * 0.77;
        }
        return production;
    }

    public int workingItemsPerMinute(int speed) {
        return (int)productionRatePerHour(speed) / 60;
    }
}
