using Xunit.Abstractions;
using Xunit.Sdk;

internal class XunitTestCase : IXunitTestCase
{
    public Exception InitializationException => throw new NotImplementedException();

    public IMethodInfo Method => throw new NotImplementedException();

    public int Timeout => throw new NotImplementedException();

    public string DisplayName => throw new NotImplementedException();

    public string SkipReason => throw new NotImplementedException();

    public ISourceInformation SourceInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public ITestMethod TestMethod => throw new NotImplementedException();

    public object[] TestMethodArguments => throw new NotImplementedException();

    public Dictionary<string, List<string>> Traits => throw new NotImplementedException();

    public string UniqueID => throw new NotImplementedException();

    public void Deserialize(IXunitSerializationInfo info)
    {
        throw new NotImplementedException();
    }

    public Task<RunSummary> RunAsync(IMessageSink diagnosticMessageSink, IMessageBus messageBus, object[] constructorArguments, ExceptionAggregator aggregator, CancellationTokenSource cancellationTokenSource)
    {
        throw new NotImplementedException();
    }

    public void Serialize(IXunitSerializationInfo info)
    {
        throw new NotImplementedException();
    }
}