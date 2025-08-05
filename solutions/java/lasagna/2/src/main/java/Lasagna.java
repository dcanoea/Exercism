public class Lasagna {
    
    public int expectedMinutesInOven(){
        return 40;
    }

    public int remainingMinutesInOven(int minutesInOven){
        int expectedMinutes = expectedMinutesInOven();
        return expectedMinutes - minutesInOven;
    }

    public int preparationTimeInMinutes(int layers){
        return layers*2;
    }

    public int totalTimeInMinutes(int layers, int minutesInOven){
        int layersTime = preparationTimeInMinutes(layers);
        return layersTime + minutesInOven;
    }
}
