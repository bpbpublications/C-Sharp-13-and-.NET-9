using System;
using System.Diagnostics.CodeAnalysis;

public static class Feature
{
    [FeatureSwitchDefinition("Feature.AdvancedLogging")]
    public static bool IsSupported => AppContext.TryGetSwitch("Feature.AdvancedLogging", out bool isEnabled) ? isEnabled : false;

    public static void LogMessage(string message)
    {
        if (IsSupported)
        {
            DetailedLogging(message);
        }
        else
        {
            BasicLogging(message);
        }
    }

    private static void DetailedLogging(string message)
    {
        Console.WriteLine($"[DETAILED LOG] {DateTime.Now}: {message}");
    // Add additional logging details, like stack trace, method info, etc.
    }

    private static void BasicLogging(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}

public class Program
{
    public static void Main()
    {
        Feature.LogMessage("Application started.");
    }
}