
class BirdWatcher {
    private final int[] birdsPerDay;

    public BirdWatcher(int[] birdsPerDay) {
        this.birdsPerDay = birdsPerDay.clone();
    }

    public int[] getLastWeek() {
       return new int[]{0,2,5,3,7,8,4};
    }

    public int getToday() {
        return birdsPerDay[birdsPerDay.length-1];
    }

    public void incrementTodaysCount() {
        birdsPerDay[birdsPerDay.length-1]++;
    }

    public boolean hasDayWithoutBirds() {
        boolean birds = false;
        for(int bird: birdsPerDay){
            if(bird==0){
                return true;
            }
        }
        return birds;
    }

    public int getCountForFirstDays(int numberOfDays) {
        int countBirds=0;
        if(numberOfDays < birdsPerDay.length){
            for (int i=0; i<=birdsPerDay[numberOfDays-1]; i++){
                countBirds= countBirds+birdsPerDay[i];
            }
        }else{
            for (int i=0; i<birdsPerDay.length; i++){
                countBirds= countBirds+birdsPerDay[i];
            }
        }
        return countBirds;
    }

    public int getBusyDays() {
        int busyDays=0;
        for (int i=0; i<birdsPerDay.length; i++){
            if(birdsPerDay[i] >= 5){
                busyDays++;
            }
        }
    return busyDays;
    }
}
