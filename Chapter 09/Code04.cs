public class Farm
{
    public int FarmId { get; set; }
    public string Name { get; set; }
    public List<Crop> Crops { get; } = new List<Crop>();
}

public abstract class Crop
{
    public int CropId { get; set; }
    public string Variety { get; set; }
    public DateTime PlantingDate { get; set; }
    public DateTime HarvestDate { get; set; }
    public int FarmId { get; set; }
    public Farm Farm { get; set; }
}

public class Vegetable : Crop
{
    public string Type { get; set; }
}

public class Rice : Crop
{
    public string Grade { get; set; }
}

public class Bean : Crop
{
    public string Color { get; set; }
}