public class Vehicle
{
    public virtual void Manufacture(IDbConnection connection)
    {
        // Basic manufacturing implementation
        connection.Connect();
        // Vehicle manufacturing
        connection.Disconnect();
    }
}

public class Car : Vehicle
{
    public override void Manufacture(IDbConnection connection)
    {
        // Car-specific manufacturing implementation
        connection.Connect();
        // Car manufacturing
        connection.Disconnect();
    }
}