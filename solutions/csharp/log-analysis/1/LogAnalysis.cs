public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string log, string delimiter){
        int start = log.IndexOf(delimiter) + delimiter.Length;
        return log.Substring(start); 
    }
    
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string log, string delimiter1, string delimiter2){
        int start = log.IndexOf(delimiter1) + delimiter1.Length;
        int end = log.IndexOf(delimiter2);
        return log.Substring(start, end - start);
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string log){
        int start = log.IndexOf(':') + 1;
        return log.Substring(start).Trim();
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
        public static string LogLevel(this string log){
        int start = log.IndexOf('[') + 1;
        int end = log.IndexOf(']') - 1;
        return log.Substring(start, end);
    }
}