public class SportsCar : Vehicle
{
    public int Horsepower { get; set; }

    public void Drift()
    {
        Console.WriteLine("Performing a drift!");
    }
}