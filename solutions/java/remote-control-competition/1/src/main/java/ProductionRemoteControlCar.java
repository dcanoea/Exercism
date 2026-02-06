class ProductionRemoteControlCar implements RemoteControlCar, Comparable<ProductionRemoteControlCar>{
    private int distanceTravelled = 0;
    private int numberOfVictories = 0;

    public void drive() {
        distanceTravelled += 10;
    }

    public int getDistanceTravelled() {
        return distanceTravelled;
    }

    public int getNumberOfVictories() {
        return numberOfVictories;
    }

    public void setNumberOfVictories(int numberOfVictories) {
        this.numberOfVictories += numberOfVictories;
    }

    @Override
    public int compareTo (ProductionRemoteControlCar car){
    if (this.numberOfVictories < car.numberOfVictories) {
        return 1;  // Decimos que 'este' es mayor para que lo mande al final
    } else if (this.numberOfVictories > car.numberOfVictories) {
        return -1; // Decimos que 'este' es menor para que lo suba al principio
    }
    return 0;
    }
}
