using System;
using System.Diagnostics.CodeAnalysis;

public class Feature
{
    // Define a feature switch for conditional compilation
    [FeatureSwitchDefinition("Feature.IsSupported")]
    internal static bool IsSupported => AppContext.TryGetSwitch("Feature.IsSupported", out bool isEnabled) ? isEnabled : false;

    internal static void Implementation()
    {
        Console.WriteLine("Feature implementation is running.");
    }
}

public class Program
{
    public static void Main()
    {
        if (Feature.IsSupported)
        {
            Feature.Implementation();
        }
        else
        {
            Console.WriteLine("Feature is disabled.");
        }
    }
}