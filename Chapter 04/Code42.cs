using System;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class SkipIfAttribute : Attribute
{
    public bool ShouldSkip { get; private set; }
    public string Reason { get; private set; }

    public SkipIfAttribute(bool shouldSkip, string reason)
    {
        ShouldSkip = shouldSkip;
        Reason = reason;
    }
}