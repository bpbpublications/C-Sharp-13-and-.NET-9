class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public void Start()
    {
        Console.WriteLine("Engine started!");
    }
// Other common methods and properties related to vehicles
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
}