public class Truck : Vehicle
{
    public new void Manufacture(IDbConnection connection)
    {
        // Truck-specific manufacturing implementation
        connection.Connect();
        // Truck manufacturing
        connection.Disconnect();
    }
}