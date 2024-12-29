using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        if (logLine.StartsWith("[INFO]: "))
        {
            return $"{logLine.Substring(8).Trim()}";
        }
        else if (logLine.StartsWith("[WARNING]: "))
        {
            return $"{logLine.Substring(11).Trim()}";
        }
        else if (logLine.StartsWith("[ERROR]: "))
        {
            return $"{logLine.Substring(9).Trim()}";
        }
        else
        {
            return $"{logLine}.Trim()";
        }
    }

    public static string LogLevel(string logLine)
    {
        if (logLine.StartsWith("[INFO]: "))
        {
            return "info";
        }
        else if (logLine.StartsWith("[WARNING]: "))
        {
            return "warning";
        }
        else if (logLine.StartsWith("[ERROR]: "))
        {
            return "error";
        }
        else
        {
            return "unknown";
        }
    }

    public static string Reformat(string logLine)
    {
        if (logLine.StartsWith("[INFO]: "))
        {
            return $"{logLine.Substring(8).Trim()} (info)";
        }
        else if (logLine.StartsWith("[WARNING]: "))
        {
            return $"{logLine.Substring(11).Trim()} (warning)";
        }
        else if (logLine.StartsWith("[ERROR]: "))
        {
            return $"{logLine.Substring(9).Trim()} (error)";
        }
        else
        {
            return $"{logLine.Trim()} (unknown)";
        }
    }
}
