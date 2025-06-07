public class Truck : Vehicle
{
    public double CargoCapacity { get; set; }

    public void TransportCargo()
    {
        Console.WriteLine("Transporting cargo to its destination.");
    }
}