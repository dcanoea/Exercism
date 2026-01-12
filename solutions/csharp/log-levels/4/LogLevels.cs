static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(':',2)[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf('[')+1;
        int end = logLine.IndexOf(']')-1;
        return logLine.Substring(start, end).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
