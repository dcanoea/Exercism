public class LogLevels {
    
    public static String message(String logLine) {
    // Busca el primer ": " y toma el texto después de eso, eliminando espacios en blanco
        return logLine.substring(logLine.indexOf(": ") + 2).trim();
    }

    public static String logLevel(String logLine) {
        int start = logLine.indexOf("[")+1;
        int end = logLine.indexOf("]");
        return logLine.substring(start, end).trim().toLowerCase();
    }

    public static String reformat(String logLine) {
        return message(logLine) + " (" + logLevel(logLine) + ")";
    }
}
