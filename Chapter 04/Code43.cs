using System.Collections.Generic;
using Xunit.Abstractions;
using Xunit.Sdk;

public class SkipIfTestCaseDiscoverer : IXunitTestCaseDiscoverer
{
    public IEnumerable<IXunitTestCase> Discover(ITestFrameworkDiscoveryOptions discoveryOptions, ITestMethod testMethod, IAttributeInfo factAttribute)
    {
        bool shouldSkip = factAttribute.GetNamedArgument<bool>("ShouldSkip");
        string reason = factAttribute.GetNamedArgument<string>("Reason");
        if (shouldSkip)
        {
            yield return new XunitTestCase(testMethod, reason, new object[] { });
        }
    }
}