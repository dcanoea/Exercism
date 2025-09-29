public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        // Dividir el número de teléfono en tres partes (código de área, código central y número local)
        string[] partsNumbers = phoneNumber.Split('-');

        // Verificar que se tiene exactamente tres partes
        if (partsNumbers.Length != 3)
            return (false, true, string.Empty); // Si el número no tiene el formato correcto, retornamos falso y vacío

        // Asignar las partes del teléfono a las variables
        string NewYorkDial = partsNumbers[0];
        string Prefix = partsNumbers[1];
        string LocalNumber = partsNumbers[2];

        // Comprobar si el código de área es de Nueva York
        bool isNewYork = NewYorkDial == "212";

        // Comprobar si el número es falso (prefijo es "555")
        bool isFake = Prefix == "555";

        // Retornar la tupla con los resultados
        return (isNewYork, isFake, LocalNumber);
    }

    // Método IsFake que utiliza el resultado de Analyze()
    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake; // Devolver directamente si el número es falso según la propiedad IsFake
    }
}