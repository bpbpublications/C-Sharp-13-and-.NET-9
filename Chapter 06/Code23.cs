public interface IVehicle
{
    void Drive();
}

public class Vehicle : IVehicle
{
    public virtual void Drive()
    {
        Console.WriteLine("The vehicle drives.");
    }
}

public class Car : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("The car drives.");
    }
}

public class Truck : Vehicle
{
    public new void Drive()
    {
        Console.WriteLine("The truck drives.");
    }
}