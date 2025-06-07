public interface ITransientService
{
    Guid GetOperationID();
}

public interface IScopedService
{
    Guid GetOperationID();
}

public interface ISingletonService
{
    Guid GetOperationID();
}

public class TransientService : ITransientService
{
    private Guid _operationID;
    public TransientService()
    {
        _operationID = Guid.NewGuid();
    }

    public Guid GetOperationID() => _operationID;
}

public class ScopedService : IScopedService
{
    private Guid _operationID;
    public ScopedService()
    {
        _operationID = Guid.NewGuid();
    }

    public Guid GetOperationID() => _operationID;
}

public class SingletonService : ISingletonService
{
    private Guid _operationID;
    public SingletonService()
    {
        _operationID = Guid.NewGuid();
    }

    public Guid GetOperationID() => _operationID;
}