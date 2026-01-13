public static class Darts
{
    public static int Score(double x, double y)
    {
        //Teorema de Pitágoras. Calcula a cuanta distancia cae el dardo del centro de la diana.
        // Raiz cuadrada de x2 + y2;
        double radio = Math.Sqrt((x*x)+(y*y));

        if(radio <= 1){
            return 10;
        }else if (radio <= 5){
            return 5;
        }else if (radio <= 10){
            return 1;
        }else {
            return 0;
        }
        
    }
}
