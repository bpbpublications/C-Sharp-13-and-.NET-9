public class LuxuryCar : Vehicle
{
    public string InteriorMaterial { get; set; }

    public void MassageSeats()
    {
        Console.WriteLine("Enjoying a relaxing massage while driving!");
    }
}