// Step 1: Define the logging service interface
public interface ILoggerService
{
    void Log(string message);
}

//Step 2: Implement the interface
public class ConsoleLoggerService : ILoggerService
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}

//Step 3: Create a Class that requires logging
public class Processor
{
    private readonly ILoggerService _logger;
    public Processor(ILoggerService logger)
    {
        _logger = logger;
    }

    public void Process(string data)
    {
        // Processing data...
        _logger.Log($"Processing data: {data}");
    }
}

//We have an ILoggerService dependence in the Processor class. The constructor is used to inject this dependency.
//Step 4: Injecting the Dependency
//You may manually inject the dependencies in a basic console application like this:
ILoggerService logger = new ConsoleLoggerService();
Processor processor = new Processor(logger);
processor.Process("Some Data");