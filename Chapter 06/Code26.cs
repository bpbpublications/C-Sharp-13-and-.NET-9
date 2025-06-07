public interface IVehicle
{
    string Model { get; set; }

    double Price { get; set; }

    double GetTaxRate();
}

public class Car : IVehicle
{
    public string Model { get; set; }
    public double Price { get; set; }

    public double GetTaxRate()
    {
        // Specific implementation for cars.
        return this.Price * 0.18;
    }
}

public class Truck : IVehicle
{
    public string Model { get; set; }
    public double Price { get; set; }

    public double GetTaxRate()
    {
        // Specific implementation for trucks.
        return this.Price * 0.15;
    }
}

public class Motorcycle : IVehicle
{
    public string Model { get; set; }
    public double Price { get; set; }

    public double GetTaxRate()
    {
        // Specific implementation for motorcycles.
        return this.Price * 0.10;
    }
}