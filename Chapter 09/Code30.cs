// Enable Lazy Loading by adding virtual keyword
public class Farm
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public virtual List<Crop> Crops { get; set; }
}

using (var context = new FarmingContext())
{
    var farm = context.Farms.First();
    var crops = farm.Crops; // Lazy Loading: This line triggers a separate query to load crops
}