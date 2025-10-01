class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0,2,5,3,7,8,4};
    }

    public int Today()
    {
        return birdsPerDay.Last();
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[6]++;
    }

    public bool HasDayWithoutBirds()
    {
        bool noBirds = false;
        foreach (int bird in birdsPerDay){
            if (bird == 0){
                noBirds = true;
            }
        }
        return noBirds;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for(int i=0; i<numberOfDays; i++){
            count += birdsPerDay[i];
        }
        return count;
    }

    public int BusyDays()
    {
        int countBusyDays = 0;
        foreach (int bird in birdsPerDay){
            if (bird >= 5){
                countBusyDays++;
            }
        }
        return countBusyDays;    
    }
}
