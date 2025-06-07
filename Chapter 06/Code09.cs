public class UtilityVehicle : Vehicle
{
    public int LoadCapacity { get; set; }

    public void PerformUtilityTask()
    {
        Console.WriteLine("Completing a utility task.");
    }
}