class SqueakyClean {
    static String clean(String identifier) {
        StringBuilder result = new StringBuilder();
        boolean upperNext = false; //controla si el siguiente caracter será en mayúscula

        //Convertimos el String en un array de char
        char[] chars = identifier.toCharArray();

        //Mediante un for each recorremos cada char del array
        for(char c : chars){
            if (c == ' '){ //Si es espacio, lo convierte en _
                result.append('_');
                upperNext = false;
            } else if (c == '-'){ // Si es - marcamos que el siguiente caracter será mayúscula
                upperNext = true;
            } else { //Si es un carácter cualquiera
                if(Character.isDigit(c)){ //Si es un número
                    switch (c){
                        case '0': result.append('o'); break;
                        case '1': result.append('l'); break;
                        case '3': result.append('e'); break;
                        case '4': result.append('a'); break;
                        case '7': result.append('t'); break;
                    }
                } else if (Character.isLetter(c)){ // Si es una letra
                    if (upperNext){ //Si está marcado, convierte el carácter en mayúscula
                        result.append(Character.toUpperCase(c));
                        upperNext = false;
                    }else { //Si no está marcado, copia la letra tal cual
                        result.append(c);
                    }
                }
            }
            //Cualquier otro carácter lo ignora
        }
        return result.toString();        
    }
}