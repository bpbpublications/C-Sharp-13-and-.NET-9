public class Fruit
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
}

public class ExoticFruit : Fruit
{
    public string CountryOfOrigin { get; set; }
    public string UniqueFeature { get; set; }
}