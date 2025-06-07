public class Vehicle
{
    public int NumberOfWheels { get; set; }
    public double FuelTankCapacity { get; set; }
    public string Brand { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle started.");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle stopped.");
    }
}